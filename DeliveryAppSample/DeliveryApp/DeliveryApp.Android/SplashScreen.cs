
using Android.App;
using Android.Content.PM;
using Android.OS;
using DeliveryApp.Forms;
using MvvmCross.Forms.Platforms.Android.Views;
using System.Threading.Tasks;

namespace DeliveryApp.Droid
{
    [Activity(
        Label = "DeliveryApp",
        MainLauncher = true,
        Icon = "@mipmap/icon",
        Theme = "@style/MainTheme.Splash",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : MvxFormsSplashScreenActivity<Setup, Core.App, App>
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {
        }

        protected override Task RunAppStartAsync(Bundle bundle)
        {
            StartActivity(typeof(RootActivity));
            return Task.CompletedTask;
        }
    }
}