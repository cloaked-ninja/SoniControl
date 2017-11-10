using System;
using System.Collections.Generic;
using Android.Runtime;

namespace PL.Edu.Icm.Jlargearrays {

	// Metadata.xml XPath class reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']"
	[global::Android.Runtime.Register ("pl/edu/icm/jlargearrays/ComplexFloatLargeArray", DoNotGenerateAcw=true)]
	public partial class ComplexFloatLargeArray : global::PL.Edu.Icm.Jlargearrays.LargeArray {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("pl/edu/icm/jlargearrays/ComplexFloatLargeArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ComplexFloatLargeArray); }
		}

		protected ComplexFloatLargeArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register (".ctor", "([F)V", "")]
		public unsafe ComplexFloatLargeArray (float[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([F)V", __args);
					return;
				}

				if (id_ctor_arrayF == IntPtr.Zero)
					id_ctor_arrayF = JNIEnv.GetMethodID (class_ref, "<init>", "([F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=1 and parameter[1][@type='pl.edu.icm.jlargearrays.FloatLargeArray']]"
		[Register (".ctor", "(Lpl/edu/icm/jlargearrays/FloatLargeArray;)V", "")]
		public unsafe ComplexFloatLargeArray (global::PL.Edu.Icm.Jlargearrays.FloatLargeArray p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lpl/edu/icm/jlargearrays/FloatLargeArray;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lpl/edu/icm/jlargearrays/FloatLargeArray;)V", __args);
					return;
				}

				if (id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_ == IntPtr.Zero)
					id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lpl/edu/icm/jlargearrays/FloatLargeArray;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayFarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "([F[F)V", "")]
		public unsafe ComplexFloatLargeArray (float[] p0, float[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([F[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([F[F)V", __args);
					return;
				}

				if (id_ctor_arrayFarrayF == IntPtr.Zero)
					id_ctor_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "([F[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayFarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayFarrayF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_Lpl_edu_icm_jlargearrays_FloatLargeArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=2 and parameter[1][@type='pl.edu.icm.jlargearrays.FloatLargeArray'] and parameter[2][@type='pl.edu.icm.jlargearrays.FloatLargeArray']]"
		[Register (".ctor", "(Lpl/edu/icm/jlargearrays/FloatLargeArray;Lpl/edu/icm/jlargearrays/FloatLargeArray;)V", "")]
		public unsafe ComplexFloatLargeArray (global::PL.Edu.Icm.Jlargearrays.FloatLargeArray p0, global::PL.Edu.Icm.Jlargearrays.FloatLargeArray p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lpl/edu/icm/jlargearrays/FloatLargeArray;Lpl/edu/icm/jlargearrays/FloatLargeArray;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lpl/edu/icm/jlargearrays/FloatLargeArray;Lpl/edu/icm/jlargearrays/FloatLargeArray;)V", __args);
					return;
				}

				if (id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_Lpl_edu_icm_jlargearrays_FloatLargeArray_ == IntPtr.Zero)
					id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_Lpl_edu_icm_jlargearrays_FloatLargeArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lpl/edu/icm/jlargearrays/FloatLargeArray;Lpl/edu/icm/jlargearrays/FloatLargeArray;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_Lpl_edu_icm_jlargearrays_FloatLargeArray_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lpl_edu_icm_jlargearrays_FloatLargeArray_Lpl_edu_icm_jlargearrays_FloatLargeArray_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe ComplexFloatLargeArray (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		public unsafe ComplexFloatLargeArray (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_JarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/constructor[@name='ComplexFloatLargeArray' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "(J[F)V", "")]
		public unsafe ComplexFloatLargeArray (long p0, float[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ComplexFloatLargeArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J[F)V", __args);
					return;
				}

				if (id_ctor_JarrayF == IntPtr.Zero)
					id_ctor_JarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(J[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JarrayF, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_getAbsArray;
		public unsafe global::PL.Edu.Icm.Jlargearrays.FloatLargeArray AbsArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getAbsArray' and count(parameter)=0]"
			[Register ("getAbsArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;", "GetGetAbsArrayHandler")]
			get {
				if (id_getAbsArray == IntPtr.Zero)
					id_getAbsArray = JNIEnv.GetMethodID (class_ref, "getAbsArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.FloatLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAbsArray), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getArgArray;
		public unsafe global::PL.Edu.Icm.Jlargearrays.FloatLargeArray ArgArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getArgArray' and count(parameter)=0]"
			[Register ("getArgArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;", "GetGetArgArrayHandler")]
			get {
				if (id_getArgArray == IntPtr.Zero)
					id_getArgArray = JNIEnv.GetMethodID (class_ref, "getArgArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.FloatLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArgArray), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getImaginaryArray;
		public unsafe global::PL.Edu.Icm.Jlargearrays.FloatLargeArray ImaginaryArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getImaginaryArray' and count(parameter)=0]"
			[Register ("getImaginaryArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;", "GetGetImaginaryArrayHandler")]
			get {
				if (id_getImaginaryArray == IntPtr.Zero)
					id_getImaginaryArray = JNIEnv.GetMethodID (class_ref, "getImaginaryArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.FloatLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImaginaryArray), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRealArray;
		public unsafe global::PL.Edu.Icm.Jlargearrays.FloatLargeArray RealArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getRealArray' and count(parameter)=0]"
			[Register ("getRealArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;", "GetGetRealArrayHandler")]
			get {
				if (id_getRealArray == IntPtr.Zero)
					id_getRealArray = JNIEnv.GetMethodID (class_ref, "getRealArray", "()Lpl/edu/icm/jlargearrays/FloatLargeArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::PL.Edu.Icm.Jlargearrays.FloatLargeArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRealArray), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_get_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get", "(J)[F", "")]
		public unsafe float[] Get (long p0)
		{
			if (id_get_J == IntPtr.Zero)
				id_get_J = JNIEnv.GetMethodID (class_ref, "get", "(J)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_J, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getBoolean_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getBoolean", "(J)Z", "")]
		public override sealed unsafe bool GetBoolean (long p0)
		{
			if (id_getBoolean_J == IntPtr.Zero)
				id_getBoolean_J = JNIEnv.GetMethodID (class_ref, "getBoolean", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_J, __args);
			} finally {
			}
		}

		static IntPtr id_getBooleanData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getBooleanData' and count(parameter)=0]"
		[Register ("getBooleanData", "()[Z", "")]
		public override sealed unsafe bool[] GetBooleanData ()
		{
			if (id_getBooleanData == IntPtr.Zero)
				id_getBooleanData = JNIEnv.GetMethodID (class_ref, "getBooleanData", "()[Z");
			try {
				return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBooleanData), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static IntPtr id_getBooleanData_arrayZJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getBooleanData' and count(parameter)=4 and parameter[1][@type='boolean[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getBooleanData", "([ZJJJ)[Z", "")]
		public override sealed unsafe bool[] GetBooleanData (bool[] p0, long p1, long p2, long p3)
		{
			if (id_getBooleanData_arrayZJJJ == IntPtr.Zero)
				id_getBooleanData_arrayZJJJ = JNIEnv.GetMethodID (class_ref, "getBooleanData", "([ZJJJ)[Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool[] __ret = (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBooleanData_arrayZJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (bool));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getByte", "(J)B", "")]
		public override sealed unsafe sbyte GetByte (long p0)
		{
			if (id_getByte_J == IntPtr.Zero)
				id_getByte_J = JNIEnv.GetMethodID (class_ref, "getByte", "(J)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getByte_J, __args);
			} finally {
			}
		}

		static IntPtr id_getByteData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getByteData' and count(parameter)=0]"
		[Register ("getByteData", "()[B", "")]
		public override sealed unsafe byte[] GetByteData ()
		{
			if (id_getByteData == IntPtr.Zero)
				id_getByteData = JNIEnv.GetMethodID (class_ref, "getByteData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getByteData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getByteData_arrayBJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getByteData' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getByteData", "([BJJJ)[B", "")]
		public override sealed unsafe byte[] GetByteData (byte[] p0, long p1, long p2, long p3)
		{
			if (id_getByteData_arrayBJJJ == IntPtr.Zero)
				id_getByteData_arrayBJJJ = JNIEnv.GetMethodID (class_ref, "getByteData", "([BJJJ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getByteData_arrayBJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getComplexData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getComplexData' and count(parameter)=0]"
		[Register ("getComplexData", "()[F", "")]
		public unsafe float[] GetComplexData ()
		{
			if (id_getComplexData == IntPtr.Zero)
				id_getComplexData = JNIEnv.GetMethodID (class_ref, "getComplexData", "()[F");
			try {
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComplexData), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getComplexData_arrayFJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getComplexData' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getComplexData", "([FJJJ)[F", "")]
		public unsafe float[] GetComplexData (float[] p0, long p1, long p2, long p3)
		{
			if (id_getComplexData_arrayFJJJ == IntPtr.Zero)
				id_getComplexData_arrayFJJJ = JNIEnv.GetMethodID (class_ref, "getComplexData", "([FJJJ)[F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComplexData_arrayFJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getComplexDouble_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getComplexDouble' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getComplexDouble", "(J)[D", "")]
		public unsafe double[] GetComplexDouble (long p0)
		{
			if (id_getComplexDouble_J == IntPtr.Zero)
				id_getComplexDouble_J = JNIEnv.GetMethodID (class_ref, "getComplexDouble", "(J)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComplexDouble_J, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static IntPtr id_getComplexFloat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getComplexFloat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getComplexFloat", "(J)[F", "")]
		public unsafe float[] GetComplexFloat (long p0)
		{
			if (id_getComplexFloat_J == IntPtr.Zero)
				id_getComplexFloat_J = JNIEnv.GetMethodID (class_ref, "getComplexFloat", "(J)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getComplexFloat_J, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[[F", "")]
		public unsafe float[][] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[[F");
			try {
				return (float[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (float[]));
			} finally {
			}
		}

		static IntPtr id_getDouble_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDouble", "(J)D", "")]
		public override sealed unsafe double GetDouble (long p0)
		{
			if (id_getDouble_J == IntPtr.Zero)
				id_getDouble_J = JNIEnv.GetMethodID (class_ref, "getDouble", "(J)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDouble_J, __args);
			} finally {
			}
		}

		static IntPtr id_getDoubleData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getDoubleData' and count(parameter)=0]"
		[Register ("getDoubleData", "()[D", "")]
		public override sealed unsafe double[] GetDoubleData ()
		{
			if (id_getDoubleData == IntPtr.Zero)
				id_getDoubleData = JNIEnv.GetMethodID (class_ref, "getDoubleData", "()[D");
			try {
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDoubleData), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static IntPtr id_getDoubleData_arrayDJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getDoubleData' and count(parameter)=4 and parameter[1][@type='double[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getDoubleData", "([DJJJ)[D", "")]
		public override sealed unsafe double[] GetDoubleData (double[] p0, long p1, long p2, long p3)
		{
			if (id_getDoubleData_arrayDJJJ == IntPtr.Zero)
				id_getDoubleData_arrayDJJJ = JNIEnv.GetMethodID (class_ref, "getDoubleData", "([DJJJ)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDoubleData_arrayDJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getFloat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFloat", "(J)F", "")]
		public override sealed unsafe float GetFloat (long p0)
		{
			if (id_getFloat_J == IntPtr.Zero)
				id_getFloat_J = JNIEnv.GetMethodID (class_ref, "getFloat", "(J)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFloat_J, __args);
			} finally {
			}
		}

		static IntPtr id_getFloatData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getFloatData' and count(parameter)=0]"
		[Register ("getFloatData", "()[F", "")]
		public override sealed unsafe float[] GetFloatData ()
		{
			if (id_getFloatData == IntPtr.Zero)
				id_getFloatData = JNIEnv.GetMethodID (class_ref, "getFloatData", "()[F");
			try {
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFloatData), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getFloatData_arrayFJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getFloatData' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getFloatData", "([FJJJ)[F", "")]
		public override sealed unsafe float[] GetFloatData (float[] p0, long p1, long p2, long p3)
		{
			if (id_getFloatData_arrayFJJJ == IntPtr.Zero)
				id_getFloatData_arrayFJJJ = JNIEnv.GetMethodID (class_ref, "getFloatData", "([FJJJ)[F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFloatData_arrayFJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getFromNative_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getFromNative' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFromNative", "(J)[F", "")]
		public unsafe float[] GetFromNative (long p0)
		{
			if (id_getFromNative_J == IntPtr.Zero)
				id_getFromNative_J = JNIEnv.GetMethodID (class_ref, "getFromNative", "(J)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromNative_J, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static IntPtr id_getInt_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getInt", "(J)I", "")]
		public override sealed unsafe int GetInt (long p0)
		{
			if (id_getInt_J == IntPtr.Zero)
				id_getInt_J = JNIEnv.GetMethodID (class_ref, "getInt", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_J, __args);
			} finally {
			}
		}

		static IntPtr id_getIntData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getIntData' and count(parameter)=0]"
		[Register ("getIntData", "()[I", "")]
		public override sealed unsafe int[] GetIntData ()
		{
			if (id_getIntData == IntPtr.Zero)
				id_getIntData = JNIEnv.GetMethodID (class_ref, "getIntData", "()[I");
			try {
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntData), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_getIntData_arrayIJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getIntData' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getIntData", "([IJJJ)[I", "")]
		public override sealed unsafe int[] GetIntData (int[] p0, long p1, long p2, long p3)
		{
			if (id_getIntData_arrayIJJJ == IntPtr.Zero)
				id_getIntData_arrayIJJJ = JNIEnv.GetMethodID (class_ref, "getIntData", "([IJJJ)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntData_arrayIJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getLong_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getLong", "(J)J", "")]
		public override sealed unsafe long GetLong (long p0)
		{
			if (id_getLong_J == IntPtr.Zero)
				id_getLong_J = JNIEnv.GetMethodID (class_ref, "getLong", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_J, __args);
			} finally {
			}
		}

		static IntPtr id_getLongData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getLongData' and count(parameter)=0]"
		[Register ("getLongData", "()[J", "")]
		public override sealed unsafe long[] GetLongData ()
		{
			if (id_getLongData == IntPtr.Zero)
				id_getLongData = JNIEnv.GetMethodID (class_ref, "getLongData", "()[J");
			try {
				return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLongData), JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static IntPtr id_getLongData_arrayJJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getLongData' and count(parameter)=4 and parameter[1][@type='long[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getLongData", "([JJJJ)[J", "")]
		public override sealed unsafe long[] GetLongData (long[] p0, long p1, long p2, long p3)
		{
			if (id_getLongData_arrayJJJJ == IntPtr.Zero)
				id_getLongData_arrayJJJJ = JNIEnv.GetMethodID (class_ref, "getLongData", "([JJJJ)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLongData_arrayJJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getShort_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getShort' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getShort", "(J)S", "")]
		public override sealed unsafe short GetShort (long p0)
		{
			if (id_getShort_J == IntPtr.Zero)
				id_getShort_J = JNIEnv.GetMethodID (class_ref, "getShort", "(J)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getShort_J, __args);
			} finally {
			}
		}

		static IntPtr id_getShortData;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getShortData' and count(parameter)=0]"
		[Register ("getShortData", "()[S", "")]
		public override sealed unsafe short[] GetShortData ()
		{
			if (id_getShortData == IntPtr.Zero)
				id_getShortData = JNIEnv.GetMethodID (class_ref, "getShortData", "()[S");
			try {
				return (short[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShortData), JniHandleOwnership.TransferLocalRef, typeof (short));
			} finally {
			}
		}

		static IntPtr id_getShortData_arraySJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getShortData' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getShortData", "([SJJJ)[S", "")]
		public override sealed unsafe short[] GetShortData (short[] p0, long p1, long p2, long p3)
		{
			if (id_getShortData_arraySJJJ == IntPtr.Zero)
				id_getShortData_arraySJJJ = JNIEnv.GetMethodID (class_ref, "getShortData", "([SJJJ)[S");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				short[] __ret = (short[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShortData_arraySJJJ, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getUnsignedByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='getUnsignedByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getUnsignedByte", "(J)S", "")]
		public override sealed unsafe short GetUnsignedByte (long p0)
		{
			if (id_getUnsignedByte_J == IntPtr.Zero)
				id_getUnsignedByte_J = JNIEnv.GetMethodID (class_ref, "getUnsignedByte", "(J)S");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getUnsignedByte_J, __args);
			} finally {
			}
		}

		static IntPtr id_set_JLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='set' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(JLjava/lang/Object;)V", "")]
		public override sealed unsafe void Set (long p0, global::Java.Lang.Object p1)
		{
			if (id_set_JLjava_lang_Object_ == IntPtr.Zero)
				id_set_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(JLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_JLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_setBoolean_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setBoolean' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setBoolean", "(JZ)V", "")]
		public override sealed unsafe void SetBoolean (long p0, bool p1)
		{
			if (id_setBoolean_JZ == IntPtr.Zero)
				id_setBoolean_JZ = JNIEnv.GetMethodID (class_ref, "setBoolean", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBoolean_JZ, __args);
			} finally {
			}
		}

		static IntPtr id_setByte_JB;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setByte' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='byte']]"
		[Register ("setByte", "(JB)V", "")]
		public override sealed unsafe void SetByte (long p0, sbyte p1)
		{
			if (id_setByte_JB == IntPtr.Zero)
				id_setByte_JB = JNIEnv.GetMethodID (class_ref, "setByte", "(JB)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setByte_JB, __args);
			} finally {
			}
		}

		static IntPtr id_setComplexDouble_JarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setComplexDouble' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='double[]']]"
		[Register ("setComplexDouble", "(J[D)V", "")]
		public unsafe void SetComplexDouble (long p0, double[] p1)
		{
			if (id_setComplexDouble_JarrayD == IntPtr.Zero)
				id_setComplexDouble_JarrayD = JNIEnv.GetMethodID (class_ref, "setComplexDouble", "(J[D)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setComplexDouble_JarrayD, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_setComplexFloat_JarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setComplexFloat' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float[]']]"
		[Register ("setComplexFloat", "(J[F)V", "")]
		public unsafe void SetComplexFloat (long p0, float[] p1)
		{
			if (id_setComplexFloat_JarrayF == IntPtr.Zero)
				id_setComplexFloat_JarrayF = JNIEnv.GetMethodID (class_ref, "setComplexFloat", "(J[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setComplexFloat_JarrayF, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_setDouble_JD;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setDouble' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='double']]"
		[Register ("setDouble", "(JD)V", "")]
		public override sealed unsafe void SetDouble (long p0, double p1)
		{
			if (id_setDouble_JD == IntPtr.Zero)
				id_setDouble_JD = JNIEnv.GetMethodID (class_ref, "setDouble", "(JD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDouble_JD, __args);
			} finally {
			}
		}

		static IntPtr id_setFloat_JF;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setFloat' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
		[Register ("setFloat", "(JF)V", "")]
		public override sealed unsafe void SetFloat (long p0, float p1)
		{
			if (id_setFloat_JF == IntPtr.Zero)
				id_setFloat_JF = JNIEnv.GetMethodID (class_ref, "setFloat", "(JF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloat_JF, __args);
			} finally {
			}
		}

		static IntPtr id_setInt_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setInt' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("setInt", "(JI)V", "")]
		public override sealed unsafe void SetInt (long p0, int p1)
		{
			if (id_setInt_JI == IntPtr.Zero)
				id_setInt_JI = JNIEnv.GetMethodID (class_ref, "setInt", "(JI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInt_JI, __args);
			} finally {
			}
		}

		static IntPtr id_setLong_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("setLong", "(JJ)V", "")]
		public override sealed unsafe void SetLong (long p0, long p1)
		{
			if (id_setLong_JJ == IntPtr.Zero)
				id_setLong_JJ = JNIEnv.GetMethodID (class_ref, "setLong", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLong_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_setShort_JS;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setShort' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='short']]"
		[Register ("setShort", "(JS)V", "")]
		public override sealed unsafe void SetShort (long p0, short p1)
		{
			if (id_setShort_JS == IntPtr.Zero)
				id_setShort_JS = JNIEnv.GetMethodID (class_ref, "setShort", "(JS)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShort_JS, __args);
			} finally {
			}
		}

		static IntPtr id_setToNative_JLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setToNative' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setToNative", "(JLjava/lang/Object;)V", "")]
		public override sealed unsafe void SetToNative (long p0, global::Java.Lang.Object p1)
		{
			if (id_setToNative_JLjava_lang_Object_ == IntPtr.Zero)
				id_setToNative_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setToNative", "(JLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToNative_JLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_setUnsignedByte_JS;
		// Metadata.xml XPath method reference: path="/api/package[@name='pl.edu.icm.jlargearrays']/class[@name='ComplexFloatLargeArray']/method[@name='setUnsignedByte' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='short']]"
		[Register ("setUnsignedByte", "(JS)V", "")]
		public override sealed unsafe void SetUnsignedByte (long p0, short p1)
		{
			if (id_setUnsignedByte_JS == IntPtr.Zero)
				id_setUnsignedByte_JS = JNIEnv.GetMethodID (class_ref, "setUnsignedByte", "(JS)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnsignedByte_JS, __args);
			} finally {
			}
		}

	}
}