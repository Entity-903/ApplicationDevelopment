using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoolestRPG.GameLogic.Character;

namespace TheCoolestRPG
{
    public partial class CharacterCreation : Form
    {
        private static Character? player;
        private static Character[]? enemies = new Character[3];

        private static bool playerExists = false;

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void btnCustomCreate_Click(object sender, EventArgs e)
        {
            playerExists = true;

            uint strength             = (uint)numericStrength.Value;
            uint dexterity            = (uint)numericDexterity.Value;
            uint intelligence         = (uint)numericIntelligence.Value;
            uint constitution         = (uint)numericConstitution.Value;
            uint wisdom               = (uint)numericWisdom.Value;
            uint charisma             = (uint)numericCharisma.Value;

            uint strengthModifier     = (uint)((strength) * 0.25f);
            uint dexterityModifier    = (uint)((dexterity) * 0.25f);
            uint intelligenceModifier = (uint)((intelligence) * 0.25f);
            uint constitutionModifier = (uint)((constitution) * 0.25f);
            uint wisdomModifier       = (uint)((wisdom) * 0.25f);
            uint charismaModifier     = (uint)((charisma) * 0.25f);

            player = new Character(10 * constitution, Character.Type.custom, strength, strengthModifier, dexterity, dexterityModifier, intelligence, intelligenceModifier, constitution, constitutionModifier, wisdom, wisdomModifier, charisma, charismaModifier);
            
            uint zombieStrength     = 13;
            uint zombieDexterity    = 8;
            uint zombieIntelligence = 7;
            uint zombieConstitution = 10;
            uint zombieWisdom       = 1;
            uint zombieCharisma     = 0;

            uint zombieStrengthModifier     = (uint)((zombieStrength) * 0.25f);
            uint zombieDexterityModifier    = (uint)((zombieDexterity) * 0.25f);
            uint zombieIntelligenceModifier = (uint)((zombieIntelligence) * 0.25f);
            uint zombieConstitutionModifier = (uint)((zombieConstitution) * 0.25f);
            uint zombieWisdomModifier       = (uint)((zombieWisdom) * 0.25f);
            uint zombieCharismaModifier     = (uint)((zombieCharisma) * 0.25f);

            for (int i = 0; i < 3; i++)
            {
                enemies[i] = new Character(10 * zombieConstitution, Character.Type.zombie, zombieStrength, zombieStrengthModifier, zombieDexterity, zombieDexterityModifier, zombieIntelligence, zombieIntelligenceModifier, zombieConstitution, zombieConstitutionModifier, zombieWisdom, zombieWisdomModifier, zombieCharisma, zombieCharismaModifier);
            }

            Close();
        }

        public static Character[] GetEnemies()
        {
            return enemies;
        }

        public static bool GetPlayerExists()
        {
            return (player != null);
        }

        public static Character? GetPlayerCharacter()
        {
            if (player != null) return player;
            else return null;
        }

        private void numericStrength_ValueChanged(object sender, EventArgs e)
        {
            uint value = (uint)numericStrength.Value;
            labelStrengthModifier.Text = "+" + ((uint)((value) * 0.25f)).ToString();
        }

        private void numericDexterity_ValueChanged(object sender, EventArgs e)
        {
            uint value = (uint)numericDexterity.Value;
            labelDexterityModifier.Text = "+" + ((uint)((value) * 0.25f)).ToString();
        }

        private void numericIntelligence_ValueChanged(object sender, EventArgs e)
        {
            uint value = (uint)numericIntelligence.Value;
            labelIntelligenceModifier.Text = "+" + ((uint)((value) * 0.25f)).ToString();
        }

        private void numericConstitution_ValueChanged(object sender, EventArgs e)
        {
            uint value = (uint)numericConstitution.Value;
            labelConstitutionModifier.Text = "+" + ((uint)((value) * 0.25f)).ToString();
        }

        private void numericWisdom_ValueChanged(object sender, EventArgs e)
        {
            uint value = (uint)numericWisdom.Value;
            labelWisdomModifier.Text = "+" + ((uint)((value) * 0.25f)).ToString();
        }

        private void numericCharisma_ValueChanged(object sender, EventArgs e)
        {
            uint value = (uint)numericCharisma.Value;
            labelCharismaModifier.Text = "+" + ((uint)((value) * 0.25f)).ToString();
        }
    }
}
