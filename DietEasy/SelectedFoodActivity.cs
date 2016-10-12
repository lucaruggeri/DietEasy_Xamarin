using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

using Database;
using DietEasyLibrary;

namespace DietEasy
{
    [Activity(Label = "DietEasy", MainLauncher = false, Icon = "@drawable/icon")]
    public class SelectedFoodActivity : Activity
    {
        Food selectedFood = Database.DatabaseManager.selectedFood;
        decimal quantity = 100;
        decimal lastQuantity = 100;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SelectedFood);

            LoadSelectedFood();

            Button btnAddFood = FindViewById<Button>(Resource.Id.btnAddFood);
            btnAddFood.Click += delegate { AddFoodToDailyFood(); };

            ImageView btnLeft = FindViewById<ImageView>(Resource.Id.btnLeft);
            btnLeft.SetScaleType(ImageView.ScaleType.CenterInside);
            btnLeft.SetImageResource(Resource.Drawable.left);
            btnLeft.Click += delegate { LessQuantity(); };

            ImageView btnRight = FindViewById<ImageView>(Resource.Id.btnRight);
            btnRight.SetScaleType(ImageView.ScaleType.CenterInside);
            btnRight.SetImageResource(Resource.Drawable.right);
            btnRight.Click += delegate { MoreQuantity(); };
}

        private void LoadSelectedFood()
        {
            LoadFoodInfo(selectedFood, quantity);
        }

        private void LoadFoodInfo(Food food, decimal quantity)
        {
            if (food != null)
            {
                TextView txtName = FindViewById<TextView>(Resource.Id.txtName);
                TextView txtCalories = FindViewById<TextView>(Resource.Id.txtCalories);
                TextView txtCarbs = FindViewById<TextView>(Resource.Id.txtCarbs);
                TextView txtFats = FindViewById<TextView>(Resource.Id.txtFats);
                TextView txtProteins = FindViewById<TextView>(Resource.Id.txtProteins);

                txtName.Text = food.Name;
                txtCalories.Text = food.CaloriesInGrams(quantity).ToString("0.##");
                txtCarbs.Text = food.CarbsInGrams(quantity).ToString("0.##");
                txtFats.Text = food.FatsInGrams(quantity).ToString("0.##");
                txtProteins.Text = food.ProteinsInGrams(quantity).ToString("0.##");

                EditText txtQuantity = FindViewById<EditText>(Resource.Id.txtQuantity);
                txtQuantity.TextChanged += delegate { SetQuantity(); };
                txtQuantity.Text = quantity.ToString("0.##");
                txtQuantity.SetSelection(txtQuantity.Length());
            }
        }

        private void LessQuantity()
        {
            quantity = quantity - 1;
            LoadFoodInfo(selectedFood, quantity);
        }

        private void MoreQuantity()
        {
            quantity = quantity + 1;
            LoadFoodInfo(selectedFood, quantity);
        }

        private void SetQuantity()
        {
            EditText txtQuantity = FindViewById<EditText>(Resource.Id.txtQuantity);
            txtQuantity.SetSelection(txtQuantity.Length());

            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                //remove the zero at the beginning
                if (txtQuantity.Text.StartsWith("0"))
                {
                    if (txtQuantity.Text.Length > 1)
                    {
                        txtQuantity.Text = txtQuantity.Text.Remove(0, 1);
                    }
                }

                //text to number
                try
                {
                    quantity = Convert.ToDecimal(txtQuantity.Text);
                }
                catch
                {
                    quantity = 0;
                    LoadFoodInfo(selectedFood, quantity);
                }
            }
            else
            {
                quantity = 0;
                LoadFoodInfo(selectedFood, quantity);
            }

            if (lastQuantity != quantity)
            {
                try
                {
                    decimal newQuantity = Convert.ToDecimal(txtQuantity.Text);

                    if (newQuantity > 0)
                    {
                        quantity = newQuantity;
                        lastQuantity = quantity;
                        LoadFoodInfo(selectedFood, quantity);
                    }
                    else
                    {
                        quantity = 0;
                    }
                }
                catch
                {
                    quantity = 0;
                }
            }
            
        }

        private void AddFoodToDailyFood()
        {
            EditText txtQuantity = FindViewById<EditText>(Resource.Id.txtQuantity);

            if (selectedFood != null)
            {
                try
                {
                    Database.DatabaseManager.AddDayMeal(selectedFood.Id, Convert.ToInt16(txtQuantity.Text));                    
                }
                catch
                {

                }
            }

            Utilities.Navigation.GoToMain(this);
        }

    }
}

