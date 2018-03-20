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
using App3.Resources.Model;
using Java.Lang;

namespace App3.Resources
{
    public class SelectedListViewAdapter : BaseAdapter
    {
        private Activity activity;

        private List<NewAlcohol> lstNewAlcohole;

        public SelectedListViewAdapter(Activity activity, List<NewAlcohol> lstNewAlcohol)
        {
            this.activity = activity;
            this.lstNewAlcohole = lstNewAlcohol;
        }

        public override int Count
        {
            get
            {
                return lstNewAlcohole.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstNewAlcohole[position].SelectedId;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ListViewLastWindow, parent, false);

            var SelectedtxtName = view.FindViewById<TextView>(Resource.Id.textSelectedName);
            var SelectedtxtVolume = view.FindViewById<TextView>(Resource.Id.textSelectedVolume);
            var SelectedtxtDescription = view.FindViewById<TextView>(Resource.Id.textSelectedDiscription);
            var SelectedtxtAlcoholPercent = view.FindViewById<TextView>(Resource.Id.textSelectedAlcoholPercent);

            SelectedtxtName.Text = lstNewAlcohole[position].SelectedNameAlcohol;
            SelectedtxtVolume.Text = lstNewAlcohole[position].SelectedVolume.ToString();
            SelectedtxtDescription.Text = lstNewAlcohole[position].SelectedDiscription;
            SelectedtxtAlcoholPercent.Text = lstNewAlcohole[position].SelectedAlcoholPercent.ToString();

            return view;
        }
    }
}