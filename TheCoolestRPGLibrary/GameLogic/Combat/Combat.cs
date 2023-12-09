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

//<Image
//    x:Name="imgEnemyLeft"
//    Source = "zombie.webp"
//    Scale="0.15"
//    Margin="-600,-550,0,-450"
//    HorizontalOptions="Start" VerticalOptions="Start"/>
//

//<Image
//    x:Name="imgEnemyCenter"
//    Source = "zombie.webp"
//    Scale="0.15"
//    Margin="-600,-550,-150,-150"
//    HorizontalOptions="Start" VerticalOptions="Start" />
//

//<Image
//    x:Name="imgEnemyRight"
//    Source = "zombie.webp"
//    Scale="0.15"
//    Margin="-700,-650,-150,-150"
//    HorizontalOptions="Start" VerticalOptions="Start" />
//

//<Button
//    x:Name="btnRollStrength"
//    Text="Strength"
//    Margin="0,0,0,0"
//    FontSize="32"
//    IsVisible="True"
//    HorizontalOptions="Start" VerticalOptions="End" />