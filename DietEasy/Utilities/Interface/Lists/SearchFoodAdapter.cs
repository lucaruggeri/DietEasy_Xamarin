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
    public class SearchFoodAdapter: BaseAdapter<string>
    {
        List<Food> foodList;
        Activity context;
        public SearchFoodAdapter(Activity context, List<Food> foodList): base()
        {
            this.context = context;
            this.foodList = foodList;
        }
        public override long GetItemId(int position)
        {
            return foodList[position].Id;
        }
        public override string this[int position]
        {
            get { return foodList[position].Id.ToString(); }
        }
        public override int Count
        {
            get { return foodList.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is supplied
            if (view == null) // otherwise create a new one
                view =
                context.LayoutInflater.Inflate(Resource.Layout.SearchFoodItem,
                null);
            
            // set view properties to reflect data for the given row
            view.FindViewById<TextView>(Resource.Id.textView1).Text = CreateName(foodList[position]);
            
            view.FindViewById<TextView>(Resource.Id.textView2).Text = CreateDescription(foodList[position]);

            view.FindViewById<ImageView>(Resource.Id.imageView1).SetScaleType(ImageView.ScaleType.CenterInside);
            view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(Resource.Drawable.add);

            // return the view, populated with data, for display
            return view;             
        }

        private string CreateName(Food food)
        {
            return food.Name;
        }
        private string CreateDescription(Food food)
        {
            return "Calories " + food.Calories.ToString() + ", Carbs " + food.Carbs.ToString() + ", Fats " + food.Fats.ToString() + ", Proteins " + food.Proteins.ToString();
        }
    }

}