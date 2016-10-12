using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections.Generic;
using DietEasyLibrary;

namespace DietEasy
{
    [Activity(Label = "DietEasy", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            //creating and populating database
            Database.DatabaseManager.CreateAndPopulateFixedData();
            Database.DatabaseManager.CreateAndPopulateChangingData();

            if (Database.DatabaseManager.GetDayMealsNumber() > 0)
            {
                LoadSelectedFoodList();
            }

            //controls 
            Button btnSearchFood = FindViewById<Button>(Resource.Id.btnSearchFood);
            btnSearchFood.Click += delegate { SearchFood(); };

            Button btnReset = FindViewById<Button>(Resource.Id.btnReset);
            btnReset.Click += delegate { Reset(); };

            TextView txtCalendar = FindViewById<TextView>(Resource.Id.txtCalendar);
            txtCalendar.Text = Database.DatabaseManager.TODAY.ToShortDateString();

            TextView txtTotal = FindViewById<TextView>(Resource.Id.txtTotal);
            txtTotal.Text = GetTotalDescription();
        }

        private string GetTotalDescription()
        {
            string description = string.Empty;

            description = description + "Total:\n";
            description = description + "Calories " + Database.DatabaseManager.GetDayMealTotalCalories(Database.DatabaseManager.TODAY).ToString() + ", ";
            description = description + "Carbs " + Database.DatabaseManager.GetDayMealTotalCarbs(Database.DatabaseManager.TODAY).ToString() + ", ";
            description = description + "\n";
            description = description + "Fats " + Database.DatabaseManager.GetDayMealTotalFats(Database.DatabaseManager.TODAY).ToString() + ", ";
            description = description + "Proteins " + Database.DatabaseManager.GetDayMealTotalProteins(Database.DatabaseManager.TODAY).ToString() + ", ";

            return description;
        }

        private void LoadSelectedFoodList()
        {
            //EditText txtSearch = FindViewById<EditText>(Resource.Id.txtSearch);
            //string foodFilter = txtSearch.Text.Trim();

            List<DayMeal> dayMealsList = Database.DatabaseManager.GetDayMealsList(Database.DatabaseManager.TODAY);

            Utilities.SelectedFoodAdapter selectedFoodAdapterList = new Utilities.SelectedFoodAdapter(this, dayMealsList);

            ListView lstSelectedFood = FindViewById<ListView>(Resource.Id.lstSelectedFood);
            lstSelectedFood.SetAdapter(selectedFoodAdapterList);
            lstSelectedFood.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
            {
                //SelectFood(lstSearchFood.GetItemAtPosition(e.Position).ToString());
            };
        }

        private void SearchFood()
        {
            Utilities.Navigation.GoToSearchFood(this);
        }

        private void Reset()
        {
            Database.DatabaseManager.ResetDayMeal();

            Utilities.Navigation.GoToMain(this);
        }

    }
}

