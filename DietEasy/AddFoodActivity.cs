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
    public class AddFoodActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AddFood);

            Button btnAddFood = FindViewById<Button>(Resource.Id.btnAddFood);
            btnAddFood.Click += delegate { AddFood(); };
        }

        private void AddFood()
        {
            EditText txtName = FindViewById<EditText>(Resource.Id.txtName);
            EditText txtCalories = FindViewById<EditText>(Resource.Id.txtCalories);
            EditText txtCarbs = FindViewById<EditText>(Resource.Id.txtCarbs);
            EditText txtFats = FindViewById<EditText>(Resource.Id.txtFats);
            EditText txtProteins = FindViewById<EditText>(Resource.Id.txtProteins);

            if ((txtCalories.Text != null) && (txtCarbs.Text != null) && (txtFats.Text != null) && (txtProteins.Text != null))
            {
                Database.DatabaseManager.CreateFood(txtName.Text, txtCalories.Text, txtCarbs.Text, txtFats.Text, txtProteins.Text);

                Utilities.Navigation.GoToSearchFood(this);
            }

        }

    }
}

