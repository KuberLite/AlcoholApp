using Android.App;
using Android.Widget;
using Android.OS;
using System;
using App3.Resources.Model;
using System.Collections.Generic;
using App3.Resources.DataHelper;
using App3.Resources;

namespace App3
{
    [Activity(Label = "Alcohol party", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public static string nameLevel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            PressAllImageButton();
        }
        #region ImageButton
        private void PressImageButtonFirstFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonFirstFace).Click += delegate
            {
                nameLevel = "Easy";
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressImageButtonSecondFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonSecondFace).Click += delegate
            {
                nameLevel = "Second";
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressImageButtonThirdFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonThirdFace).Click += delegate
            {
                nameLevel = "Third";
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressImageButtonFourthFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonFourthFace).Click += delegate
            {
                nameLevel = "Fourth";
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressAllImageButton()
        {
            PressImageButtonFirstFace();
            PressImageButtonSecondFace();
            PressImageButtonThirdFace();
            PressImageButtonFourthFace();
        }
        #endregion
    }
}

