using System;
using System.Collections.Generic;
using Android.Runtime;

namespace KochavaBinding.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']"
	[global::Android.Runtime.Register ("com/kochava/android/tracker/Global", DoNotGenerateAcw=true)]
	public partial class Global : global::Java.Lang.Object {


		static IntPtr CURRENCYLIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']/field[@name='CURRENCYLIST']"
		[Register ("CURRENCYLIST")]
		protected static global::System.Collections.IList Currencylist {
			get {
				if (CURRENCYLIST_jfieldId == IntPtr.Zero)
					CURRENCYLIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CURRENCYLIST", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CURRENCYLIST_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr DEBUGERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']/field[@name='DEBUGERROR']"
		[Register ("DEBUGERROR")]
		public static bool Debugerror {
			get {
				if (DEBUGERROR_jfieldId == IntPtr.Zero)
					DEBUGERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUGERROR", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUGERROR_jfieldId);
			}
			set {
				if (DEBUGERROR_jfieldId == IntPtr.Zero)
					DEBUGERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUGERROR", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUGERROR_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']/field[@name='SDK_PROTOCOL']"
		[Register ("SDK_PROTOCOL")]
		protected const string SdkProtocol = (string) "3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "Android20150511";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kochava/android/tracker/Global", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Global); }
		}

		protected Global (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Global']/constructor[@name='Global' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Global ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Global)) {
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

	}
}
