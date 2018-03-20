using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using App3.Resources.Model;

namespace App3.Resources
{
    class ViewHolder : Java.Lang.Object
    {
        public TextView txtName { get; set; }

        public TextView txtVolume { get; set; }

        public TextView txtDescription { get; set; }

        public TextView txtAlcoholPercent { get; set; }

        public TextView Img { get; set; }

        public TextView SelectedtxtName { get; set; }

        public TextView SelectedtxtVolume { get; set; }

        public TextView SelectedtxtDescription { get; set; }

        public TextView SelectedtxtAlcoholPercent { get; set; }

        public TextView SelectedImg { get; set; }
    }

    public class ListViewAdapter : BaseAdapter
    {
        private Activity activity;

        private List<Alcohol> lstAlcohole;

        public ListViewAdapter(Activity activity, List<Alcohol> lstAlcohol)
        {
            this.activity = activity;
            this.lstAlcohole = lstAlcohol;
        }

        public override int Count{
            get{
                return lstAlcohole.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position){
            return null;
        }

        public override long GetItemId(int position)
        {
            return lstAlcohole[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ListViewAlcohole, parent, false);

            var txtName = view.FindViewById<TextView>(Resource.Id.textView1);
            var txtVolume = view.FindViewById<TextView>(Resource.Id.textView2);
            var txtDescription = view.FindViewById<TextView>(Resource.Id.textView3);
            var txtAlcoholPercent = view.FindViewById<TextView>(Resource.Id.textView4);
            //var imgPathImage = view.FindViewById<TextView>(Resource.Id.demoImageView);

            txtName.Text = lstAlcohole[position].NameAlcohol;
            txtVolume.Text = lstAlcohole[position].Volume.ToString();
            txtDescription.Text = lstAlcohole[position].Discription;
            txtAlcoholPercent.Text = lstAlcohole[position].AlcoholPercent.ToString();
            //imgPathImage.Text = lstAlcohole[position].PathImage;

            return view;
        }
    }
}