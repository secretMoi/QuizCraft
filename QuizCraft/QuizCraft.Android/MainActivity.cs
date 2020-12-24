using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

namespace QuizCraft.Android
{
	[Activity(Label = "QuizCraft", Theme = "@style/MainTheme", MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);
			Forms.SetFlags("RadioButton_Experimental");
			Forms.Init(this, savedInstanceState);
			Plugin.InputKit.Platforms.Droid.Config.Init(this, savedInstanceState);
			LoadApplication(new App());
		}
	}
}