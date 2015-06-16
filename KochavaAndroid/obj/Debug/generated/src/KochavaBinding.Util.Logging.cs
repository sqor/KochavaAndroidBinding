using System;
using System.Collections.Generic;
using Android.Runtime;

namespace KochavaBinding.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']"
	[global::Android.Runtime.Register ("com/kochava/android/util/Logging", DoNotGenerateAcw=true)]
	public partial class Logging : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		protected const string Logtag = (string) "KochavaTracker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']/field[@name='REQLOGTAG']"
		[Register ("REQLOGTAG")]
		protected const string Reqlogtag = (string) "KochavaRequirements";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kochava/android/util/Logging", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logging); }
		}

		protected Logging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']/constructor[@name='Logging' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logging ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Logging)) {
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

		static IntPtr id_Log_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']/method[@name='Log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Log", "(Ljava/lang/String;)V", "")]
		public static unsafe void Log (string p0)
		{
			if (id_Log_Ljava_lang_String_ == IntPtr.Zero)
				id_Log_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Log", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Log_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_LogError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']/method[@name='LogError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("LogError", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogError (string p0)
		{
			if (id_LogError_Ljava_lang_String_ == IntPtr.Zero)
				id_LogError_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "LogError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_LogError_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_LogRequirementsError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.util']/class[@name='Logging']/method[@name='LogRequirementsError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("LogRequirementsError", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogRequirementsError (string p0)
		{
			if (id_LogRequirementsError_Ljava_lang_String_ == IntPtr.Zero)
				id_LogRequirementsError_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "LogRequirementsError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_LogRequirementsError_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
