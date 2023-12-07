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

        public static void GetAttackRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyConstitution, uint target)
        {
            CharacterCreation.GetEnemies()[target].DamageHealth(((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll)) * (int)wisdomSuccess - ((int)enemyConstitution / 2));
        }

        public static void GetDexterityRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyConstitution, uint target)
        {
            CharacterCreation.GetEnemies()[target].DamageHealth(((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll)) * (int)wisdomSuccess - ((int)enemyConstitution / 2));
        }

        public static void GetIntelligenceRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyConstitution, uint target)
        {
            CharacterCreation.GetEnemies()[target].DamageHealth(((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll)) * (int)wisdomSuccess - ((int)enemyConstitution / 2));
        }

        public static void GetCharismaRoll(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier, uint wisdomSuccess, uint enemyConstitution, uint target)
        {
            //                                       |||||||||||||
            //CharacterCreation.GetEnemies()[target].DamageResolve((((int)attackRoll + (int)attackRollModifier) * 2) + ((int)attackRoll - (int)defendRoll) * (int)wisdomSuccess - ((int)enemyConstitution / 2));
        }

        public static bool GetWisdomCalculation(uint attackRoll, uint attackRollModifier, uint defendRoll, uint defendRollModifier)
        {
            bool result = (attackRoll + attackRollModifier) > (defendRoll + defendRollModifier);

            return result;
        }

        public static void GetEnemyAttack(uint enemyAttack, uint enemyAttackModifier, uint playerDefense, uint playerConstitution, uint enemy, uint enemyWisdomSuccess = 1)
        {
            bool wisdomPass = false;

            if (CombatUI.GetEnemiesActive() > 0)
            {
                    if (CharacterCreation.GetPlayerExists())
                    {
                        if (Combat.Combat.GetWisdomActive())
                        {
                            wisdomPass = GetWisdomCalculation(CharacterCreation.GetPlayerCharacter().GetWisdom(),
                                                          CharacterCreation.GetPlayerCharacter().GetWisdomModifier(),
                                                          CharacterCreation.GetEnemies()[enemy].GetWisdom(),
                                                          CharacterCreation.GetEnemies()[enemy].GetWisdomModifier());
                        }

                        if (!wisdomPass)
                        { 
                                CharacterCreation.GetPlayerCharacter().DamageHealth(((((int)enemyAttack + (int)enemyAttackModifier) * 2) + ((int)enemyAttack - (int)playerDefense) * (int)enemyWisdomSuccess - ((int)playerConstitution)) / 3);
                                if (Combat.Combat.GetPlayerWisdomSuccess() != 1)
                                {
                                    Combat.Combat.ResetPlayerWisdomSuccess();
                                }
                        
                        }
                        else
                        {
                            CombatUI.SetReveal(true, enemy);
                            Combat.Combat.BoostPlayerWisdomSuccess();
                        }
                    }
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