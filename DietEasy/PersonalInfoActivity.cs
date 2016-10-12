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
    public class PersonalInfoActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.PersonalInfo);

            Button btnConfirm = FindViewById<Button>(Resource.Id.btnConfirm);
            btnConfirm.Click += delegate { ConfirmPersonalInfo(); };
        }

        private void ConfirmPersonalInfo()
        {

            EditText txtName = FindViewById<EditText>(Resource.Id.txtName);
            EditText txtCalories = FindViewById<EditText>(Resource.Id.txtCalories);
            EditText txtCarbs = FindViewById<EditText>(Resource.Id.txtCarbs);
            EditText txtFats = FindViewById<EditText>(Resource.Id.txtFats);
            EditText txtProteins = FindViewById<EditText>(Resource.Id.txtProteins);

            if ((txtCalories.Text != null) && (txtCarbs.Text != null) && (txtFats.Text != null) && (txtProteins.Text != null))
            {
                Database.DatabaseManager.SetPersonalInfo(txtName.Text, txtCalories.Text, txtCarbs.Text, txtFats.Text, txtProteins.Text);

                Utilities.Navigation.GoToSearchFood(this);
            }

        }

    }
}

