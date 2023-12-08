using TheCoolestRPG.GameLogic.Character;
using TheCoolestRPG.GameLogic.Story;

namespace TheCoolestRPG_YourWelcome_.Additional_UI;

public partial class DialogueUI : ContentPage
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
            btnContinue.IsVisible = false;

            btnApproach.IsVisible = true;
            btnAvoid.IsVisible = true;
            btnRecall.IsVisible = true;
        }

        if (Story.GetCurrentStory() == 1 && Story.GetCurrentStoryString() == 2)
        {
            btnContinue.IsVisible = false;

            btnConfirm.IsVisible = true;
            btnDeny.IsVisible = true;
        }

        if (Story.GetCurrentStory() == 2 && Story.GetCurrentStoryString() == 3)
        {
            btnContinue.IsVisible = false;
        }

        if (Story.GetCurrentStory() == 3 && Story.GetCurrentStoryString() == 2)
        {
            btnContinue.IsVisible = false;

            btnApproach.IsVisible = true;
            btnAvoid.IsVisible = true;
        }

        if (Story.GetCurrentStory() == 3 && Story.GetCurrentStoryString() == 4)
        {
            btnContinue.IsVisible = false;

            btnApproach.IsVisible = true;
            btnAvoid.IsVisible = true;
        }

        if (Story.GetCurrentStory() == 4 && Story.GetCurrentStoryString() == 2)
        {
            btnContinue.IsVisible = false;
        }

        if (Story.GetCurrentStory() == 4 && Story.GetCurrentStoryString() == 4)
        {
            btnContinue.IsVisible = false;
            btnCombatStart.IsVisible = true;
        }

        if (Story.GetCurrentStory() == 4 && Story.GetCurrentStoryString() == 6)
        {
            btnContinue.IsVisible = false;
            btnCombatStart.IsVisible = true;
        }

        if (Story.GetCurrentStory() == 5 && Story.GetCurrentStoryString() == 1)
        {
            btnContinue.IsVisible = false;
            btnCombatStart.IsVisible = true;

        }

        txtCurrentDialogue.Text = Story.GetCurrentStoryText();
    }

    // Choice Buttons

    private void btnApproach_Click(object sender, EventArgs e)
    {
        // Player approaches the lake

        btnContinue.IsVisible = true;

        btnApproach.IsVisible = false;
        btnAvoid.IsVisible = false;
        btnRecall.IsVisible = false;

        Story.ProgressChoice((Story.GetCurrentStory() == 0) ? 1 : -2);
        Story.ResetStoryArray();
        txtCurrentDialogue.Text = Story.GetCurrentStoryText();
    }

    private void btnAvoid_Click(object sender, EventArgs e)
    {
        // Player avoids the lake

        btnContinue.IsVisible = true;

        btnApproach.IsVisible = false;
        btnAvoid.IsVisible = false;
        btnRecall.IsVisible = false;

        Story.ProgressChoice((Story.GetCurrentStory() == 0) ? 2 : -1);
        Story.ResetStoryArray();
        txtCurrentDialogue.Text = Story.GetCurrentStoryText();
    }
    private void btnRecall_Click(object sender, EventArgs e)
    {
        // Player rolls a wisdom check to attempt remembering where the player has heard of the lake before
        bool pass = CharacterActions.GetWisdomSuccess(Character.GetPlayerCharacter().GetWisdom(), Character.GetPlayerCharacter().GetWisdomModifier(), 7, 1);

        Story.ProgressChoice(3);

        btnContinue.IsVisible = true;

        btnApproach.IsVisible = false;
        btnAvoid.IsVisible = false;
        btnRecall.IsVisible = false;

        Story.SetStoryArray((pass) ? 0 : 3);
        txtCurrentDialogue.Text = Story.GetCurrentStoryText();
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        // Player recognizes the bodies in the water

        btnContinue.IsVisible = true;

        btnConfirm.IsVisible = false;
        btnDeny.IsVisible = false;

        Story.ProgressChoice(4);
        Story.ResetStoryArray();
        txtCurrentDialogue.Text = Story.GetCurrentStoryText();
    }

    private void btnDeny_Click(object sender, EventArgs e)
    {
        // Player claims to not recognize the bodies in the water
        bool lakeAmusement = new Random().Next(0, 2) == 1;


        // Check if player believes it themselves
        bool pass = CharacterActions.GetCharismaSuccess(Character.GetPlayerCharacter().GetCharisma(),
                                                        Character.GetPlayerCharacter().GetCharismaModifier(),
                                                        Character.GetPlayerCharacter().GetCharisma(),
                                                        Character.GetPlayerCharacter().GetCharismaModifier());
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

        btnContinue.IsVisible = true;

        btnConfirm.IsVisible = false;
        btnDeny.IsVisible = false;

        txtCurrentDialogue.Text = Story.GetCurrentStoryText();
    }

    private void btnCombatStart_Click(object sender, EventArgs e)
    {
        Story.SetInitializeFight(true);

        Application.Current.OpenWindow(new Window(new CombatUI()));
        Application.Current.CloseWindow(Window);
    }
}