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

namespace App3
{
    [Activity(Label = "Alcohol party")]
    class QuantityActivity : Activity
    {
        int count = 0;
        protected override void OnCreate(Bundle savedInstanceState){ 
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Quantity);
            GetSelectedTextView();
            PressButtonPlus();
            PressButtonMinus();
        }

        private void PressButtonMinus(){
            FindViewById<Button>(Resource.Id.buttonQuantityMinus).Click += delegate{
                if (count <= 0) count = 0;
                else FindViewById<TextView>(Resource.Id.textQuantity).Text = (--count).ToString();
            };
        }

        private void PressButtonPlus(){
            FindViewById<Button>(Resource.Id.buttonQuantityPlus).Click += (o, e) => FindViewById<TextView>(Resource.Id.textQuantity).Text = (++count).ToString();
        }

        private string GetSelectedTextView()
        {
            return FindViewById<TextView>(Resource.Id.textSelected).Text = "Selected Alcohole: " + MainActivity.nameLevel + " level";
        }

    }
}   