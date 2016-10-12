using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using System.Collections.Generic;
using Database;
using DietEasyLibrary;

namespace DietEasy
{
    [Activity(Label = "DietEasy", MainLauncher = false, Icon = "@drawable/icon")]
    public class SearchFoodActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SearchFood);

            ActivateSearch();

            EditText txtSearch = FindViewById<EditText>(Resource.Id.txtSearch);
            txtSearch.TextChanged += delegate { ActivateSearch(); };

            Button btnAddFood = FindViewById<Button>(Resource.Id.btnAddFood);
            btnAddFood.Click += delegate { GoToAddFood(); };
        }

        private void ActivateSearch()
        {
            EditText txtSearch = FindViewById<EditText>(Resource.Id.txtSearch);
            string foodFilter = txtSearch.Text.Trim();

            List<Food> foodList = Database.DatabaseManager.GetFoodList(foodFilter);

            Utilities.SearchFoodAdapter searchFoodAdapterList = new Utilities.SearchFoodAdapter(this, foodList);

            ListView lstSearchFood = FindViewById<ListView>(Resource.Id.lstSearchFood);
            lstSearchFood.SetAdapter(searchFoodAdapterList);
            lstSearchFood.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
            {
                SelectFood(lstSearchFood.GetItemAtPosition(e.Position).ToString());
            };
        }

        private void SelectFood(string foodId)
        {
            int selectedFoodId = Convert.ToInt16(foodId);
            Food selectedFood = Database.DatabaseManager.GetFood(selectedFoodId);

            Database.DatabaseManager.selectedFood = selectedFood;

            GoToSelectedFood();
        }

        private void GoToAddFood()
        {
            Utilities.Navigation.GoToAddFood(this);
        }

        private void GoToMain()
        {
            Utilities.Navigation.GoToMain(this);
        }

        private void GoToSelectedFood()
        {
            Utilities.Navigation.GoToSelectefFood(this);
        }

    }
}

