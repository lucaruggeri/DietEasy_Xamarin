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
    public class JobTest
    {
        //PRIMARY KEY
        public int JobId { get; set; }
        public string TestId { get; set; }
        public bool Completed { get; set; }
    }

}