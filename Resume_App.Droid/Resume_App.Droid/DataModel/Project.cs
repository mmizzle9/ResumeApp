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

namespace Resume_App.Droid.DataModel
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DetailDescription { get; set; }
        public int Icon { get; set; }
    }
}