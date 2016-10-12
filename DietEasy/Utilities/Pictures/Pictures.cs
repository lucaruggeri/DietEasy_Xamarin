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
    public static class Pictures
    {

        //public static int GetFemalePortrait(int pictureId)
        //{
        //    switch (pictureId)
        //    {
        //        case 1:
        //            return Resource.Drawable.PortraitFemale1;
        //        case 2:
        //            return Resource.Drawable.PortraitFemale2;
        //        default:
        //            return Resource.Drawable.PortraitFemale1;
        //    }
        //}

        //public static int GetMalePortrait(int pictureId)
        //{
        //    switch (pictureId)
        //    {
        //        case 1:
        //            return Resource.Drawable.PortraitMale1;
        //        case 2:
        //            return Resource.Drawable.PortraitMale2;
        //        default:
        //            return Resource.Drawable.PortraitMale1;
        //    }
        //}

        public static int ChooseARandomFemalePortrait()
        {
            int randomNumber = Utilities.RandomUtility.GenerateRandomNumber(1, 24);

            switch (randomNumber)
            {
                case 1:
                    return Resource.Drawable.Icon;
                default:
                    return Resource.Drawable.Icon;
            }
        }

        public static int ChooseARandomMalePortrait()
        {
            int randomNumber = Utilities.RandomUtility.GenerateRandomNumber(1, 7);

            switch (randomNumber)
            {
                case 1:
                    return Resource.Drawable.Icon;
                default:
                    return Resource.Drawable.Icon;
            }
        }

        public static int GetWeaponPicture(string pictureId)
        {
            switch (pictureId)
            {
                case "M68":
                    return Resource.Drawable.Icon;
                default:
                    return Resource.Drawable.Icon;
            }
        }

    }

}