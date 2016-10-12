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

namespace DietEasyLibrary
{
    public static class DicePool
    {
        public static int PlayDicePool(int dice)
        {
            int result = 0;

            for (int i = 0; i < dice; i++)
            {
                result = result + TestDice();   
            }

            return result;
        }

        private static int TestDice()
        {
            if (Utilities.RandomUtility.GenerateRandomNumber(1, 6) >= 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

}