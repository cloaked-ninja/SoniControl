/*
 * Copyright (c) 2018, 2019, 2020. Peter Kopciak, Kevin Pirner, Alexis Ringot, Florian Taurer, Matthias Zeppelzauer.
 *
 * This file is part of SoniControl app.
 *
 *     SoniControl app is free software: you can redistribute it and/or modify
 *     it under the terms of the GNU General Public License as published by
 *     the Free Software Foundation, either version 3 of the License, or
 *     (at your option) any later version.
 *
 *     SoniControl app is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU General Public License for more details.
 *
 *     You should have received a copy of the GNU General Public License
 *     along with SoniControl app.  If not, see <http://www.gnu.org/licenses/>.
 */

package at.ac.fhstp.sonicontrol.utils;

import android.content.Context;
import android.util.Log;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

import at.ac.fhstp.sonicontrol.ConfigConstants;
import at.ac.fhstp.sonicontrol.Technology;
import edu.emory.mathcs.jtransforms.fft.DoubleFFT_1D;

public class Recognition {
    private static final String TAG = "Recognition";

    /**
     * Computes the signal recognition and returns the most likely Technology. If no Technology
     * seems likely enough, we return Technoloy.UNKNOWN. Expects a preprocessed mono audio buffer,
     * highpass filtered already to remove audible frequencies.
     * @param bufferHistory Mono audio buffer highpass filtered
     * @param context Context to read technology characteristics' files
     * @return the most likely Technology for this audio buffer
     */
    public static Technology computeRecognition(float[] bufferHistory, Context context) {
        double[] historySignalFFT = getFouriersCoeffiecients(bufferHistory);

        double fftMax = 0;
        for (int i = 0; i < historySignalFFT.length; i++) {
            if (historySignalFFT[i] > fftMax) {
                fftMax = historySignalFFT[i];
            }
        }

        return computeRecognition(historySignalFFT, bufferHistory.length, fftMax, context);
    }

