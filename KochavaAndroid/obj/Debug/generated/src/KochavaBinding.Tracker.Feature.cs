using System;
using System.Collections.Generic;
using Android.Runtime;

namespace KochavaBinding.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']"
	[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature", DoNotGenerateAcw=true)]
	public partial class Feature : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='ADLOGTAG']"
		[Register ("ADLOGTAG")]
		protected const string Adlogtag = (string) "KochavaAds";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='ATTRIBUTION_PREF_DATA']"
		[Register ("ATTRIBUTION_PREF_DATA")]
		protected const string AttributionPrefData = (string) "attributionData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='ATTRIBUTION_PREF_NAME']"
		[Register ("ATTRIBUTION_PREF_NAME")]
		protected const string AttributionPrefName = (string) "attributionPref";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='LINKIDENTITYBOOL']"
		[Register ("LINKIDENTITYBOOL")]
		public const string Linkidentitybool = (string) "linkIdentityBool";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		protected const string Logtag = (string) "KochavaTracker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_APPDATA']"
		[Register ("PREF_APPDATA")]
		protected const string PrefAppdata = (string) "kochavaappdata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_CUR']"
		[Register ("PREF_CUR")]
		protected const string PrefCur = (string) "currency";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_INIT']"
		[Register ("PREF_INIT")]
		protected const string PrefInit = (string) "initBool";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_INIT_DATA']"
		[Register ("PREF_INIT_DATA")]
		protected const string PrefInitData = (string) "initData";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_LAT']"
		[Register ("PREF_LAT")]
		protected const string PrefLat = (string) "mylat";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_LONG']"
		[Register ("PREF_LONG")]
		protected const string PrefLong = (string) "mylong";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_NAME']"
		[Register ("PREF_NAME")]
		protected const string PrefName = (string) "initPrefs";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='PREF_TIMESTOPPED']"
		[Register ("PREF_TIMESTOPPED")]
		protected const string PrefTimestopped = (string) "timeStampStopped";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='REQLOGTAG']"
		[Register ("REQLOGTAG")]
		protected const string Reqlogtag = (string) "KochavaRequirements";

		static IntPtr appContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='appContext']"
		[Register ("appContext")]
		protected static global::Android.Content.Context AppContext {
			get {
				if (appContext_jfieldId == IntPtr.Zero)
					appContext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "appContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, appContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appContext_jfieldId == IntPtr.Zero)
					appContext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "appContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, appContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr kvinitdata_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='kvinitdata']"
		[Register ("kvinitdata")]
		protected global::Org.Json.JSONObject Kvinitdata {
			get {
				if (kvinitdata_jfieldId == IntPtr.Zero)
					kvinitdata_jfieldId = JNIEnv.GetFieldID (class_ref, "kvinitdata", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, kvinitdata_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (kvinitdata_jfieldId == IntPtr.Zero)
					kvinitdata_jfieldId = JNIEnv.GetFieldID (class_ref, "kvinitdata", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, kvinitdata_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr kvinitdataholder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='kvinitdataholder']"
		[Register ("kvinitdataholder")]
		protected global::Org.Json.JSONObject Kvinitdataholder {
			get {
				if (kvinitdataholder_jfieldId == IntPtr.Zero)
					kvinitdataholder_jfieldId = JNIEnv.GetFieldID (class_ref, "kvinitdataholder", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, kvinitdataholder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (kvinitdataholder_jfieldId == IntPtr.Zero)
					kvinitdataholder_jfieldId = JNIEnv.GetFieldID (class_ref, "kvinitdataholder", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, kvinitdataholder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr kvinitorigdata_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='kvinitorigdata']"
		[Register ("kvinitorigdata")]
		protected global::Org.Json.JSONObject Kvinitorigdata {
			get {
				if (kvinitorigdata_jfieldId == IntPtr.Zero)
					kvinitorigdata_jfieldId = JNIEnv.GetFieldID (class_ref, "kvinitorigdata", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, kvinitorigdata_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (kvinitorigdata_jfieldId == IntPtr.Zero)
					kvinitorigdata_jfieldId = JNIEnv.GetFieldID (class_ref, "kvinitorigdata", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, kvinitorigdata_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr overrideAutomaticSessions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='overrideAutomaticSessions']"
		[Register ("overrideAutomaticSessions")]
		protected static bool OverrideAutomaticSessions {
			get {
				if (overrideAutomaticSessions_jfieldId == IntPtr.Zero)
					overrideAutomaticSessions_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "overrideAutomaticSessions", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, overrideAutomaticSessions_jfieldId);
			}
			set {
				if (overrideAutomaticSessions_jfieldId == IntPtr.Zero)
					overrideAutomaticSessions_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "overrideAutomaticSessions", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, overrideAutomaticSessions_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr versionExtension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='versionExtension']"
		[Register ("versionExtension")]
		protected static string VersionExtension {
			get {
				if (versionExtension_jfieldId == IntPtr.Zero)
					versionExtension_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "versionExtension", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, versionExtension_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (versionExtension_jfieldId == IntPtr.Zero)
					versionExtension_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "versionExtension", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, versionExtension_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr webStates_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='webStates']"
		[Register ("webStates")]
		public static global::Java.Util.Hashtable WebStates {
			get {
				if (webStates_jfieldId == IntPtr.Zero)
					webStates_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "webStates", "Ljava/util/Hashtable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, webStates_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (webStates_jfieldId == IntPtr.Zero)
					webStates_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "webStates", "Ljava/util/Hashtable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, webStates_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr webViews_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/field[@name='webViews']"
		[Register ("webViews")]
		public static global::Java.Util.Hashtable WebViews {
			get {
				if (webViews_jfieldId == IntPtr.Zero)
					webViews_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "webViews", "Ljava/util/Hashtable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, webViews_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (webViews_jfieldId == IntPtr.Zero)
					webViews_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "webViews", "Ljava/util/Hashtable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, webViews_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$AppLifeCycleStatusManager", DoNotGenerateAcw=true)]
		protected internal partial class AppLifeCycleStatusManager : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']/field[@name='IS_FOCUSED']"
			[Register ("IS_FOCUSED")]
			protected const string IsFocused = (string) "is_focused";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']/field[@name='IS_IN_BACKGROUND']"
			[Register ("IS_IN_BACKGROUND")]
			protected const string IsInBackground = (string) "is_in_background";

			static IntPtr active_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']/field[@name='active']"
			[Register ("active")]
			protected static bool Active {
				get {
					if (active_jfieldId == IntPtr.Zero)
						active_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "active", "Z");
					return JNIEnv.GetStaticBooleanField (class_ref, active_jfieldId);
				}
				set {
					if (active_jfieldId == IntPtr.Zero)
						active_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "active", "Z");
					try {
						JNIEnv.SetStaticField (class_ref, active_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr resumed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']/field[@name='resumed']"
			[Register ("resumed")]
			protected static bool Resumed {
				get {
					if (resumed_jfieldId == IntPtr.Zero)
						resumed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "resumed", "Z");
					return JNIEnv.GetStaticBooleanField (class_ref, resumed_jfieldId);
				}
				set {
					if (resumed_jfieldId == IntPtr.Zero)
						resumed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "resumed", "Z");
					try {
						JNIEnv.SetStaticField (class_ref, resumed_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$AppLifeCycleStatusManager", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AppLifeCycleStatusManager); }
			}

			protected AppLifeCycleStatusManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']/constructor[@name='Feature.AppLifeCycleStatusManager' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe AppLifeCycleStatusManager ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AppLifeCycleStatusManager)) {
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

			static IntPtr id_changeStatus_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.AppLifeCycleStatusManager']/method[@name='changeStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("changeStatus", "(Ljava/lang/String;)V", "")]
			protected static unsafe void ChangeStatus (string p0)
			{
				if (id_changeStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_changeStatus_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "changeStatus", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_changeStatus_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$CURRENCIES", DoNotGenerateAcw=true)]
		public sealed partial class CURRENCIES : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='AED']"
			[Register ("AED")]
			public const string Aed = (string) "AED";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='AUD']"
			[Register ("AUD")]
			public const string Aud = (string) "AUD";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='CAD']"
			[Register ("CAD")]
			public const string Cad = (string) "CAD";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='CHF']"
			[Register ("CHF")]
			public const string Chf = (string) "CHF";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='CNY']"
			[Register ("CNY")]
			public const string Cny = (string) "CNY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='DKK']"
			[Register ("DKK")]
			public const string Dkk = (string) "DKK";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='EUR']"
			[Register ("EUR")]
			public const string Eur = (string) "EUR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='GBP']"
			[Register ("GBP")]
			public const string Gbp = (string) "GBP";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='IDR']"
			[Register ("IDR")]
			public const string Idr = (string) "IDR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='ILS']"
			[Register ("ILS")]
			public const string Ils = (string) "ILS";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='INR']"
			[Register ("INR")]
			public const string Inr = (string) "INR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='MXP']"
			[Register ("MXP")]
			public const string Mxp = (string) "MXP";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='NOK']"
			[Register ("NOK")]
			public const string Nok = (string) "NOK";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='NZD']"
			[Register ("NZD")]
			public const string Nzd = (string) "NZD";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='RUB']"
			[Register ("RUB")]
			public const string Rub = (string) "RUB";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='SAR']"
			[Register ("SAR")]
			public const string Sar = (string) "SAR";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='SEK']"
			[Register ("SEK")]
			public const string Sek = (string) "SEK";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='TRY']"
			[Register ("TRY")]
			public const string Try = (string) "TRY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='USD']"
			[Register ("USD")]
			public const string Usd = (string) "USD";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='YEN']"
			[Register ("YEN")]
			public const string Yen = (string) "YEN";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.CURRENCIES']/field[@name='ZAR']"
			[Register ("ZAR")]
			public const string Zar = (string) "ZAR";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$CURRENCIES", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CURRENCIES); }
			}

			internal CURRENCIES (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$INPUTITEMS", DoNotGenerateAcw=true)]
		public sealed partial class INPUTITEMS : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='APP_LIMIT_TRACKING']"
			[Register ("APP_LIMIT_TRACKING")]
			public const string AppLimitTracking = (string) "app_limit_tracking";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='BIDDER_HOST']"
			[Register ("BIDDER_HOST")]
			public const string BidderHost = (string) "bidder_host";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='CONTROL_HOST']"
			[Register ("CONTROL_HOST")]
			public const string ControlHost = (string) "control_host";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='CURRENCY']"
			[Register ("CURRENCY")]
			public const string Currency = (string) "currency";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='DEBUG_ON']"
			[Register ("DEBUG_ON")]
			public const string DebugOn = (string) "debug";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='FLUSH_IN_BACKGROUND']"
			[Register ("FLUSH_IN_BACKGROUND")]
			public const string FlushInBackground = (string) "flush_in_background";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='IDENTITY_LINK']"
			[Register ("IDENTITY_LINK")]
			public const string IdentityLink = (string) "identity_link";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='KOCHAVA_APP_ID']"
			[Register ("KOCHAVA_APP_ID")]
			public const string KochavaAppId = (string) "kochava_app_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='PARTNER_NAME']"
			[Register ("PARTNER_NAME")]
			public const string PartnerName = (string) "partner_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.INPUTITEMS']/field[@name='REQUEST_ATTRIBUTION']"
			[Register ("REQUEST_ATTRIBUTION")]
			public const string RequestAttribution = (string) "request_attribution";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$INPUTITEMS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INPUTITEMS); }
			}

			internal INPUTITEMS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$LifeCycleTracker", DoNotGenerateAcw=true)]
		protected internal partial class LifeCycleTracker : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$LifeCycleTracker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LifeCycleTracker); }
			}

			protected LifeCycleTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kochava_android_tracker_Feature_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/constructor[@name='Feature.LifeCycleTracker' and count(parameter)=1 and parameter[1][@type='com.kochava.android.tracker.Feature']]"
			[Register (".ctor", "(Lcom/kochava/android/tracker/Feature;)V", "")]
			protected unsafe LifeCycleTracker (global::KochavaBinding.Tracker.Feature __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (LifeCycleTracker)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_kochava_android_tracker_Feature_ == IntPtr.Zero)
						id_ctor_Lcom_kochava_android_tracker_Feature_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kochava/android/tracker/Feature;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kochava_android_tracker_Feature_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_kochava_android_tracker_Feature_, __args);
				} finally {
				}
			}

			static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
			{
				if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
					cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
				return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityCreated (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
			public virtual unsafe void OnActivityCreated (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
			{
				if (id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
					cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
				return cb_onActivityDestroyed_Landroid_app_Activity_;
			}

			static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityDestroyed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityDestroyed_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
			public virtual unsafe void OnActivityDestroyed (global::Android.App.Activity p0)
			{
				if (id_onActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityDestroyed", "(Landroid/app/Activity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivityDestroyed_Landroid_app_Activity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityDestroyed", "(Landroid/app/Activity;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityPaused_Landroid_app_Activity_ == null)
					cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
				return cb_onActivityPaused_Landroid_app_Activity_;
			}

			static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityPaused (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityPaused_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
			public virtual unsafe void OnActivityPaused (global::Android.App.Activity p0)
			{
				if (id_onActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityPaused", "(Landroid/app/Activity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivityPaused_Landroid_app_Activity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityPaused", "(Landroid/app/Activity;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityResumed_Landroid_app_Activity_ == null)
					cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
				return cb_onActivityResumed_Landroid_app_Activity_;
			}

			static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityResumed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityResumed_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
			public virtual unsafe void OnActivityResumed (global::Android.App.Activity p0)
			{
				if (id_onActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityResumed_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityResumed", "(Landroid/app/Activity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivityResumed_Landroid_app_Activity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResumed", "(Landroid/app/Activity;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
			{
				if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
					cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
				return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			}

			static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnActivitySaveInstanceState (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
			public virtual unsafe void OnActivitySaveInstanceState (global::Android.App.Activity p0, global::Android.OS.Bundle p1)
			{
				if (id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityStarted_Landroid_app_Activity_ == null)
					cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
				return cb_onActivityStarted_Landroid_app_Activity_;
			}

			static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityStarted (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityStarted_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
			public virtual unsafe void OnActivityStarted (global::Android.App.Activity p0)
			{
				if (id_onActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityStarted_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStarted", "(Landroid/app/Activity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivityStarted_Landroid_app_Activity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStarted", "(Landroid/app/Activity;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
			static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
			{
				if (cb_onActivityStopped_Landroid_app_Activity_ == null)
					cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
				return cb_onActivityStopped_Landroid_app_Activity_;
			}

			static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.Feature.LifeCycleTracker __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.LifeCycleTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityStopped (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onActivityStopped_Landroid_app_Activity_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.LifeCycleTracker']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
			public virtual unsafe void OnActivityStopped (global::Android.App.Activity p0)
			{
				if (id_onActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
					id_onActivityStopped_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onActivityStopped", "(Landroid/app/Activity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onActivityStopped_Landroid_app_Activity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityStopped", "(Landroid/app/Activity;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.MemoryBoss']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$MemoryBoss", DoNotGenerateAcw=true)]
		protected internal partial class MemoryBoss : global::Java.Lang.Object, global::Android.Content.IComponentCallbacks2 {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$MemoryBoss", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MemoryBoss); }
			}

			protected MemoryBoss (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kochava_android_tracker_Feature_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.MemoryBoss']/constructor[@name='Feature.MemoryBoss' and count(parameter)=1 and parameter[1][@type='com.kochava.android.tracker.Feature']]"
			[Register (".ctor", "(Lcom/kochava/android/tracker/Feature;)V", "")]
			protected unsafe MemoryBoss (global::KochavaBinding.Tracker.Feature __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (MemoryBoss)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_kochava_android_tracker_Feature_ == IntPtr.Zero)
						id_ctor_Lcom_kochava_android_tracker_Feature_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kochava/android/tracker/Feature;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kochava_android_tracker_Feature_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_kochava_android_tracker_Feature_, __args);
				} finally {
				}
			}

			static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
			static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
			{
				if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
					cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
				return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
			}

			static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.Feature.MemoryBoss __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.MemoryBoss> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConfigurationChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.MemoryBoss']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
			[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
			public virtual unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
			{
				if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
					id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onLowMemory;
#pragma warning disable 0169
			static Delegate GetOnLowMemoryHandler ()
			{
				if (cb_onLowMemory == null)
					cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
				return cb_onLowMemory;
			}

			static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
			{
				global::KochavaBinding.Tracker.Feature.MemoryBoss __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.MemoryBoss> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLowMemory ();
			}
#pragma warning restore 0169

			static IntPtr id_onLowMemory;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.MemoryBoss']/method[@name='onLowMemory' and count(parameter)=0]"
			[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler")]
			public virtual unsafe void OnLowMemory ()
			{
				if (id_onLowMemory == IntPtr.Zero)
					id_onLowMemory = JNIEnv.GetMethodID (class_ref, "onLowMemory", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onLowMemory);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLowMemory", "()V"));
				} finally {
				}
			}

			static Delegate cb_onTrimMemory_I;
#pragma warning disable 0169
			static Delegate GetOnTrimMemory_IHandler ()
			{
				if (cb_onTrimMemory_I == null)
					cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTrimMemory_I);
				return cb_onTrimMemory_I;
			}

			static void n_OnTrimMemory_I (IntPtr jnienv, IntPtr native__this, int native_p0)
			{
				global::KochavaBinding.Tracker.Feature.MemoryBoss __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.MemoryBoss> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.TrimMemory p0 = (global::Android.Content.TrimMemory) native_p0;
				__this.OnTrimMemory (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onTrimMemory_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.MemoryBoss']/method[@name='onTrimMemory' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTrimMemory", "(I)V", "GetOnTrimMemory_IHandler")]
			public virtual unsafe void OnTrimMemory ([global::Android.Runtime.GeneratedEnum] global::Android.Content.TrimMemory p0)
			{
				if (id_onTrimMemory_I == IntPtr.Zero)
					id_onTrimMemory_I = JNIEnv.GetMethodID (class_ref, "onTrimMemory", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue ((int) p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onTrimMemory_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTrimMemory", "(I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$PARAMS", DoNotGenerateAcw=true)]
		public sealed partial class PARAMS : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='ADID']"
			[Register ("ADID")]
			public const string Adid = (string) "adid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='ANDROID_ID']"
			[Register ("ANDROID_ID")]
			public const string AndroidId = (string) "android_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='FB_ATTRIBUTION_ID']"
			[Register ("FB_ATTRIBUTION_ID")]
			public const string FbAttributionId = (string) "fb_attribution_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='IMEI']"
			[Register ("IMEI")]
			public const string Imei = (string) "imei";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='MAC']"
			[Register ("MAC")]
			public const string Mac = (string) "mac";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='ODIN']"
			[Register ("ODIN")]
			public const string Odin = (string) "odin";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PARAMS']/field[@name='OPEN_UDID']"
			[Register ("OPEN_UDID")]
			public const string OpenUdid = (string) "open_udid";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$PARAMS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PARAMS); }
			}

			internal PARAMS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PRIVATEINPUTITEMS']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$PRIVATEINPUTITEMS", DoNotGenerateAcw=true)]
		public sealed partial class PRIVATEINPUTITEMS : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PRIVATEINPUTITEMS']/field[@name='CLICK_DATA']"
			[Register ("CLICK_DATA")]
			public const string ClickData = (string) "clickData";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PRIVATEINPUTITEMS']/field[@name='FLUSH_RATE']"
			[Register ("FLUSH_RATE")]
			public const string FlushRate = (string) "flush_rate";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PRIVATEINPUTITEMS']/field[@name='OVERRIDE_AUTOMATIC_SESSIONS']"
			[Register ("OVERRIDE_AUTOMATIC_SESSIONS")]
			public const string OverrideAutomaticSessions = (string) "override_automatic_sessions";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PRIVATEINPUTITEMS']/field[@name='SUPPRESS_ADID_GATHER']"
			[Register ("SUPPRESS_ADID_GATHER")]
			public const string SuppressAdidGather = (string) "suppress_adid_gather";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.PRIVATEINPUTITEMS']/field[@name='VERSION_EXTENSION']"
			[Register ("VERSION_EXTENSION")]
			public const string VersionExtension = (string) "version_extension";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$PRIVATEINPUTITEMS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PRIVATEINPUTITEMS); }
			}

			internal PRIVATEINPUTITEMS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.TrackTask']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$TrackTask", DoNotGenerateAcw=true)]
		public partial class TrackTask : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$TrackTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TrackTask); }
			}

			protected TrackTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::KochavaBinding.Tracker.Feature.TrackTask __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature.TrackTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.TrackTask']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$WATCHLIST", DoNotGenerateAcw=true)]
		public sealed partial class WATCHLIST : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']/field[@name='ADID']"
			[Register ("ADID")]
			public const string Adid = (string) "adid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']/field[@name='APP_LIMIT_TRACKING']"
			[Register ("APP_LIMIT_TRACKING")]
			public const string AppLimitTracking = (string) "app_limit_tracking";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']/field[@name='APP_SHORT_STRING']"
			[Register ("APP_SHORT_STRING")]
			public const string AppShortString = (string) "app_short_string";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']/field[@name='APP_VERSION']"
			[Register ("APP_VERSION")]
			public const string AppVersion = (string) "app_version";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']/field[@name='DEVICE_LIMIT_TRACKING']"
			[Register ("DEVICE_LIMIT_TRACKING")]
			public const string DeviceLimitTracking = (string) "device_limit_tracking";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WATCHLIST']/field[@name='OS_VERSION']"
			[Register ("OS_VERSION")]
			public const string OsVersion = (string) "os_version";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$WATCHLIST", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WATCHLIST); }
			}

			internal WATCHLIST (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WHITELISTITEMS']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/Feature$WHITELISTITEMS", DoNotGenerateAcw=true)]
		public sealed partial class WHITELISTITEMS : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature.WHITELISTITEMS']/field[@name='EMAIL']"
			[Register ("EMAIL")]
			public const string Email = (string) "email";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/Feature$WHITELISTITEMS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WHITELISTITEMS); }
			}

			internal WHITELISTITEMS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kochava/android/tracker/Feature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Feature); }
		}

		protected Feature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/constructor[@name='Feature' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/HashMap;)V", "")]
		public unsafe Feature (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (Feature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ZLjava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/constructor[@name='Feature' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;ZLjava/util/HashMap;)V", "")]
		public unsafe Feature (global::Android.Content.Context p0, bool p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Feature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ZLjava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ZLjava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ZLjava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ZLjava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ZLjava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ZLjava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ZLjava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/constructor[@name='Feature' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe Feature (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (Feature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/constructor[@name='Feature' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;)V", "")]
		public unsafe Feature (global::Android.Content.Context p0, string p1, bool p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (Feature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;ZLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/constructor[@name='Feature' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public unsafe Feature (global::Android.Content.Context p0, string p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Feature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/constructor[@name='Feature' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Feature (global::Android.Content.Context p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Feature)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getAttributionData;
		public static unsafe string AttributionData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='getAttributionData' and count(parameter)=0]"
			[Register ("getAttributionData", "()Ljava/lang/String;", "GetGetAttributionDataHandler")]
			get {
				if (id_getAttributionData == IntPtr.Zero)
					id_getAttributionData = JNIEnv.GetStaticMethodID (class_ref, "getAttributionData", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAttributionData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getKochavaDeviceId;
		public static unsafe string KochavaDeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='getKochavaDeviceId' and count(parameter)=0]"
			[Register ("getKochavaDeviceId", "()Ljava/lang/String;", "GetGetKochavaDeviceIdHandler")]
			get {
				if (id_getKochavaDeviceId == IntPtr.Zero)
					id_getKochavaDeviceId = JNIEnv.GetStaticMethodID (class_ref, "getKochavaDeviceId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getKochavaDeviceId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearSuperProperties;
#pragma warning disable 0169
		static Delegate GetClearSuperPropertiesHandler ()
		{
			if (cb_clearSuperProperties == null)
				cb_clearSuperProperties = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearSuperProperties);
			return cb_clearSuperProperties;
		}

		static void n_ClearSuperProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearSuperProperties ();
		}
#pragma warning restore 0169

		static IntPtr id_clearSuperProperties;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='clearSuperProperties' and count(parameter)=0]"
		[Register ("clearSuperProperties", "()V", "GetClearSuperPropertiesHandler")]
		public virtual unsafe void ClearSuperProperties ()
		{
			if (id_clearSuperProperties == IntPtr.Zero)
				id_clearSuperProperties = JNIEnv.GetMethodID (class_ref, "clearSuperProperties", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearSuperProperties);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearSuperProperties", "()V"));
			} finally {
			}
		}

		static Delegate cb_deepLinkEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeepLinkEvent_Ljava_lang_String_Handler ()
		{
			if (cb_deepLinkEvent_Ljava_lang_String_ == null)
				cb_deepLinkEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeepLinkEvent_Ljava_lang_String_);
			return cb_deepLinkEvent_Ljava_lang_String_;
		}

		static void n_DeepLinkEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeepLinkEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deepLinkEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='deepLinkEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deepLinkEvent", "(Ljava/lang/String;)V", "GetDeepLinkEvent_Ljava_lang_String_Handler")]
		public virtual unsafe void DeepLinkEvent (string p0)
		{
			if (id_deepLinkEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_deepLinkEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deepLinkEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deepLinkEvent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deepLinkEvent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_enableDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='enableDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableDebug", "(Z)V", "")]
		public static unsafe void EnableDebug (bool p0)
		{
			if (id_enableDebug_Z == IntPtr.Zero)
				id_enableDebug_Z = JNIEnv.GetStaticMethodID (class_ref, "enableDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableDebug_Z, __args);
			} finally {
			}
		}

		static Delegate cb_endSession;
#pragma warning disable 0169
		static Delegate GetEndSessionHandler ()
		{
			if (cb_endSession == null)
				cb_endSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndSession);
			return cb_endSession;
		}

		static void n_EndSession (IntPtr jnienv, IntPtr native__this)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndSession ();
		}
#pragma warning restore 0169

		static IntPtr id_endSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='endSession' and count(parameter)=0]"
		[Register ("endSession", "()V", "GetEndSessionHandler")]
		public virtual unsafe void EndSession ()
		{
			if (id_endSession == IntPtr.Zero)
				id_endSession = JNIEnv.GetMethodID (class_ref, "endSession", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_endSession);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endSession", "()V"));
			} finally {
			}
		}

		static Delegate cb_event_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_event_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_event_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Event_Ljava_lang_String_Ljava_lang_String_);
			return cb_event_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Event_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Event (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_event_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='event' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("event", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Event (string p0, string p1)
		{
			if (id_event_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_event_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "event", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_event_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "event", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEventSpatial_Ljava_lang_String_DDDLjava_lang_String_Handler ()
		{
			if (cb_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_ == null)
				cb_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double, double, double, IntPtr>) n_EventSpatial_Ljava_lang_String_DDDLjava_lang_String_);
			return cb_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_;
		}

		static void n_EventSpatial_Ljava_lang_String_DDDLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, double p2, double p3, IntPtr native_p4)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.EventSpatial (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='eventSpatial' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='java.lang.String']]"
		[Register ("eventSpatial", "(Ljava/lang/String;DDDLjava/lang/String;)V", "GetEventSpatial_Ljava_lang_String_DDDLjava_lang_String_Handler")]
		public virtual unsafe void EventSpatial (string p0, double p1, double p2, double p3, string p4)
		{
			if (id_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_ == IntPtr.Zero)
				id_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "eventSpatial", "(Ljava/lang/String;DDDLjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_eventSpatial_Ljava_lang_String_DDDLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "eventSpatial", "(Ljava/lang/String;DDDLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public static unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetStaticMethodID (class_ref, "flush", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_flush);
			} finally {
			}
		}

		static IntPtr id_getAttributionId_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='getAttributionId' and count(parameter)=1 and parameter[1][@type='android.content.ContentResolver']]"
		[Register ("getAttributionId", "(Landroid/content/ContentResolver;)Ljava/lang/String;", "")]
		protected static unsafe string GetAttributionId (global::Android.Content.ContentResolver p0)
		{
			if (id_getAttributionId_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_getAttributionId_Landroid_content_ContentResolver_ = JNIEnv.GetStaticMethodID (class_ref, "getAttributionId", "(Landroid/content/ContentResolver;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAttributionId_Landroid_content_ContentResolver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_linkIdentity_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLinkIdentity_Ljava_util_Map_Handler ()
		{
			if (cb_linkIdentity_Ljava_util_Map_ == null)
				cb_linkIdentity_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LinkIdentity_Ljava_util_Map_);
			return cb_linkIdentity_Ljava_util_Map_;
		}

		static void n_LinkIdentity_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LinkIdentity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_linkIdentity_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='linkIdentity' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("linkIdentity", "(Ljava/util/Map;)V", "GetLinkIdentity_Ljava_util_Map_Handler")]
		public virtual unsafe void LinkIdentity (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_linkIdentity_Ljava_util_Map_ == IntPtr.Zero)
				id_linkIdentity_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "linkIdentity", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_linkIdentity_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "linkIdentity", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerSuperProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRegisterSuperProperties_Ljava_util_Map_Handler ()
		{
			if (cb_registerSuperProperties_Ljava_util_Map_ == null)
				cb_registerSuperProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterSuperProperties_Ljava_util_Map_);
			return cb_registerSuperProperties_Ljava_util_Map_;
		}

		static void n_RegisterSuperProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterSuperProperties (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerSuperProperties_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='registerSuperProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("registerSuperProperties", "(Ljava/util/Map;)V", "GetRegisterSuperProperties_Ljava_util_Map_Handler")]
		public virtual unsafe void RegisterSuperProperties (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_registerSuperProperties_Ljava_util_Map_ == IntPtr.Zero)
				id_registerSuperProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "registerSuperProperties", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_registerSuperProperties_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSuperProperties", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sendKVQuery_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='sendKVQuery' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendKVQuery", "(I)V", "")]
		protected static unsafe void SendKVQuery (int p0)
		{
			if (id_sendKVQuery_I == IntPtr.Zero)
				id_sendKVQuery_I = JNIEnv.GetStaticMethodID (class_ref, "sendKVQuery", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendKVQuery_I, __args);
			} finally {
			}
		}

		static Delegate cb_setAppLimitTracking_Z;
#pragma warning disable 0169
		static Delegate GetSetAppLimitTracking_ZHandler ()
		{
			if (cb_setAppLimitTracking_Z == null)
				cb_setAppLimitTracking_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAppLimitTracking_Z);
			return cb_setAppLimitTracking_Z;
		}

		static void n_SetAppLimitTracking_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAppLimitTracking (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAppLimitTracking_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='setAppLimitTracking' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAppLimitTracking", "(Z)V", "GetSetAppLimitTracking_ZHandler")]
		public virtual unsafe void SetAppLimitTracking (bool p0)
		{
			if (id_setAppLimitTracking_Z == IntPtr.Zero)
				id_setAppLimitTracking_Z = JNIEnv.GetMethodID (class_ref, "setAppLimitTracking", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppLimitTracking_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppLimitTracking", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setAttributionHandler_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='setAttributionHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setAttributionHandler", "(Landroid/os/Handler;)V", "")]
		public static unsafe void SetAttributionHandler (global::Android.OS.Handler p0)
		{
			if (id_setAttributionHandler_Landroid_os_Handler_ == IntPtr.Zero)
				id_setAttributionHandler_Landroid_os_Handler_ = JNIEnv.GetStaticMethodID (class_ref, "setAttributionHandler", "(Landroid/os/Handler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAttributionHandler_Landroid_os_Handler_, __args);
			} finally {
			}
		}

		static IntPtr id_setErrorDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='setErrorDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setErrorDebug", "(Z)V", "")]
		public static unsafe void SetErrorDebug (bool p0)
		{
			if (id_setErrorDebug_Z == IntPtr.Zero)
				id_setErrorDebug_Z = JNIEnv.GetStaticMethodID (class_ref, "setErrorDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setErrorDebug_Z, __args);
			} finally {
			}
		}

		static Delegate cb_setLatlong_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLatlong_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setLatlong_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setLatlong_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLatlong_Ljava_lang_String_Ljava_lang_String_);
			return cb_setLatlong_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetLatlong_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLatlong (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLatlong_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='setLatlong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setLatlong", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetLatlong_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLatlong (string p0, string p1)
		{
			if (id_setLatlong_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setLatlong_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLatlong", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLatlong_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLatlong", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startSession;
#pragma warning disable 0169
		static Delegate GetStartSessionHandler ()
		{
			if (cb_startSession == null)
				cb_startSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartSession);
			return cb_startSession;
		}

		static void n_StartSession (IntPtr jnienv, IntPtr native__this)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartSession ();
		}
#pragma warning restore 0169

		static IntPtr id_startSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='startSession' and count(parameter)=0]"
		[Register ("startSession", "()V", "GetStartSessionHandler")]
		public virtual unsafe void StartSession ()
		{
			if (id_startSession == IntPtr.Zero)
				id_startSession = JNIEnv.GetMethodID (class_ref, "startSession", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startSession);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startSession", "()V"));
			} finally {
			}
		}

		static Delegate cb_tryUpdate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTryUpdate_Ljava_lang_String_Handler ()
		{
			if (cb_tryUpdate_Ljava_lang_String_ == null)
				cb_tryUpdate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TryUpdate_Ljava_lang_String_);
			return cb_tryUpdate_Ljava_lang_String_;
		}

		static void n_TryUpdate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KochavaBinding.Tracker.Feature __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.Feature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TryUpdate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_tryUpdate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='Feature']/method[@name='tryUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tryUpdate", "(Ljava/lang/String;)V", "GetTryUpdate_Ljava_lang_String_Handler")]
		protected virtual unsafe void TryUpdate (string p0)
		{
			if (id_tryUpdate_Ljava_lang_String_ == IntPtr.Zero)
				id_tryUpdate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "tryUpdate", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_tryUpdate_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryUpdate", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
