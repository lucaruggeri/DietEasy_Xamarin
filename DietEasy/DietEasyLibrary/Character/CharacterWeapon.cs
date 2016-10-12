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
    public class CharacterWeapon
    {
        public int CharacterId { get; set; }
        public int WeaponId { get; set; }

        //attributes
        public int WeaponHealt { get; set; }
    }

}