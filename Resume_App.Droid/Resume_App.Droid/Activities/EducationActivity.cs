using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Resume_App.Droid.Adapters;

namespace Resume_App.Droid
{
    [Activity(Label = "Education")]
    public class EducationActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Employment);

            var home = FindViewById(Android.Resource.Id.Home);
            home.Click += delegate
            {
                OnBackPressed();
            };

            ActionBar.Title = "Education";
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            var list = FindViewById<ListView>(Resource.Id.EmploymentList);
            list.Adapter = new EducationAdapter(this, ResumeInfo.Schools);
        }
    }
}
