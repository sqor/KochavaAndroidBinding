using System;
using System.Collections.Generic;
using Android.Runtime;

namespace KochavaBinding.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']"
	[global::Android.Runtime.Register ("com/kochava/android/tracker/DbAdapter", DoNotGenerateAcw=true)]
	public partial class DbAdapter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/field[@name='KEY_CREATED_AT']"
		[Register ("KEY_CREATED_AT")]
		public const string KeyCreatedAt = (string) "created_at";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/field[@name='KEY_DATA']"
		[Register ("KEY_DATA")]
		public const string KeyData = (string) "data";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter.DatabaseHelper']"
		[global::Android.Runtime.Register ("com/kochava/android/tracker/DbAdapter$DatabaseHelper", DoNotGenerateAcw=true)]
		public partial class DatabaseHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kochava/android/tracker/DbAdapter$DatabaseHelper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseHelper); }
			}

			protected DatabaseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == null)
					cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_);
				return cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KochavaBinding.Tracker.DbAdapter.DatabaseHelper __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter.DatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter.DatabaseHelper']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler")]
			public override unsafe void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
			{
				if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
#pragma warning disable 0169
			static Delegate GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler ()
			{
				if (cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == null)
					cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II);
				return cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			}

			static void n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::KochavaBinding.Tracker.DbAdapter.DatabaseHelper __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter.DatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpgrade (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter.DatabaseHelper']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
			public override unsafe void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
			{
				if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
					id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kochava/android/tracker/DbAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DbAdapter); }
		}

		protected DbAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/constructor[@name='DbAdapter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DbAdapter (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DbAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_addEvent_Lorg_json_JSONObject_Z;
#pragma warning disable 0169
		static Delegate GetAddEvent_Lorg_json_JSONObject_ZHandler ()
		{
			if (cb_addEvent_Lorg_json_JSONObject_Z == null)
				cb_addEvent_Lorg_json_JSONObject_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int>) n_AddEvent_Lorg_json_JSONObject_Z);
			return cb_addEvent_Lorg_json_JSONObject_Z;
		}

		static int n_AddEvent_Lorg_json_JSONObject_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::KochavaBinding.Tracker.DbAdapter __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddEvent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addEvent_Lorg_json_JSONObject_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/method[@name='addEvent' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='boolean']]"
		[Register ("addEvent", "(Lorg/json/JSONObject;Z)I", "GetAddEvent_Lorg_json_JSONObject_ZHandler")]
		public virtual unsafe int AddEvent (global::Org.Json.JSONObject p0, bool p1)
		{
			if (id_addEvent_Lorg_json_JSONObject_Z == IntPtr.Zero)
				id_addEvent_Lorg_json_JSONObject_Z = JNIEnv.GetMethodID (class_ref, "addEvent", "(Lorg/json/JSONObject;Z)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_addEvent_Lorg_json_JSONObject_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEvent", "(Lorg/json/JSONObject;Z)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cleanupEvents_J;
#pragma warning disable 0169
		static Delegate GetCleanupEvents_JHandler ()
		{
			if (cb_cleanupEvents_J == null)
				cb_cleanupEvents_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_CleanupEvents_J);
			return cb_cleanupEvents_J;
		}

		static void n_CleanupEvents_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::KochavaBinding.Tracker.DbAdapter __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanupEvents (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cleanupEvents_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/method[@name='cleanupEvents' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("cleanupEvents", "(J)V", "GetCleanupEvents_JHandler")]
		public virtual unsafe void CleanupEvents (long p0)
		{
			if (id_cleanupEvents_J == IntPtr.Zero)
				id_cleanupEvents_J = JNIEnv.GetMethodID (class_ref, "cleanupEvents", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cleanupEvents_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanupEvents", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_generateDataString;
#pragma warning disable 0169
		static Delegate GetGenerateDataStringHandler ()
		{
			if (cb_generateDataString == null)
				cb_generateDataString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GenerateDataString);
			return cb_generateDataString;
		}

		static IntPtr n_GenerateDataString (IntPtr jnienv, IntPtr native__this)
		{
			global::KochavaBinding.Tracker.DbAdapter __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateDataString ());
		}
#pragma warning restore 0169

		static IntPtr id_generateDataString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/method[@name='generateDataString' and count(parameter)=0]"
		[Register ("generateDataString", "()Ljava/lang/String;", "GetGenerateDataStringHandler")]
		public virtual unsafe string GenerateDataString ()
		{
			if (id_generateDataString == IntPtr.Zero)
				id_generateDataString = JNIEnv.GetMethodID (class_ref, "generateDataString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generateDataString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateDataString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getApplicationData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetApplicationData_Ljava_lang_String_Handler ()
		{
			if (cb_getApplicationData_Ljava_lang_String_ == null)
				cb_getApplicationData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetApplicationData_Ljava_lang_String_);
			return cb_getApplicationData_Ljava_lang_String_;
		}

		static IntPtr n_GetApplicationData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KochavaBinding.Tracker.DbAdapter __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetApplicationData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/method[@name='getApplicationData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getApplicationData", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetApplicationData_Ljava_lang_String_Handler")]
		public virtual unsafe string GetApplicationData (string p0)
		{
			if (id_getApplicationData_Ljava_lang_String_ == IntPtr.Zero)
				id_getApplicationData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getApplicationData", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApplicationData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationData", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_insertApplicationData_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInsertApplicationData_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_insertApplicationData_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_insertApplicationData_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InsertApplicationData_Ljava_lang_String_Ljava_lang_String_);
			return cb_insertApplicationData_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_InsertApplicationData_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KochavaBinding.Tracker.DbAdapter __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InsertApplicationData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_insertApplicationData_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/method[@name='insertApplicationData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("insertApplicationData", "(Ljava/lang/String;Ljava/lang/String;)V", "GetInsertApplicationData_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void InsertApplicationData (string p0, string p1)
		{
			if (id_insertApplicationData_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_insertApplicationData_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "insertApplicationData", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insertApplicationData_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertApplicationData", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateApplicationData_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateApplicationData_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateApplicationData_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateApplicationData_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateApplicationData_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateApplicationData_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateApplicationData_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KochavaBinding.Tracker.DbAdapter __this = global::Java.Lang.Object.GetObject<global::KochavaBinding.Tracker.DbAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateApplicationData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateApplicationData_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kochava.android.tracker']/class[@name='DbAdapter']/method[@name='updateApplicationData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateApplicationData", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateApplicationData_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateApplicationData (string p0, string p1)
		{
			if (id_updateApplicationData_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateApplicationData_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateApplicationData", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateApplicationData_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateApplicationData", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