    /**
     * Computes the signal recognition and returns the most likely Technology. If no Technology
     * seems likely enough, we return Technoloy.UNKNOWN. Expects an FFT spectrum of the
     * (preprocessed) signal.
     * @param historySignalFFT FFT spectrum of the signal
     * @param nSamplesHistory FFT spectrum length
     * @param fftMax Highest energy in the FFT spectrum
     * @param context Context to read technology characteristics' files
     * @return the most likely Technology for this audio buffer
     */
    private static Technology computeRecognition(double[] historySignalFFT, int nSamplesHistory, double fftMax, Context context) {
        Technology recogResult = Technology.UNKNOWN;

        int[] nearbyCenterFrequencies = getCenterFrequencies(Technology.GOOGLE_NEARBY, context);
        int[] lisnrCenterFrequencies = getCenterFrequencies(Technology.LISNR, context);
        int[] prontolyCenterFrequencies = getCenterFrequencies(Technology.PRONTOLY, context);
        int[] shopkickCenterFrequencies = getCenterFrequencies(Technology.SHOPKICK, context);
        int[] silverpushCenterFrequencies = getCenterFrequencies(Technology.SILVERPUSH, context);
        int[] sonitalkCenterFrequencies = getCenterFrequencies(Technology.SONITALK, context);
        int[] signal360CenterFrequencies = getCenterFrequencies(Technology.SIGNAL360, context);
        int[] sonaraxCenterFrequencies = getCenterFrequencies(Technology.SONARAX, context);

        // 3. Perform recognition of the individual technologies
        Technology[] technologies = {Technology.GOOGLE_NEARBY, Technology.LISNR, Technology.PRONTOLY, Technology.SHOPKICK, Technology.SILVERPUSH, Technology.SONITALK, Technology.SIGNAL360, Technology.SONARAX, Technology.UNKNOWN};

        // Recognition is hierarchical:
        // First check if the signal is a nearby message with the autocorrelation detector:
        double scoreNearby = 0.0;
        double scoreLisnr = 0.0;
        double scoreProntoly = 0.0;
        double scoreShopkick = 0.0;
        double scoreSilverpush = 0.0;
        double scoreSoniTalk = 0.0;
        double scoreSignal360 = 0.0;
        double scoreSonarax = 0.0;

        for (int i = 0; i < historySignalFFT.length; i++) {
            historySignalFFT[i] = historySignalFFT[i] / fftMax; // divide by the maximum, so that the theoretical max value of the resulting score can be 1 (minimum = 0)
        }

        //Log.d(TAG, "Compute score Nearby");
        scoreNearby = detectActivity(historySignalFFT, fftMax, nearbyCenterFrequencies, ConfigConstants.NEARBY_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score Lisnr");
        scoreLisnr = detectActivity(historySignalFFT, fftMax, lisnrCenterFrequencies, ConfigConstants.LISNR_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score Prontoly");
        scoreProntoly = detectActivity(historySignalFFT, fftMax, prontolyCenterFrequencies, ConfigConstants.PRONTOLY_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score Shopkick");
        scoreShopkick = detectActivity(historySignalFFT, fftMax, shopkickCenterFrequencies, ConfigConstants.SHOPKICK_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score Silverpush");
        scoreSilverpush = detectActivity(historySignalFFT, fftMax, silverpushCenterFrequencies, ConfigConstants.SILVERPUSH_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score SoniTalk");
        scoreSoniTalk = detectActivity(historySignalFFT, fftMax, sonitalkCenterFrequencies, ConfigConstants.SONITALK_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score Signal360");
        scoreSignal360 = detectActivity(historySignalFFT, fftMax, signal360CenterFrequencies, ConfigConstants.SIGNAL360_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);
        //Log.d(TAG, "Compute score Sonarax");
        scoreSonarax = detectActivity(historySignalFFT, fftMax, sonaraxCenterFrequencies, ConfigConstants.SONARAX_BANDWIDTH, ConfigConstants.SCAN_SAMPLE_RATE, nSamplesHistory, ConfigConstants.LOWER_CUTOFF_FREQUENCY);


        double[] scores = {scoreNearby, scoreLisnr, scoreProntoly, scoreShopkick, scoreSilverpush, scoreSoniTalk, scoreSignal360, scoreSonarax}; //the 0 stands for nearby (in case of AC detection)
        double maxScore = 0.0;
        for (int i = 0; i < scores.length; i++) {
            if (scores[i] > maxScore) {
                maxScore = scores[i];
                recogResult = technologies[i];
            }
            Log.d(TAG, "Score " + technologies[i].toString() + ": " + scores[i]);
        }
        if (maxScore < 1) { //no technology achieved a high score -> declare the message as unknown message
            recogResult = Technology.UNKNOWN;
        }
        //}
//
//      %make some debug output:
//    %  disp(['detected: ' num2str(techniques{recogResult}) ' message']);
//    %  scores
        Log.d(TAG, "recogResult: " + recogResult);
        return recogResult;
    }

    private static double detectActivity(double[] fftSpectrum, double fftMax, int[] centerFreq, double bandwidth, int fs, int nSamples, int cutOffFrequency) {
        double score = 0.0;

        int nBands = centerFreq.length;
        //TODO: What happens if some frequencies are under the cutoff or above fs/2 ?
        int nOffBands = nBands + 1; // Starts at cutoff frequency and stops at the highest frequency

        double[] bandEnergy = new double[nBands];
        Arrays.fill(bandEnergy, 0.0);
        for (int i = 0; i < nBands; i++) {
            int bandStartFreqIdx = freq2idx((centerFreq[i] - bandwidth/2.0), fs, nSamples);
            int bandEndFreqIdx = freq2idx((centerFreq[i] + bandwidth/2.0), fs, nSamples);

            for (int j = bandStartFreqIdx; j < bandEndFreqIdx; j++) {
                if (fftSpectrum[j] > bandEnergy[i]) {
                    bandEnergy[i] = fftSpectrum[j];
                }
            }
        }

        double[] offBandEnergy = new double[nOffBands];
        Arrays.fill(offBandEnergy, 0.0);
        double sumOffBandEnergy = 0.0;
        for (int i = 0; i < nOffBands; i++) {
            int bandStartFreqIdx = 0;
            int bandEndFreqIdx = 0;

            if (i == 0) {
                bandStartFreqIdx = freq2idx(cutOffFrequency, fs, nSamples); //Starts at cutoffFrequency
                bandEndFreqIdx = freq2idx(centerFreq[0] - bandwidth/2.0, fs, nSamples) - 1; //remove 1 to avoid overlap with the "on"-frequency bands
            }
            else if (i == nOffBands-1) {
                bandStartFreqIdx = freq2idx(centerFreq[centerFreq.length - 1] + bandwidth/2.0, fs, nSamples) + 1; //add 1 to avoid overlap with the "on"-frequency bands
                bandEndFreqIdx = freq2idx(Math.floor(fs/2) - 1, fs, nSamples); // Ends at the highest frequency possible
            }
            else {
                bandStartFreqIdx = freq2idx((centerFreq[i-1] + bandwidth/2.0), fs, nSamples) + 1; //add 1 to avoid overlap with the "on"-frequency bands
                bandEndFreqIdx = freq2idx((centerFreq[i] - bandwidth/2.0), fs, nSamples) - 1; //remove 1 to avoid overlap with the "on"-frequency bands
            }

            int nbIdx = bandEndFreqIdx-bandStartFreqIdx+1;
            double[] offBands = new double[nbIdx];

            if (nbIdx >= 0)
                System.arraycopy(fftSpectrum, bandStartFreqIdx, offBands, 0, nbIdx);

            //Arrays.sort(offBands); // UNCOMMENT IF USING MEDIAN
            offBandEnergy[i] = max(offBands);//Using the maximum gave the most interpretable results. //median(offBands);

            sumOffBandEnergy += offBandEnergy[i];
            //Log.d(TAG, "offBandEnergy[" + i + "] Idx in ["+bandStartFreqIdx+":"+bandEndFreqIdx+"]: " + String.format("%.12f", offBandEnergy[i]));
        }

        //get the highest quarter of the in band frequencies (in case not all are present)
        Arrays.sort(bandEnergy);
        double quantileToKeep = 0.75; //Keep the 75% highest values (in case some frequencies were not sent this time)
        int startQuantileIdx = (int) Math.ceil(nBands * (1-quantileToKeep));

        double sumInBandEnergy = 0.0;
        for (int i = startQuantileIdx; i < nBands; i++) {
            sumInBandEnergy += bandEnergy[i];
        }

        double inBandScore = sumInBandEnergy / (nBands-startQuantileIdx);
        double outBandScore = sumOffBandEnergy / nOffBands;

        score = inBandScore/outBandScore;

        return score;
    }

    /**
     * Returns the autocorrelation score for Google Nearby.
     *
     * Absolute lower limit for nearby detection is: 50ms windows
     * Below that the frequencies of nearby are not at all separable
     * For a good AC estimate 200ms winSize are necessary
     * Additionally, to get a good frequency distribution, a long-time analysis needs to be performed.
     * This means, that at least 1s (better 2s) should be analyzed at once, to make sure that all
     * nearby frequencies are contained in the analysis.
     *
     *
     * To do: try out zero padding for shorter analysis windows? Does it improve the detection for e.g. 50ms
     *
     * Note: For the pure detection of nearby, an RMS-based method (detectNearbyFast()) is much more robust and  computationally more efficient
     *
     * @param fftSpectrum fft spectrum of the history buffer to be analyzed
     * @param nearbyCenterFrequencies integer array containing the center frequencies used by Nearby
     * @param fs sample rate
     * @param nSamples number of samples in the fftSpectrum
     * @return autocorrelation score for nearby
     */
    private static double detectNearby(double[] fftSpectrum, int[] nearbyCenterFrequencies, int fs, int nSamples) {
        double score = 0.0;

        // Compute the spacing between center frequencies into centerFreqIdxDiff
        int[] centerFreqIdx = new int[nearbyCenterFrequencies.length];
        int[] centerFreqIdxDiffs = new int[centerFreqIdx.length - 1];
        for (int i = 0; i < centerFreqIdx.length; i++) {
            centerFreqIdx[i] = freq2idx((double) nearbyCenterFrequencies[i], fs, nSamples);
            if (i > 0) {
                centerFreqIdxDiffs[i-1] = centerFreqIdx[i] - centerFreqIdx[i-1];
            }
        }
        Arrays.sort(centerFreqIdxDiffs);
        int centerFreqIdxDiff = centerFreqIdxDiffs[centerFreqIdxDiffs.length/2]; // If the length is even we take the upper index (indexes cannot be split in two anyways).

        // We work only on the relevant part of the spectrum (Nearby frequencies)
        final int nbIdxOfInterest = centerFreqIdx[centerFreqIdx.length - 1] + 1 - centerFreqIdx[0];
        double[] fftSpectrumOfInterest = new double[nbIdxOfInterest];
        /*for (int i = centerFreqIdx[0]; i <= centerFreqIdx[centerFreqIdx.length - 1]; i++) {
            fftSpectrumOfInterest[helpCounter] = fftSpectrum[i];
        }
        */
        // IDE suggested to replace the loop with System.arraycopy:
        if (nbIdxOfInterest >= 0)
            System.arraycopy(fftSpectrum, centerFreqIdx[0], fftSpectrumOfInterest, 0, nbIdxOfInterest);

        // We compute the autocorrelation for a frequency range (maxLag) of 5 Nearby center frequencies so that we can calculate the energy at these frequencies versus in between (18500,18524,18548,18571,18595)
        int maxLag = centerFreqIdxDiff*5;
        double[] ac = new double[maxLag];
        Autocorrelation.bruteForceAutoCorrelation(fftSpectrumOfInterest, ac, maxLag);

        // Normalize (first value is the max as it is 100% correlating)
        for (int i = 1; i < maxLag; i++) {
            ac[i] /= ac[0];
        }
        ac[0] = 1;

        double inFrequencyScore  = ac[centerFreqIdxDiff] * ac[2*centerFreqIdxDiff] * ac[3*centerFreqIdxDiff] * ac[4*centerFreqIdxDiff];
        double outFrequencyScore = ac[(int) Math.floor(centerFreqIdxDiff*1.5)] * ac[(int) Math.floor(centerFreqIdxDiff*2.5)] * ac[(int) Math.floor(centerFreqIdxDiff*3.5)] * ac[(int) Math.floor(centerFreqIdxDiff*4.5)]; //round might give an index out of bound (e.g. if the diff is 1)

        Log.d(TAG, "inFrequencyScore: " + inFrequencyScore);
        Log.d(TAG, "outFrequencyScore: " + outFrequencyScore);

        if (inFrequencyScore > outFrequencyScore)
            score = (inFrequencyScore-outFrequencyScore);
        else
            score = 0;

        return score;
    }

    /**
     * Calculates an absolute value of a complex number
     * @param real
     * @param imaginary
     * @return the absolute value of the real and imaginary parts passed
     */
    public static double getComplexAbsolute(double real, double imaginary) {
        return Math.sqrt(real*real + (imaginary*imaginary));
    }

    private static int[] getCenterFrequencies(Technology technology, Context context) {
        String fileName = "";
        //according to the name of the technology the right file will be scanned and split into lines for each frequency
        switch (technology) {
            case PRONTOLY:
                fileName = "prontoly-frequencies.txt";
                break;
            case GOOGLE_NEARBY:
                fileName = "nearby-frequencies.txt";
                break;
            case LISNR:
                fileName = "lisnr-frequencies.txt";
                break;
            case SIGNAL360:
                fileName = "signal360-frequencies.txt";
                break;
            case SHOPKICK:
                fileName = "shopkick-frequencies.txt";
                break;
            case SILVERPUSH:
                fileName = "silverpush-frequencies.txt";
                break;
            case SONITALK:
                fileName = "sonitalk-frequencies.txt";
                break;
            case SONARAX:
                fileName = "sonarax-frequencies.txt";
                break;
            case UNKNOWN:
                fileName = "unknown-frequencies.txt";
                break;
        }

        BufferedReader reader = null;
        int[] frequencies = null;

        try {
            reader = new BufferedReader(new InputStreamReader(context.getAssets().open(fileName), "UTF-8"));

            String[] stringFrequencies = reader.readLine().split(",");
            frequencies = new int[stringFrequencies.length];
            for (int i = 0; i < frequencies.length; i++) {
                frequencies[i] = Integer.parseInt(stringFrequencies[i]);
            }
        } catch (IOException e) {
            Log.e(TAG, "Problem when accessing the technology frequencies file: " + e.getMessage());
            return null;
        } finally {
            if (reader != null) {
                try {
                    reader.close();
                } catch (IOException e) {
                    //log the exception
                    e.printStackTrace();
                }
            }
        }
        return frequencies;
    }

    public static int freq2idx(double freq, int fs, int winLen) {
        return (int) Math.round(freq/fs*winLen);
    }

    public static double[] getFouriersCoeffiecients(float[] rawAudio) {
        HammingWindow hammWin = new HammingWindow(rawAudio.length);
        DoubleFFT_1D mFFT = new DoubleFFT_1D(rawAudio.length);
        double[] fftDouble = new double[rawAudio.length];
        double[] fftAbsolute = new double[rawAudio.length / 2];

        // Convert float array to double array
        for (int i = 0; i < rawAudio.length; i++) {
            fftDouble[i] = rawAudio[i];
        }

        hammWin.applyWindow(fftDouble);
        mFFT.realForward(fftDouble);

        // Get absolute value of the complex FFT result
        int helpCounter = 0;
        for (int l = 0; l < fftDouble.length; l += 2) {
            // Increment by 2 to always get the real value
            double absolute = getComplexAbsolute(fftDouble[l], fftDouble[l + 1]);
            fftAbsolute[helpCounter] = absolute;
            helpCounter++;
        }

        return fftAbsolute;
    }


    /**
     * Helper to get maximum value out of double array
     * @param values array to get the max of
     * @return the highest value of the array passed
     */
    public static double max(double[] values) {
        double max = 0;
        double helper;
        for(int i = 0; i < values.length; i++){
            helper = values[i];
            if(helper > max){
                max = helper;
            }
        }
        return max;
    }

    /**
     * the array double[] m MUST BE SORTED
     * @param m
     * @return the mean of the array passed
     */
    public static double mean(double[] m) {
        double sum = 0;
        for (int i = 0; i < m.length; i++) {
            sum += m[i];
        }
        return sum / m.length;
    }

    /**
     * the array double[] m MUST BE SORTED
     * @param m
     * @return the median of the array passed
     */
    public static double median(double[] m) {
        int middle = m.length/2;
        if (m.length%2 == 1) {
            return m[middle];
        } else {
            return (m[middle-1] + m[middle]) / 2.0;
        }
    }
}
