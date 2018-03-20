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

        private List<MatchedAlcohol> lstNewAlcohole;

        public SelectedListViewAdapter(Activity activity, List<MatchedAlcohol> lstNewAlcohol)
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
            return lstNewAlcohole[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ListViewLastWindow, parent, false);

            var SelectedtxtName = view.FindViewById<TextView>(Resource.Id.textSelectedName);
            var SelectedtxtVolume = view.FindViewById<TextView>(Resource.Id.textSelectedVolume);
            var SelectedtxtDescription = view.FindViewById<TextView>(Resource.Id.textSelectedDiscription);
            var SelectedtxtAlcoholPercent = view.FindViewById<TextView>(Resource.Id.textSelectedAlcoholPercent);
            var SelectedCount = view.FindViewById<TextView>(Resource.Id.textSelectedCount);

            SelectedtxtName.Text = lstNewAlcohole[position].NameAlcohol;
            SelectedtxtVolume.Text = lstNewAlcohole[position].Volume.ToString();
            SelectedtxtDescription.Text = lstNewAlcohole[position].Discription;
            SelectedtxtAlcoholPercent.Text = lstNewAlcohole[position].AlcoholPercent.ToString();
            SelectedCount.Text = "x " + lstNewAlcohole[position].Count.ToString();

            return view;
        }
    }
}