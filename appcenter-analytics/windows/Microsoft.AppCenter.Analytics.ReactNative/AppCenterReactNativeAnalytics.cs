﻿using Microsoft.AppCenter.Analytics;
using Microsoft.ReactNative.Managed;
using System.Collections.Generic;

namespace Microsoft.AppCenter.Analytics.ReactNative
{
	[ReactModule]
	class AppCenterReactNativeAnalytics
	{
		[ReactMethod("setEnabled")]
		public void SetEnabled(bool enabled, ReactPromise<JSValue> promise)
		{
			Microsoft.AppCenter.Analytics.Analytics.SetEnabledAsync(enabled);
			promise.Resolve(JSValue.Null);
		}

		[ReactMethod("isEnabled")]
		public void IsEnabled(ReactPromise<bool> promise)
		{
			promise.Resolve(Microsoft.AppCenter.Analytics.Analytics.IsEnabledAsync().Result);
		}

		[ReactMethod("trackEvent")]
		public void TrackEvent(string eventName,
						Dictionary<string, string> properties,
						ReactPromise<JSValue> promise)
		{
			Microsoft.AppCenter.Analytics.Analytics.TrackEvent(eventName, properties);
			promise.Resolve(JSValue.Null);
		}
	}
}