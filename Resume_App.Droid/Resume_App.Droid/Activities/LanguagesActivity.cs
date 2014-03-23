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
    [Activity(Label = "Experience & Tools")]
    public class LanguagesActivity : Activity
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

            var list = FindViewById<ListView>(Resource.Id.EmploymentList);

            ActionBar.Title = "Experience";
            list.Adapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, ResumeInfo.Experience);

            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            Android.App.ActionBar.Tab tab;
            tab = ActionBar.NewTab();
            tab.SetText("Experience");
            tab.TabSelected += delegate
            {
                ActionBar.Title = "Experience";
                list.Adapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, ResumeInfo.Experience);
            };
            ActionBar.AddTab(tab, true);

            tab = ActionBar.NewTab();
            tab.SetText("Tools");
            tab.TabSelected += delegate
            {
                ActionBar.Title = "Tools";
                list.Adapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, ResumeInfo.Tools);
            };
            ActionBar.AddTab(tab, false);
        }
    }
}
