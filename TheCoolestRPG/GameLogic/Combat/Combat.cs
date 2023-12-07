using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.GameLogic.Combat
{
    internal class Combat
    {
        private static uint playerWisdomSuccess = 1;
        private static bool wisdomActive = false;

        public static uint GetPlayerWisdomSuccess()
        {
            return playerWisdomSuccess;
        }

        public static void ResetPlayerWisdomSuccess()
        {
            playerWisdomSuccess = 1;
            Combat.SetWisdomActive(false);
        }

        public static void BoostPlayerWisdomSuccess()
        {
            playerWisdomSuccess++;
        }

        public static bool GetWisdomActive()
        {
            return wisdomActive;
        }

        public static void SetWisdomActive(bool value)
        {
            wisdomActive = value;
        }

        public static string CheckTarget(uint value)
        {
            if (value == 0) { return "Left"; }
            else
            if (value == 1) { return "Center"; }
            else { return "Right"; }
        }
    }
}
