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
using App3.Resources;
using App3.Resources.Helepers;
using App3.Resources.Helpers;
using App3.Resources.Model;

namespace App3
{
    [Activity(Label = "Alcohol Party")]
    public class LastWindowActivity : Activity
    {
        private List<MatchedAlcohol> matchedAlcohol;

        private void GetMatchedAlcohol()
        {
            AlcoholicIntoxicationCalculator calculator = new AlcoholicIntoxicationCalculator(Logistics.state);
            calculator.Calculate();
            matchedAlcohol = calculator.GetResult();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.LastWindow);

            GetMatchedAlcohol();
            ListView lstSelectedData = FindViewById<ListView>(Resource.Id.listSelected);
            var selectedAdapter = new SelectedListViewAdapter(this, matchedAlcohol);
            lstSelectedData.Adapter = selectedAdapter;

            var textSelectedStatePeople = FindViewById<TextView>(Resource.Id.textSelectedStatePeople);
            var textSelectedCountPeople = FindViewById<TextView>(Resource.Id.textSelectedCountPeople);

            textSelectedCountPeople.Text = QuantityActivity.count.ToString() + " person";
            textSelectedStatePeople.Text = MainActivity.nameLevel.ToString() + " level";
        }
    }
}