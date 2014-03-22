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
using Android.Graphics.Drawables;

namespace Resume_App.Droid.DataModel
{
    public class Employer
    {
        public Drawable Icon { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string DateWorked { get; set; }
    }
}