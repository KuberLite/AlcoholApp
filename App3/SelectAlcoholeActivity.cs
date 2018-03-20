using Android.App;
using Android.OS;
using Android.Widget;
using App3.Resources;
using App3.Resources.DataHelper;
using App3.Resources.Model;
using System;
using System.Collections.Generic;

namespace App3
{
    [Activity(Label = "Alcohol party")]
    class SelectAlcoholeActivity : Activity
    {  
        ListView lstData;
        protected override void OnCreate(Bundle savedInstanceState)
        {
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
            SelectedDataContainer.newAlcohols.Add(
                new NewAlcohol
                {
                    SelectedNameAlcohol = DataContainer.alcohols[e.Position].NameAlcohol,
                    SelectedVolume = DataContainer.alcohols[e.Position].Volume,
                    SelectedDiscription = DataContainer.alcohols[e.Position].Discription,
                    SelectedAlcoholPercent = DataContainer.alcohols[e.Position].AlcoholPercent
                });
        }
    }
} 