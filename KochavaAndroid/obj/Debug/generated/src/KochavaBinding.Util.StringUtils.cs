using System;
using System.Collections.Generic;
using Android.Runtime;

namespace KochavaBinding.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.util']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/kochava/android/util/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kochava/android/util/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.util']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StringUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_inputStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.util']/class[@name='StringUtils']/method[@name='inputStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("inputStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string InputStreamToString (global::System.IO.Stream p0)
		{
			if (id_inputStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_inputStreamToString_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "inputStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_inputStreamToString_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
