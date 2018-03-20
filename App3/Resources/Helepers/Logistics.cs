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
using App3.Resources.Helepers;
using App3.Resources.Model;

namespace App3.Resources.Helpers
{
    public static class Logistics
    {
        private static List<Alcohol> selectedAlcohol;
        public static AlcoholicIntoxicationStates state { get; set; }
        public static int NumberOfPeople { get; set; }

        static Logistics()
        {
            selectedAlcohol = new List<Alcohol>();
        }

        public static List<Alcohol> GetAlcoholsList()
        {
            IEnumerable<Alcohol> alcohols = selectedAlcohol.Distinct().OrderByDescending(a => a.AlcoholPercent);
            return alcohols.ToList();
        }

        public static void AddElement(Alcohol alcohol)
        {
            selectedAlcohol.Add(alcohol);
        }

        public static void Clear()
        {
            selectedAlcohol.Clear();
        }
    }
}