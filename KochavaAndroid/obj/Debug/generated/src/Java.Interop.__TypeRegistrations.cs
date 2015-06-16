using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/kochava/android/tracker",
						"com/kochava/android/util",
					},
					new Converter<string, Type>[]{
						lookup_com_kochava_android_tracker_package,
						lookup_com_kochava_android_util_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_kochava_android_tracker_mappings;
		static Type lookup_com_kochava_android_tracker_package (string klass)
		{
			if (package_com_kochava_android_tracker_mappings == null) {
				package_com_kochava_android_tracker_mappings = new string[]{
					"com/kochava/android/tracker/BuildConfig:KochavaBinding.Tracker.BuildConfig",
					"com/kochava/android/tracker/DbAdapter:KochavaBinding.Tracker.DbAdapter",
					"com/kochava/android/tracker/DbAdapter$DatabaseHelper:KochavaBinding.Tracker.DbAdapter/DatabaseHelper",
					"com/kochava/android/tracker/Feature:KochavaBinding.Tracker.Feature",
					"com/kochava/android/tracker/Feature$AppLifeCycleStatusManager:KochavaBinding.Tracker.Feature/AppLifeCycleStatusManager",
					"com/kochava/android/tracker/Feature$CURRENCIES:KochavaBinding.Tracker.Feature/CURRENCIES",
					"com/kochava/android/tracker/Feature$INPUTITEMS:KochavaBinding.Tracker.Feature/INPUTITEMS",
					"com/kochava/android/tracker/Feature$LifeCycleTracker:KochavaBinding.Tracker.Feature/LifeCycleTracker",
					"com/kochava/android/tracker/Feature$MemoryBoss:KochavaBinding.Tracker.Feature/MemoryBoss",
					"com/kochava/android/tracker/Feature$PARAMS:KochavaBinding.Tracker.Feature/PARAMS",
					"com/kochava/android/tracker/Feature$PRIVATEINPUTITEMS:KochavaBinding.Tracker.Feature/PRIVATEINPUTITEMS",
					"com/kochava/android/tracker/Feature$TrackTask:KochavaBinding.Tracker.Feature/TrackTask",
					"com/kochava/android/tracker/Feature$WATCHLIST:KochavaBinding.Tracker.Feature/WATCHLIST",
					"com/kochava/android/tracker/Feature$WHITELISTITEMS:KochavaBinding.Tracker.Feature/WHITELISTITEMS",
					"com/kochava/android/tracker/Global:KochavaBinding.Tracker.Global",
					"com/kochava/android/tracker/R:KochavaBinding.Tracker.R",
					"com/kochava/android/tracker/R$anim:KochavaBinding.Tracker.R/Anim",
					"com/kochava/android/tracker/R$attr:KochavaBinding.Tracker.R/Attr",
					"com/kochava/android/tracker/R$drawable:KochavaBinding.Tracker.R/Drawable",
					"com/kochava/android/tracker/R$integer:KochavaBinding.Tracker.R/Integer",
					"com/kochava/android/tracker/R$layout:KochavaBinding.Tracker.R/Layout",
					"com/kochava/android/tracker/R$string:KochavaBinding.Tracker.R/String",
					"com/kochava/android/tracker/ReferralCapture:KochavaBinding.Tracker.ReferralCapture",
					"com/kochava/android/tracker/WebAdView:KochavaBinding.Tracker.WebAdView",
					"com/kochava/android/tracker/WebAdView$MyPictureListener:KochavaBinding.Tracker.WebAdView/MyPictureListener",
				};
			}

			return Lookup (package_com_kochava_android_tracker_mappings, klass);
		}

		static string[] package_com_kochava_android_util_mappings;
		static Type lookup_com_kochava_android_util_package (string klass)
		{
			if (package_com_kochava_android_util_mappings == null) {
				package_com_kochava_android_util_mappings = new string[]{
					"com/kochava/android/util/Base64Coder:KochavaBinding.Util.Base64Coder",
					"com/kochava/android/util/Logging:KochavaBinding.Util.Logging",
					"com/kochava/android/util/StringUtils:KochavaBinding.Util.StringUtils",
				};
			}

			return Lookup (package_com_kochava_android_util_mappings, klass);
		}
	}
}
