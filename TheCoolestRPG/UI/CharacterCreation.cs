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
        static Character player;
        private static bool playerExists = false;

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void btnCustomCreate_Click(object sender, EventArgs e)
        {
            playerExists = true;

            uint strength = (uint)numericStrength.Value;
            uint dexterity = (uint)numericDexterity.Value;
            uint intelligence = (uint)numericIntelligence.Value;
            uint constitution = (uint)numericConstitution.Value;
            uint wisdom = (uint)numericWisdom.Value;
            uint charisma = (uint)numericCharisma.Value;

            uint strengthModifier = (uint)((strength) * 0.25f);
            uint dexterityModifier = (uint)((dexterity) * 0.25f);
            uint intelligenceModifier = (uint)((intelligence) * 0.25f);
            uint constitutionModifier = (uint)((constitution) * 0.25f);
            uint wisdomModifier = (uint)((wisdom) * 0.25f);
            uint charismaModifier = (uint)((charisma) * 0.25f);

            player = new Character(10 * constitution, Character.Type.custom, strength, strengthModifier, dexterity, dexterityModifier, intelligence, intelligenceModifier, constitution, constitutionModifier, wisdom, wisdomModifier, charisma, charismaModifier);

            Close();
        }

        public static bool GetPlayerExists()
        {
            return playerExists;
        }

        //public static Character GetPlayerCharacter()
        //{
        //    if (playerExists) return player;
        //    else return new Character(0, Character.Type.custom, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        //}

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
