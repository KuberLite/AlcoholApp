using System.Collections.Generic;
using App3.Resources.Model;

namespace App3.Resources.Helpers
{
    public class DataContainer
    {
        public static List<Alcohol> alcohols { get; }

        static DataContainer()
        {
            alcohols = new List<Alcohol>();
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Pilsner",
                    Volume = 1.5,
                    Discription = "Beer",
                    AlcoholPercent = 6.8
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Finlandia",
                    Volume = 1,
                    Discription = "Vodka",
                    AlcoholPercent = 38
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Jack Daniels",
                    Volume = 0.33,
                    Discription = "Whiskey",
                    AlcoholPercent = 40
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Hennessy",
                    Volume = 0.7,
                    Discription = "Cognac",
                    AlcoholPercent = 40
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Alivaria",
                    Volume = 0.5,
                    Discription = "Beer",
                    AlcoholPercent = 4.8
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Svayak",
                    Volume = 1,
                    Discription = "Vodka",
                    AlcoholPercent = 40
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Lidskoe",
                    Volume = 2,
                    Discription = "Beer",
                    AlcoholPercent = 5.7
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Bloody mary",
                    Volume = 0.33,
                    Discription = "Cocktail",
                    AlcoholPercent = 27
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Anri",
                    Volume = 0.7,
                    Discription = "Cognac",
                    AlcoholPercent = 40
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Ice Wine Saperavi",
                    Volume = 1,
                    Discription = "Wine",
                    AlcoholPercent = 15
                });
            alcohols.Add(
                new Alcohol
                {
                    NameAlcohol = "Bacardi Black",
                    Volume = 0.75,
                    Discription = "Rum",
                    AlcoholPercent = 40
                });
        }
    }
}       