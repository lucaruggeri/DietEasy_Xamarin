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

using System.IO;
using SQLite;
using DietEasyLibrary;

namespace Database
{
    public static partial class DatabaseManager
    {

        public static void SetPersonalInfo(string name, string calories, string carbs, string fats, string proteins)
        {
            try 
            {
                PersonalInfo newPersonalInfo = new PersonalInfo();
                newPersonalInfo.DailyCalories = Convert.ToDecimal(calories);
                newPersonalInfo.DailyCarbs = Convert.ToDecimal(carbs);
                newPersonalInfo.DailyFats = Convert.ToDecimal(fats);
                newPersonalInfo.DailyProteins = Convert.ToDecimal(proteins);

                db.Insert(newPersonalInfo);
            }
            catch
            {
            }
        }

        public static PersonalInfo GetPersonalInfo()
        {
            try
            {
                List<PersonalInfo> list = (from x in db.Table<PersonalInfo>()
                                           select x
                                    ).ToList();

                return list[0];
            }
            catch
            {
                return null;
            }

        }

    }
}