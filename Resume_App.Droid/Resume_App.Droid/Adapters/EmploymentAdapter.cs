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
    public class EmploymentAdapter : ArrayAdapter<Employer>
    {
        private IList<Employer> _employers;

        public EmploymentAdapter(Context context, IList<Employer> list)
            :base(context, 0, list)
        {
            _employers = list;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = LayoutInflater.FromContext(Context).Inflate(Resource.Layout.EmploymentItem, null);
            }

            var item = _employers[position];

            var image = convertView.FindViewById<ImageView>(Resource.Id.EmployerItemImage);
            image.SetImageDrawable(Context.Resources.GetDrawable( Context.Resources.GetIdentifier(item.Name, "drawable", Context.PackageName)));

            var line1 = convertView.FindViewById<TextView>(Resource.Id.EmployerItemLine1);
            line1.Text = item.DateWorked + ": " + item.Title;

            var line2 = convertView.FindViewById<TextView>(Resource.Id.EmployerItemLine2);
            line2.Text = item.Name + " -- " + item.Location;

            return convertView;
        }
    }
}
