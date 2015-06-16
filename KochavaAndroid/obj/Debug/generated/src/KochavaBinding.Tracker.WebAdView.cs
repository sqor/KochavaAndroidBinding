using System;
using System.Collections.Generic;
using Android.Runtime;

namespace KochavaBinding.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='WebAdView']"
	[global::Android.Runtime.Register ("com/kochava/android/tracker/WebAdView", DoNotGenerateAcw=true)]
	public partial class WebAdView : global::Android.App.Activity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='WebAdView.MyPictureListener']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/WebAdView$MyPictureListener", DoNotGenerateAcw=true)]
		public partial class MyPictureListener : global::Java.Lang.Object, global::Android.Webkit.WebView.IPictureListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/WebAdView$MyPictureListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyPictureListener); }
			}

			protected MyPictureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_;
#pragma warning disable 0169
			static Delegate GetOnNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_Handler ()
			{
				if (cb_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_ == null)
					cb_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_);
				return cb_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_;
			}

			static void n_OnNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::KochavaBinding.Tracker.WebAdView.MyPictureListener __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.WebAdView.MyPictureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Picture p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Picture> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnNewPicture (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='WebAdView.MyPictureListener']/method[@name='onNewPicture' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='android.graphics.Picture']]"
			[Register ("onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V", "GetOnNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_Handler")]
			public virtual unsafe void OnNewPicture (global::Android.Webkit.WebView p0, global::Android.Graphics.Picture p1)
			{
				if (id_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_ == IntPtr.Zero)
					id_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_ = JNIEnv.GetMethodID (class_ref, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onNewPicture_Landroid_webkit_WebView_Landroid_graphics_Picture_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kochava/android/tracker/WebAdView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebAdView); }
		}

		protected WebAdView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='WebAdView']/constructor[@name='WebAdView' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebAdView ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WebAdView)) {
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

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KochavaBinding.Tracker.WebAdView __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.WebAdView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='WebAdView']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
