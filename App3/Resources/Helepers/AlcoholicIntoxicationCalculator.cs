using System.Collections.Generic;
using System.Linq;
using App3.Resources.Helpers;
using App3.Resources.Model;

namespace App3.Resources.Helepers
{
    public class AlcoholicIntoxicationCalculator
    {
        private const double beerPercentage = 0.026;
        private double totalAlcoholVolume = 0;
        private List<Alcohol> matchedAlcohol;

        public AlcoholicIntoxicationCalculator(AlcoholicIntoxicationStates state)
        {
            totalAlcoholVolume = (int)state * Logistics.NumberOfPeople * beerPercentage;
            matchedAlcohol = new List<Alcohol>();
        }

        private double CalculateSingleAlchol(Alcohol alcohol)
        {
            return alcohol.Volume * alcohol.AlcoholPercent / 100;
        }

        private void AddAlcoholIfMathced(Alcohol alcohol)
        {
            double percentege = totalAlcoholVolume - CalculateSingleAlchol(alcohol);
            if (percentege > 0)
            {
                totalAlcoholVolume = percentege;
                matchedAlcohol.Add(alcohol);
            }
        }

        private void AddMatchedAlcohols(List<Alcohol> alcohols)
        {
            foreach (var alcohol in alcohols)
            {
                AddAlcoholIfMathced(alcohol);
            }
        }

        private Alcohol GetAlcoholFromListWithMinPercentage(List<Alcohol> alcohols)
        {
            double minPercentage = alcohols.Min(a => a.AlcoholPercent);
            return alcohols.FirstOrDefault(a => a.AlcoholPercent == minPercentage);
        }

        private MatchedAlcohol MapAlcoholWithMathcedAlcohol(Alcohol alcohol)
        {
            return new MatchedAlcohol
            {
                Id = alcohol.Id,
                NameAlcohol = alcohol.NameAlcohol,
                AlcoholPercent = alcohol.AlcoholPercent,
                Volume = alcohol.Volume,
                Discription = alcohol.Discription,
                PathImage = alcohol.PathImage
            };
        }

        public void Calculate()
        {
            List<Alcohol> alcohols = Logistics.GetAlcoholsList();
            Alcohol alcoholWithMinPercentage = GetAlcoholFromListWithMinPercentage(alcohols);
            while (totalAlcoholVolume > CalculateSingleAlchol(alcoholWithMinPercentage))
            {
                AddMatchedAlcohols(alcohols);
            }
            matchedAlcohol = matchedAlcohol.OrderBy(a => a.AlcoholPercent).ToList();
        }

        public List<MatchedAlcohol> GetResult()
        {
            List<MatchedAlcohol> alcohols = new List<MatchedAlcohol>();
            foreach (var alcohol in matchedAlcohol.Distinct().ToList())
            {
                MatchedAlcohol match = MapAlcoholWithMathcedAlcohol(alcohol);
                match.Count = matchedAlcohol.Where(a => a.NameAlcohol.Equals(alcohol.NameAlcohol)).Count();
                alcohols.Add(match);
            }
            return alcohols;
        }
    }

    public enum AlcoholicIntoxicationStates {
        EasyState = 1,
        MediumState = 3,
        HardState = 10,
        HardBassState = 15
    }
}