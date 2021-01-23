using System;
using System.Collections.Generic;
using System.Text;

namespace DnDMobile.Classes
{
    class RollDice
    {
        public int RollRandom(int min, int max)
        {
            return StaticVariables.randomNumber.Next(min, max);
        }
    }
}
