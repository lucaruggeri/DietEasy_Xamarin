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
    public class Test
    {
        //PRIMARY KEY
        public int Id { get; set; }
        public string TestCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AttributeRating { get; set; }
        public int SkillRating { get; set; }
        public int Thresholds { get; set; }
        public int Modifier { get; set; }
        public string ModifierReason { get; set; }
    }

}