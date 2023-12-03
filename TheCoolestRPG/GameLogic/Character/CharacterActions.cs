using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.GameLogic.Character
{
    internal class CharacterActions
    {
        public static bool GetCharismaSuccess(uint attackRoll, uint defendRoll)
        {
            bool result = (new Random().Next(0, (int)attackRoll + 1) > new Random().Next(0, (int)defendRoll + 1));

            return false;
        }

        public static bool GetWisdomSuccess(uint attackRoll, uint defendRoll)
        {
            bool result = (new Random().Next(0, (int)attackRoll + 1) > new Random().Next(0, (int)defendRoll + 1));

            return false;
        }
    }
}
