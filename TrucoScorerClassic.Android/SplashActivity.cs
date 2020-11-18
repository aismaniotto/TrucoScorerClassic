using Android.App;
using Android.Content;

/*
 * Inspired by https://medium.com/@bertuzzi/o-x-do-xamarin-forms-splash-screen-b4bf27aca0b
 * github: https://github.com/TBertuzzi/SplashScreenExemplo
 */

namespace TrucoScorerClassic.Droid
{
    [Activity(
        Theme = "@style/MyTheme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity
    {
        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        // Prevent the back button from canceling the startup process
        public override void OnBackPressed() { }
    }
}