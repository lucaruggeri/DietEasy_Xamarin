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
    public class PersonalInfo
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public bool Sex { get; set; }
        public decimal DailyCalories { get; set; }
        public decimal DailyCarbs { get; set; }
        public decimal DailyFats { get; set; }
        public decimal DailyProteins { get; set; }        
    }
}