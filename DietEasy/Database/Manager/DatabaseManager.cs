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
        public static DateTime TODAY = DateTime.Now.ToLocalTime();
        public static string dbName = "DietEasy.db";
        public static string dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public static string dbFullPath = Path.Combine(dbPath, dbName);
        public static SQLiteConnection db = new SQLiteConnection(dbFullPath);
        public static Food selectedFood = null;

        public static void CreateAndPopulateFixedData()
        {
            if (GetFoodNumber() == 0) //IN DEBUG YOU'D LIKE TO REMOVE THIS
            {
                PopulateFoodTable();
            }
        }

        public static void CreateAndPopulateChangingData()
        {
            if (GetDayMealsNumber() == 0)
            {
                db.DropTable<DayMeal>();
                db.CreateTable<DayMeal>();
            }
        }

        public static void ResetDayMeal()
        {
            db.DropTable<DayMeal>();
            db.CreateTable<DayMeal>();
        }
    }
}