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

namespace App3.Resources.Model
{
    class Alcohol
    {
        public int ID { get; set; }

        public string NameAlcohol { get; set; }

        public double Volume { get; set; }

        public string Discription { get; set; }
    }
}