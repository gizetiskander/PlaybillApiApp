using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaybillApiApp.Droid
{
    [Activity(Label = "SplashActivity", MainLauncher = true, Theme ="@style/MyTheme.Splash", NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected async override void OnResume()
        {
            base.OnResume();
            await SimulateStartUp();
        }

        async Task SimulateStartUp()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}