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
    public class School
    {
        public string Name { get; set; }
        public string Graduation { get; set; }
        public string Degree { get; set; }
        public int Image { get; set; }
    }
}