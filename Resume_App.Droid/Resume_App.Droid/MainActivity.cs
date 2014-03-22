using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Resume_App.Droid
{
    [Activity(Label = "Resume_App.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            ActionBar.Title = "My Resume";

            var employment = FindViewById<Button>(Resource.Id.MainEducation);
            employment.Click += delegate
            {
                StartActivity(typeof(EmploymentActivity));
            };
        }
    }
}
