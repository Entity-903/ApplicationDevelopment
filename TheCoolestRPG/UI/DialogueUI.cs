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
using TheCoolestRPG.GameLogic.Story;

namespace TheCoolestRPG
{
    public partial class DialogueUI : Form
    {
        public DialogueUI()
        {
            InitializeComponent();
            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Story.ProgressStory();


            if (Story.GetCurrentStory() == 0 && Story.GetCurrentStoryString() == 2)
            {
                btnContinue.Visible = false;

                btnApproach.Visible = true;
                btnAvoid.Visible = true;
                btnRecall.Visible = true;
            }

            if (Story.GetCurrentStory() == 1 && Story.GetCurrentStoryString() == 2)
            {
                btnContinue.Visible = false;

                btnConfirm.Visible = true;
                btnDeny.Visible = true;
            }

            if (Story.GetCurrentStory() == 2 && Story.GetCurrentStoryString() == 3)
            {
                btnContinue.Visible = false;
            }

            if (Story.GetCurrentStory() == 3 && Story.GetCurrentStoryString() == 2)
            {
                btnContinue.Visible = false;

                btnApproach.Visible = true;
                btnAvoid.Visible = true;
            }

            if (Story.GetCurrentStory() == 3 && Story.GetCurrentStoryString() == 4)
            {
                btnContinue.Visible = false;

                btnApproach.Visible = true;
                btnAvoid.Visible = true;
            }

            if (Story.GetCurrentStory() == 4 && Story.GetCurrentStoryString() == 2)
            {
                btnContinue.Visible = false;
            }

            if (Story.GetCurrentStory() == 4 && Story.GetCurrentStoryString() == 4)
            {
                btnContinue.Visible = false;
                btnCombatStart.Visible = true;
            }

            if (Story.GetCurrentStory() == 4 && Story.GetCurrentStoryString() == 6)
            {
                btnContinue.Visible = false;
                btnCombatStart.Visible = true;
            }

            if (Story.GetCurrentStory() == 5 && Story.GetCurrentStoryString() == 1)
            {
                btnContinue.Visible = false;
                btnCombatStart.Visible = true;

            }

            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }

        // Choice Buttons

        private void btnApproach_Click(object sender, EventArgs e)
        {
            // Player approaches the lake

            btnContinue.Visible = true;

            btnApproach.Visible = false;
            btnAvoid.Visible = false;
            btnRecall.Visible = false;

            Story.ProgressChoice((Story.GetCurrentStory() == 0) ? 1 : -2);
            Story.ResetStoryArray();
            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }

        private void btnAvoid_Click(object sender, EventArgs e)
        {
            // Player avoids the lake

            btnContinue.Visible = true;

            btnApproach.Visible = false;
            btnAvoid.Visible = false;
            btnRecall.Visible = false;

            Story.ProgressChoice((Story.GetCurrentStory() == 0) ? 2 : -1);
            Story.ResetStoryArray();
            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }
        private void btnCheckFamiliarity_Click(object sender, EventArgs e)
        {
            // Player rolls a wisdom check to attempt remembering where the player has heard of the lake before
            bool pass = CharacterActions.GetWisdomSuccess(CharacterCreation.GetPlayerCharacter().getWisdom(), CharacterCreation.GetPlayerCharacter().getWisdomModifier(), 7, 1);

            Story.ProgressChoice(3);

            btnContinue.Visible = true;

            btnApproach.Visible = false;
            btnAvoid.Visible = false;
            btnRecall.Visible = false;

            Story.SetStoryArray((pass) ? 0 : 3);
            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Player recognizes the bodies in the water

            btnContinue.Visible = true;

            btnConfirm.Visible = false;
            btnDeny.Visible = false;

            Story.ProgressChoice(4);
            Story.ResetStoryArray();
            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            // Player claims to not recognize the bodies in the water
            bool lakeAmusement = new Random().Next(0, 2) == 1;


            // Check if player believes it themselves
            bool pass = CharacterActions.GetCharismaSuccess(CharacterCreation.GetPlayerCharacter().getCharisma(),
                                                            CharacterCreation.GetPlayerCharacter().getCharismaModifier(),
                                                            CharacterCreation.GetPlayerCharacter().getCharisma(),
                                                            CharacterCreation.GetPlayerCharacter().getCharismaModifier());

            Story.ProgressChoice(3);

            // does player fail check?
            if (!pass)
            {
                Story.SetStoryArray(5);
            }
            // does lake fail to entertain?
            else if (!lakeAmusement)
            {
                Story.SetStoryArray(3);
            }
            else
            {
                Story.ResetStoryArray();
            }

            btnContinue.Visible = true;

            btnConfirm.Visible = false;
            btnDeny.Visible = false;

            txtCurrentDialogue.Text = Story.GetCurrentStoryText();
        }

        private void btnCombatStart_Click(object sender, EventArgs e)
        {
            Story.SetInitializeFight(true);

            Close();
        }
    }




}
