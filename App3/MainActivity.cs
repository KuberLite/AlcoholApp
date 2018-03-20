using Android.App;
using Android.Widget;
using Android.OS;
using System;
using App3.Resources.Model;
using System.Collections.Generic;
using App3.Resources.Helpers;
using App3.Resources;
using App3.Resources.Helepers;

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
                Logistics.state = AlcoholicIntoxicationStates.EasyState;
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressImageButtonSecondFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonSecondFace).Click += delegate
            {
                nameLevel = "Medium";
                Logistics.state = AlcoholicIntoxicationStates.MediumState;
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressImageButtonThirdFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonThirdFace).Click += delegate
            {
                nameLevel = "Hard";
                Logistics.state = AlcoholicIntoxicationStates.HardState;
                StartActivity(typeof(QuantityActivity));
            };
        }

        private void PressImageButtonFourthFace()
        {
            FindViewById<ImageButton>(Resource.Id.imageButtonFourthFace).Click += delegate
            {
                nameLevel = "HardBass";
                Logistics.state = AlcoholicIntoxicationStates.HardBassState;
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

