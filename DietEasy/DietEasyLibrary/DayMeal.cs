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
    public class DayMeal
    {
        public DateTime Day { get; set; }
        public int FoodId { get; set; }
        public int FoodQuantity { get; set; }
    }
}