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
    public class Race
    {
        //PRIMARY KEY
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OriginalRaceId { get; set; }
        public int MaxBody { get; set; }
        public int MaxQuickness { get; set; }
        public int MaxStrength { get; set; }
        public int MaxCharisma { get; set; }
        public int MaxIntelligence { get; set; }
        public int MaxWillpower { get; set; }
        public int MaxEssence { get; set; }
        public int MaxMagic { get; set; }

        public bool IsMetavariant()
        {
            if (this.OriginalRaceId != null)
                return true;
            else
                return false;
        }
    }

}