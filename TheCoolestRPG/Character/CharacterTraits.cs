using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.Character
{
    internal class CharacterTraits
    {
        public CharacterTraits() { }

        public CharacterTraits(bool isPlayer)
        { 
            
        }

        public CharacterTraits(string name, bool isPlayer, uint health, uint type, uint strength, uint dexterity, uint intelligence, uint constitution, uint wisdom, uint charisma)
        {
            this.name = name;

            if (isPlayer)
            {
                this.playerCharacter = type;
            }
            else
            {
                if (type == 4) Console.WriteLine("No such enemy type!");
                this.enemyCharacter = type;
            }

            this.health = health;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;
            this.wisdom = wisdom;
            this.charisma = charisma;
        }

        enum classType : uint
        {
            knight = 0,      // melee
            archer = 1,      // ranged
            mage = 2,        // magic
            philosopher = 3, // wisdom,   otherwise known as evasive bullshit; 
            politician = 4   // charisma, otherwise known as Pacifist Route; 

        }

        enum enemyType : uint
        {
            // Undead enemies have no charisma, but are immune to charisma-based actions, since their wills are tied to their summoner

            goblin = 0,// can perform ranged or melee attacks; +1 on both
            skeleton = 1, // melee
            zombie = 2, // melee, flesh acts as a protective shell
            necromancer = 3 // Can perform a variety of attacks; +2 on intelligence, constitution; +1 on wisdom, charisma; -2 on dexterity;
        }

        // Name, Class/Enemy, Strength, Agility, Intelligence

        string name = "";

        uint playerCharacter = 0;

        uint enemyCharacter = 0;

        uint health = 0;
        uint strength = 0; // Mainly affects Melee, or any physical attack; Knights have an inherient +2 buff to this trait
        uint dexterity = 0; // Affects all classes, determining who attacks first and/or how frequently in battle; Archers, due to being ranged, have an inherient +2 buff to this trait.
        uint intelligence = 0; // mainly affects Mages, or any magic attack, such as a Necromancer's Summon; Mages have an inherient +2 buff to this trait
        uint constitution = 0; // DeFeNcE; Determines inherent damage resistance and effectiveness of defensive maneuvers; Knights have a +1 buff to this trait
        uint wisdom = 0; // Dodge, can also enhance attacks by taking opponents by surprise, dealing additional damage; Allows for the ability to check the stats of an opponent
        uint charisma = 0; // Persuasiveness; Philosophers do a little bit of trolling
    }
}
