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

namespace Resume_App.Droid.Adapters
{
    public class EducationAdapter : ArrayAdapter<School>
    {
        private IList<School> _schools;

        public EducationAdapter(Context context, IList<School> list)
            :base(context, 0, list)
        {
            _schools = list;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = LayoutInflater.FromContext(Context).Inflate(Resource.Layout.EducationItem, null);
            }

            var item = _schools[position];

            var image = convertView.FindViewById<ImageView>(Resource.Id.EducationItemImage);
            image.SetImageDrawable( Context.Resources.GetDrawable(item.Image) );

            var line1 = convertView.FindViewById<TextView>(Resource.Id.EducationItemLine1);
            line1.Text = item.Name;

            var line2 = convertView.FindViewById<TextView>(Resource.Id.EducationItemLine2);
            line2.Text = item.Degree + " - " + item.Graduation;

            return convertView;
        }
    }
}
