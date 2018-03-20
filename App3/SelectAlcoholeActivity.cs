using Android.App;
using Android.OS;
using Android.Widget;
using App3.Resources;
using App3.Resources.Helpers;
using App3.Resources.Model;
using System;
using System.Collections.Generic;

namespace App3
{
    [Activity(Label = "Alcohol party")]
    class SelectAlcoholeActivity : Activity
    {  
        ListView lstData;

        private static Alcohol GetSelectedAlcohol(AdapterView.ItemClickEventArgs e)
        {
            return new Alcohol()
            {
                NameAlcohol = DataContainer.alcohols[e.Position].NameAlcohol,
                Volume = DataContainer.alcohols[e.Position].Volume,
                Discription = DataContainer.alcohols[e.Position].Discription,
                AlcoholPercent = DataContainer.alcohols[e.Position].AlcoholPercent
            };
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Logistics.Clear();
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MenuAlcohole);

            lstData = FindViewById<ListView>(Resource.Id.listView);
            var adapter = new ListViewAdapter(this, DataContainer.alcohols);
            lstData.Adapter = adapter;

            lstData.ItemClick += lstData_ItemClick;

            FindViewById<Button>(Resource.Id.btnNext).Click += (o, e) =>
            {
                StartActivity(typeof(LastWindowActivity));
            };
        }

        static void lstData_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Alcohol alcohol = GetSelectedAlcohol(e);
            Logistics.AddElement(alcohol);
        }
    }
} 