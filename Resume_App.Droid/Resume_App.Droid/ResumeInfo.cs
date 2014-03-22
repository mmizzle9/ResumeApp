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
using Resume_App.Droid.DataModel;
using Android.Graphics.Drawables;

namespace Resume_App.Droid
{
    public static class ResumeInfo
    {
        public static List<Employer> Employers = new List<Employer>
        {
            new Employer
            {
                Name = "Hitcents",
                Title = "App Developer",
                DateWorked = "11/2012-Current",
                Location = "Bowling Green, KY",
                IconPath = "PlaceholderIcon",
            }
        };
    }
}
