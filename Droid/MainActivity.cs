using Android.OS;
using Android.App;
using Android.Content.PM;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace XFdemo.Droid
{
	[Activity (Label = "XFdemo.Droid", Icon = "@drawable/icon", Theme="@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

			base.OnCreate (bundle);

			Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}