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
using DietEasy;

namespace Utilities
{
    public class SelectedFoodAdapter: BaseAdapter<string>
    {
        List<DayMeal> dayMealsList;
        Activity context;
        public SelectedFoodAdapter(Activity context, List<DayMeal> dayMealsList): base()
        {
            this.context = context;
            this.dayMealsList = dayMealsList;
        }
        public override long GetItemId(int position)
        {
            //return dayMealsList[position].Id;
            return 0;
        }
        public override string this[int position]
        {
            get { return dayMealsList[position].Day.ToString(); }
        }
        public override int Count
        {
            get { return dayMealsList.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is supplied
            if (view == null) // otherwise create a new one
                view =
                context.LayoutInflater.Inflate(Resource.Layout.SearchFoodItem,
                null);
            
            // set view properties to reflect data for the given row
            view.FindViewById<TextView>(Resource.Id.textView1).Text = CreateFood(dayMealsList[position]);
            
            view.FindViewById<TextView>(Resource.Id.textView2).Text = CreateDescription(dayMealsList[position]);

            view.FindViewById<ImageView>(Resource.Id.imageView1).SetScaleType(ImageView.ScaleType.CenterInside);
            view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(Resource.Drawable.add);

            // return the view, populated with data, for display
            return view;             
        }

        private string CreateFood(DayMeal dayMeal)
        {
            Food food = Database.DatabaseManager.GetFood(dayMeal.FoodId); 
            return food.Name;
        }
        private string CreateDescription(DayMeal dayMeal)
        {
            Food food = Database.DatabaseManager.GetFood(dayMeal.FoodId);

            string description = string.Empty;
            description = description + "Grams " + dayMeal.FoodQuantity.ToString() + ", ";
            description = description + "Calories " + food.CaloriesInGrams(dayMeal.FoodQuantity).ToString() + ", ";
            description = description + "Carbs " + food.CarbsInGrams(dayMeal.FoodQuantity).ToString() + ", ";
            description = description + "Fats " + food.FatsInGrams(dayMeal.FoodQuantity).ToString() + ", ";
            description = description + "Proteins " + food.ProteinsInGrams(dayMeal.FoodQuantity).ToString() + ", ";

            return description;
        }
    }

}