using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

/* Defines each character
 * 
 * Determines the actions a character will make and run calculations
 * 
 * Stores characters in their respective locations 
 * Player will be by themselves, 1 character; Might give the player aid in the form of another character that fights alongside the main character
 * Enemies can appear in groups of up to 3
 * 
 * damage = (((attackersRoll + modifier) * 2) + (attackerRoll - defenderRoll)) * wisdomSuccess;
 * damageRecieved = damage - constitution;
 * 
 * For every 4 points in a skill, gain a +1 modifier to that skill;
 * Modifiers are added to the rolled result;
 */

namespace TheCoolestRPG.GameLogic.Character
{
    internal class Character
    {
        public Character(uint health, Type type, uint strength, uint strengthModifier, uint dexterity, uint dexterityModifier, uint intelligence, uint intelligenceModifier, uint constitution, uint constitutionModifier, uint wisdom, uint wisdomModifier, uint charisma, uint charismaModifier) 
        {
            this.health = health;
            this.type = type;
            this.strength = strength;
            this.strengthModifier = strengthModifier;
            this.dexterity = dexterity;
            this.dexterityModifier = dexterityModifier;
            this.intelligence = intelligence;
            this.intelligenceModifier = intelligenceModifier;
            this.constitution = constitution;
            this.constitutionModifier = constitutionModifier;
            this.wisdom = wisdom;
            this.wisdomModifier = wisdomModifier;
            this.charisma = charisma;
            this.charismaModifier = charismaModifier;
        }

        public enum Type : uint
        {
            custom,      // Custom-made Character; Referred to as "Void"
            knight,      // melee
            archer,      // ranged
            mage,        // magic
            philosopher, // wisdom,   otherwise known as evasive bullshit; 
            politician,  // charisma, otherwise known as Pacifist Route; 

            // Undead enemies have no charisma, but are immune to charisma-based actions, since their wills are tied to their summoner
            // Undead enemies have no constitution, but have built-in defense via flesh
            // Attacks against zombies that affect the skeleton will, after damage calculation, reduce the enemiy's max health

            goblin,// can perform dexterity, strength, or intelligence actions; +2 on dexterity and strength, -1 on intelligence
            skeleton, // strength
            zombie, // strength, turn into skeletons upon death
            necromancer // Can perform a variety of attacks; +2 on intelligence, constitution; +1 on wisdom, charisma; -2 on dexterity;

        }

        private string name = "";

        private Type type = 0;

        private uint health = 0;

        private uint strength = 0; // Mainly affects Melee, or any physical attack; Knights have an inherient +2 buff to this trait

        // Attack rolls for damage
        // Defense rolls (against each melee attack this turn) for immunity to the melee attack.
        // Defense also boosts Strength by +1 for the next turn only

        private uint strengthModifier = 0;

        private uint dexterity = 0; // Affects all classes, determining who attacks first and/or how frequently in battle; Archers, due to being ranged, have an inherient +2 buff to this trait.

        // Attack rolls for damage
        // Attack also has a chance to apply a +10 debuff to opponent's attackSpeed (on next turn only)
        // Charge Attack rolls for attack on the next turn
        // Charge Attack boosts dexterity for the next turn only
        // Guaranteed +10 attackSpeed debuff to opponent (on next turn only)

        private uint dexterityModifier = 0;

        private uint intelligence = 0; // mainly affects Mages, or any magic attack, such as a Necromancer's Summon; Mages have an inherient +2 buff to this trait

        // Attack rolls for damage
        // Shield creates a barrier worth 5;
        // Summon, well, summons. An ally is brought to the caster's aid.
        // Summon via intelligence is specific to the necromancer
        // The roll for the summon determines maxHealth of ally

        // OPTIONAL
        // The character a shield affects has immunity to magic.

        private uint intelligenceModifier = 0;

        private uint constitution = 0; // DeFeNcE; Determines inherent damage resistance and effectiveness of defensive maneuvers; Knights have a +1 buff to this trait

        // Damage resistance is equal to half of the roll
        // Constitution is rolled upon being attacked
        // Applies to all forms of damage

        private uint constitutionModifier = 0;

        private uint wisdom = 0; // Dodge, can also enhance attacks by taking opponents by surprise, dealing 2x additional damage; Allows for the ability to check the stats of an opponent; Philosophers do a bit of trolling

        // If roll succeeds, dodge attack; Also, deal double damage on next attack (stacks)
        // If damaged, lose dodge stacks;

        private uint wisdomModifier = 0;

        private uint charisma = 0; // Persuasiveness; Politicians do a little bit of trolling too

        // Worry about charisma calculation last, since it functions primarily on dialogue interactions

        private uint charismaModifier = 0;

        public uint getStrength()
        {
            return strength;
        }

        public uint getStrengthModifier()
        {
            return strengthModifier;
        }

        public uint getDexterity()
        {
            return dexterity;
        }

        public uint getDexterityModifier()
        {
            return dexterityModifier;
        }

        public uint getIntelligence()
        {
            return intelligence;
        }

        public uint getIntelligenceModifier()
        {
            return intelligenceModifier;
        }

        public uint getConstitution()
        {
            return constitution;
        }

        public uint getConstitutionModifier()
        {
            return constitutionModifier;
        }

        public uint getWisdom()
        {
            return wisdom;
        }

        public uint getWisdomModifier()
        {
            return wisdomModifier;
        }

        public uint getCharisma()
        {
            return charisma;
        }

        public uint getCharismaModifier()
        {
            return charismaModifier;
        }
    }
}
