using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class GenerateNames
    {
        static string[] firstNamesCyberpunkMale = new string[] { 
            "Aeglostor", 
            "Faethor", 
            "Helcthor", 
            "Helchanar", 
            "Himdor", 
            "Lostor", 
            "Mitthor", 
            "Nimdor", 
            "Rimdor", 
            "Uilostor", 
            "Adalgrim", 
            "Bandobras", 
            "Bungo", 
            "Dudo", 
            "Fosco", 
            "Hob", 
            "Lyle", 
            "Odo", 
            "Pervince", 
            "Adelard", 
            "Issac", 
            "Jaenke",
            "Chadwick", 
            "Zephyr",
            "Stanton", 
            "Kinnear",
            "Dante", 
            "Blackford",
            "Leif", 
            "Engstrom",
            "Thaddeus", 
            "Grippen",
            "Raphael", 
            "Warwick",
            "Chadwick", 
            "Ryen",
            "Newton", 
            "Flanigan",
            "Michal", 
            "Barrick"
        };
        static string[] firstNamesCyberpunkFemale = new string[] { 
            "Evelynn",
            "Wyse",
            "Alayna", 
            "Holtz",
            "Collene",
            "Wethern",
            "Avril", 
            "Markell",
            "Heidy",
            "Rackham",
            "Catherina", 
            "Dituri",
            "Maryln",
            "Wyse",
            "Phoebe",
            "Leath",
            "Victorina",
            "Ryant",
            "Naida",
            "Laux",
            "Necole", 
            "Lavanchy",
            "Edra", 
            "Markell",
            "Edra",
            "Stoyer",
            "Maddie",
            "Zechiel",
            "Tandra",
            "Wynn",
            "Ellena",
            "Strachan",
            "Vi",
            "Winslett",
            "Elsy",
            "Wyse",
            "Phoebe",
            "Nylund",
            "Neomi",
            "Sonoda",
            "Amira",
            "Mariella",
            "Racine",
            "Jani",
            "Bucanan",
            "Lael",
            "Irani",
            "Jinny",
            "Scofield",
            "Kalyn",
            "Vangelos",
            "Natalya",
            "Flanigan",
            "Genevive",
            "Lockley",
            "Rosette",
            "Nyseth",
            "Ardelle",
            "Hames",
            "Annelle",
            "Markell",
            "Yuki",
            "Bowdoin",
            "Tegan",
            "Holbach",
            "Jessia",
            "Bancroft",
            "Victorina",
            "Wakeman",
            "Shenna",
            "Ducote",
            "Eladia",
            "Graydon",
            "Calista",
            "Laux",
            "Matha",
            "Grippen",
            "Keira",
            "Ocano"
        };

        public static string GenerateFirstName(string sex)
        {
            string name = string.Empty;
            int index = 0;

            if (sex == "F")
            {
                index = Utilities.RandomUtility.GenerateRandomNumber(0, firstNamesCyberpunkFemale.Length);
                return firstNamesCyberpunkFemale[index];
            }
            else
            {
                index = Utilities.RandomUtility.GenerateRandomNumber(0, firstNamesCyberpunkMale.Length);
                return firstNamesCyberpunkMale[index];
            }
         }

        public static string GenerateSurname()
        {
            int index = 0;
            if (RandomUtility.GenerateRandomNumber(0, 1) == 1)
            {
                index = Utilities.RandomUtility.GenerateRandomNumber(0, firstNamesCyberpunkFemale.Length);
                return firstNamesCyberpunkFemale[index];
            }
            else
            {
                index = Utilities.RandomUtility.GenerateRandomNumber(0, firstNamesCyberpunkMale.Length);
                return firstNamesCyberpunkMale[index];
            }
        }

        public static string Middlename()
        {
            int index = 0;
            if (RandomUtility.GenerateRandomNumber(0, 1) == 1)
            {
                index = Utilities.RandomUtility.GenerateRandomNumber(0, firstNamesCyberpunkFemale.Length);
                return firstNamesCyberpunkFemale[index].Substring(0, 1) + ".";
            }
            else
            {
                index = Utilities.RandomUtility.GenerateRandomNumber(0, firstNamesCyberpunkMale.Length);
                return firstNamesCyberpunkMale[index].Substring(0, 1) + ".";
            }
        }

    }
}