using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Utilities
{
    public static class RandomUtility
    {
        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random((int) DateTime.Now.Ticks & 0x0000FFFF);

            SleepToChangeTheSeed();

            int randomNumber = random.Next(min, max + 1); //TODO +1???

            return randomNumber;
        }

        private static void SleepToChangeTheSeed()
        {
            //pausa per cambiare il seed
            Thread.Sleep(1);
        }
    }
}