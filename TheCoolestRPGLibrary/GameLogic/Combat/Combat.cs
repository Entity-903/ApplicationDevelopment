using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.GameLogic.Combat
{
    public class Combat
    {
        static uint enemiesActive = 3;
        static bool[] reveals = { false, false, false };
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

        public static uint GetEnemiesActive()
        {
            return enemiesActive;
        }

        public static void DecreaseEnemiesActive(uint value)
        {
            enemiesActive -= value;
        }

        public static void SetReveal(bool value, uint target)
        {
            reveals[target] = value;
        }

        public static bool[] GetReveals()
        {
            return reveals;
        }
    }
}
