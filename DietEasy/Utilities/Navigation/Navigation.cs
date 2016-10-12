using System;
using System.Collections.Generic;
using System.Linq;

using System.Reflection;

using Android.App;
using Android.Graphics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;
using System.IO;
using Android.InputMethodServices;
using Java.IO;
using Java.Lang;
using Java.Net;

using DietEasy;

namespace Utilities
{
    public static class Navigation
    {

        public static void GoToMain(Activity currentActivity)
        {
            Intent intent = new Intent(currentActivity, typeof(MainActivity));
            currentActivity.StartActivity(intent);
        }

        public static void GoToSearchFood(Activity currentActivity)
        {
            Intent myIntent = new Intent(currentActivity, typeof(SearchFoodActivity));
            currentActivity.StartActivity(myIntent);
        }

        public static void GoToAddFood(Activity currentActivity)
        {
            Intent myIntent = new Intent(currentActivity, typeof(AddFoodActivity));
            currentActivity.StartActivity(myIntent);
        }

        public static void GoToSelectefFood(Activity currentActivity)
        {
            Intent myIntent = new Intent(currentActivity, typeof(SelectedFoodActivity));
            currentActivity.StartActivity(myIntent);
        }
    }

}