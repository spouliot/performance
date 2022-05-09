﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Views;

namespace DopeTestUno.Droid
{
	[Activity(
			MainLauncher = true,
			ConfigurationChanges = Uno.UI.ActivityHelper.AllConfigChanges,
			WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden
		)]
	public class MainActivity : Windows.UI.Xaml.ApplicationActivity
	{
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			Window.AddFlags(WindowManagerFlags.KeepScreenOn);
			Xamarin.Essentials.Platform.Init(this, bundle);
		}
    }
}

