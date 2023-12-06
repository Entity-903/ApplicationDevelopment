using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.GameLogic.Character
{
    internal class CharacterActions
    {
        // If I were to incorperate charisma into gameplay, also create a resolve variable, equivalent to 10 * charisma


        // Dialogue and Status Checks -------------------------------------------------------------------------------------------------------------------------------------------
        public static bool GetCharismaSuccess(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier)
        {
            bool result = (new Random().Next(0, (int)attackRoll + 1) > new Random().Next(0, (int)defendRoll + 1));

            return result;
        }

        public static bool GetWisdomSuccess(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier)
        {
            bool result = (new Random().Next(0, (int)attackRoll + 1) > new Random().Next(0, (int)defendRoll + 1));

            return result;
        }

        // Combat Calculations ---------------------------------------------------------------------------------------------------------------------------------------

        public static void GetAttackRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyResistance, uint target)
        {
            CharacterCreation.GetEnemies()[target].DamageHealth((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll) * (int)wisdomSuccess - ((int)enemyResistance / 2));
        }

        public static void GetDexterityRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyResistance, uint target)
        {
            CharacterCreation.GetEnemies()[target].DamageHealth((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll) * (int)wisdomSuccess - ((int)enemyResistance / 2));
        }

        public static void GetIntelligenceRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyResistance, uint target)
        {
            CharacterCreation.GetEnemies()[target].DamageHealth((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll) * (int)wisdomSuccess - ((int)enemyResistance / 2));
        }

        public static uint GetCharismaRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyResistance)
        {
            return (((attackRoll + attackRollModifier) * 2) + (attackRoll - defendRoll)) * wisdomSuccess;
        }

        public static uint GetEnemiesAttacks()
        {
            for (int i = 0; i < 3; i++)
            {

            }
        }
    }
}

/* What if, to determine which character acted first, we implemented the following:
 * Each character had a value attackSpeed = 10;
 * Each character had a value statusEffect = 1;
 * The character's attack speed would be calculated by attackSpeed + (dexterity + dexterityModifier) * statusEffect;
 * attackSpeed represents the time it takes for the character to attack again
 * Therefore, characters with the highest attack speed would attack first
 * If an enemy and player share the same attackSpeed, the player acts first
 * If two or more enemies share the same attackSpeed, the order of such enemies goes from left to right (in the array, if we ever implemement an array).
*/