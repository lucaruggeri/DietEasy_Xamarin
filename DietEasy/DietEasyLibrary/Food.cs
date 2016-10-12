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

namespace DietEasyLibrary
{
    public class Food
    {
        //PRIMARY KEY
        public int Id { get; set; }

        //personal data
        public string Name { get; set; }
        public decimal Calories { get; set; }
        public decimal Carbs { get; set; }
        public decimal Fats { get; set; }
        public decimal Proteins { get; set; }

        public decimal CaloriesInGrams(decimal grams)
        {
            return ValueInGrams(this.Calories, grams);
        }
        public decimal CarbsInGrams(decimal grams)
        {
            return ValueInGrams(this.Carbs, grams);
        }
        public decimal FatsInGrams(decimal grams)
        {
            return ValueInGrams(this.Fats, grams);
        }
        public decimal ProteinsInGrams(decimal grams)
        {
            return ValueInGrams(this.Proteins, grams);
        }

        private decimal ValueInGrams(decimal value, decimal grams)
        {
            decimal result = 0;
            decimal valuesInOneGram = 0;

            if (value > 0)
            {
                valuesInOneGram = Decimal.Divide(value, 100);
                result = Decimal.Multiply(valuesInOneGram, grams);

                if (result < 0)
                {
                    result = 0;
                }
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}