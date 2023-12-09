using TheCoolestRPG.GameLogic.Character;
using TheCoolestRPG.GameLogic.Combat;

namespace TheCoolestRPG_YourWelcome_.Additional_UI;

public partial class CombatUI : ContentPage
{
	public CombatUI()
	{
        InitializeComponent();
        txtEnemyNameLeft.Text = Character.GetEnemies()[0].GetCharacterType().ToString();
        txtEnemyNameCenter.Text = Character.GetEnemies()[1].GetCharacterType().ToString();
        txtEnemyNameRight.Text = Character.GetEnemies()[2].GetCharacterType().ToString();
        
        txtEnemyHealthLeft.Text = Character.GetEnemies()[0].GetHealth().ToString();
        txtEnemyHealthCenter.Text = Character.GetEnemies()[1].GetHealth().ToString();
        txtEnemyHealthRight.Text = Character.GetEnemies()[2].GetHealth().ToString();
        
        txtDisplayPlayerHealth.Text = Character.GetPlayerCharacter().GetHealth().ToString();
        txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
    }

    uint target = 0;

    private void RollStrength_Click(object sender, EventArgs e)
    {
        CharacterActions.GetAttackRoll(Character.GetPlayerCharacter().GetStrength(),
                                       Character.GetPlayerCharacter().GetStrengthModifier(),
                                       Character.GetEnemies()[target].GetStrength(),
                                       Character.GetEnemies()[target].GetStrengthModifier(),
                                       Combat.GetPlayerWisdomSuccess(),
                                       Character.GetEnemies()[target].GetConstitution(),
                                       target);

        if (Character.GetEnemies()[target].GetHealth() > 1000)
        {
            Character.GetEnemies()[target] = new Character(0, Character.Type.zombie, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Combat.DecreaseEnemiesActive(1);
        }

        if (target == 0) txtEnemyHealthLeft.Text = Character.GetEnemies()[target].GetHealth().ToString();
        if (target == 1) txtEnemyHealthCenter.Text = Character.GetEnemies()[target].GetHealth().ToString();
        if (target == 2) txtEnemyHealthRight.Text = Character.GetEnemies()[target].GetHealth().ToString();

        if (Combat.GetEnemiesActive() == 0)
        {
            btnTargetLeft.IsVisible = false;
            btnTargetCenter.IsVisible = false;
            btnTargetRight.IsVisible = false;
            btnRollStrength.IsVisible = false;
            btnRollDexterity.IsVisible = false;
            btnRollIntelligence.IsVisible = false;
            btnRollWisdom.IsVisible = false;
        }

        if (Combat.GetEnemiesActive() != 0)
        {
            for (uint i = 0; i < Combat.GetEnemiesActive(); i++)
                CharacterActions.GetEnemyAttack(Character.GetEnemies()[i].GetStrength(),
                                                Character.GetPlayerCharacter().GetStrength(),
                                                Character.GetEnemies()[i].GetStrengthModifier(),
                                                Character.GetPlayerCharacter().GetConstitution(),
                                                i);
        }

        if (Character.GetPlayerCharacter().GetHealth() > 1000) Character.KillPlayer();

        if (Character.GetPlayerExists() == false)
        {
            btnTargetLeft.IsVisible = false;
            btnTargetCenter.IsVisible = false;
            btnTargetRight.IsVisible = false;
            btnRollStrength.IsVisible = false;
            btnRollDexterity.IsVisible = false;
            btnRollIntelligence.IsVisible = false;
            btnRollWisdom.IsVisible = false;
        }
        else
        {
            if (Combat.GetPlayerWisdomSuccess() > 1) Combat.ResetPlayerWisdomSuccess();

            txtDisplayPlayerHealth.Text = Character.GetPlayerCharacter().GetHealth().ToString();
            txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
        }

    }

    private void RollDexterity_Click(object sender, EventArgs e)
    {
        CharacterActions.GetAttackRoll(Character.GetPlayerCharacter().GetDexterity(),
                                       Character.GetPlayerCharacter().GetDexterityModifier(),
                                       Character.GetEnemies()[target].GetDexterity(),
                                       Character.GetEnemies()[target].GetDexterityModifier(),
                                       Combat.GetPlayerWisdomSuccess(),
                                       Character.GetEnemies()[target].GetConstitution(),
                                       target);

        if (Character.GetEnemies()[target].GetHealth() > 1000)
        {
            Character.GetEnemies()[target] = new Character(0, Character.Type.zombie, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Combat.DecreaseEnemiesActive(1);
        }

        if (target == 0) txtEnemyHealthLeft.Text = Character.GetEnemies()[target].GetHealth().ToString();
        if (target == 1) txtEnemyHealthCenter.Text = Character.GetEnemies()[target].GetHealth().ToString();
        if (target == 2) txtEnemyHealthRight.Text = Character.GetEnemies()[target].GetHealth().ToString();

        if (Combat.GetEnemiesActive() == 0)
        {
            btnTargetLeft.IsVisible = false;
            btnTargetCenter.IsVisible = false;
            btnTargetRight.IsVisible = false;
            btnRollStrength.IsVisible = false;
            btnRollDexterity.IsVisible = false;
            btnRollIntelligence.IsVisible = false;
            btnRollWisdom.IsVisible = false;
        }

        if (Combat.GetEnemiesActive() != 0)
        {
            for (uint i = 0; i < Combat.GetEnemiesActive(); i++)
                CharacterActions.GetEnemyAttack(Character.GetEnemies()[i].GetDexterity(),
                                                Character.GetPlayerCharacter().GetDexterity(),
                                                Character.GetEnemies()[i].GetDexterityModifier(),
                                                Character.GetPlayerCharacter().GetConstitution(),
                                                i);
        }

        if (Character.GetPlayerCharacter().GetHealth() > 1000) Character.KillPlayer();

        if (Character.GetPlayerExists() == false)
        {
            btnTargetLeft.IsVisible = false;
            btnTargetCenter.IsVisible = false;
            btnTargetRight.IsVisible = false;
            btnRollStrength.IsVisible = false;
            btnRollDexterity.IsVisible = false;
            btnRollIntelligence.IsVisible = false;
            btnRollWisdom.IsVisible = false;
        }
        else
        {
            if (Combat.GetPlayerWisdomSuccess() > 1) Combat.ResetPlayerWisdomSuccess();

            txtDisplayPlayerHealth.Text = Character.GetPlayerCharacter().GetHealth().ToString();
            txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
        }

    }

    private void RollIntelligence_Click(object sender, EventArgs e)
    {
        CharacterActions.GetAttackRoll(Character.GetPlayerCharacter().GetIntelligence(),
                                       Character.GetPlayerCharacter().GetIntelligenceModifier(),
                                       Character.GetEnemies()[target].GetIntelligence(),
                                       Character.GetEnemies()[target].GetIntelligenceModifier(),
                                       Combat.GetPlayerWisdomSuccess(),
                                       Character.GetEnemies()[target].GetConstitution(),
                                       target);

        if (Character.GetEnemies()[target].GetHealth() > 1000)
        {
            Character.GetEnemies()[target] = new Character(0, Character.Type.zombie, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Combat.DecreaseEnemiesActive(1);
        }

        if (target == 0) txtEnemyHealthLeft.Text = Character.GetEnemies()[target].GetHealth().ToString();
        if (target == 1) txtEnemyHealthCenter.Text = Character.GetEnemies()[target].GetHealth().ToString();
        if (target == 2) txtEnemyHealthRight.Text = Character.GetEnemies()[target].GetHealth().ToString();

        if (Combat.GetEnemiesActive() == 0)
        {
            btnTargetLeft.IsVisible = false;
            btnTargetCenter.IsVisible = false;
            btnTargetRight.IsVisible = false;
            btnRollStrength.IsVisible = false;
            btnRollDexterity.IsVisible = false;
            btnRollIntelligence.IsVisible = false;
            btnRollWisdom.IsVisible = false;
        }

        if (Combat.GetEnemiesActive() != 0)
        {
            for (uint i = 0; i < Combat.GetEnemiesActive(); i++)
                CharacterActions.GetEnemyAttack(Character.GetEnemies()[i].GetIntelligence(),
                                                Character.GetPlayerCharacter().GetIntelligence(),
                                                Character.GetEnemies()[i].GetIntelligenceModifier(),
                                                Character.GetPlayerCharacter().GetConstitution(),
                                                i);
        }

        if (Character.GetPlayerCharacter().GetHealth() > 1000) Character.KillPlayer();

        if (Character.GetPlayerExists() == false)
        {
            btnTargetLeft.IsVisible = false;
            btnTargetCenter.IsVisible = false;
            btnTargetRight.IsVisible = false;
            btnRollStrength.IsVisible = false;
            btnRollDexterity.IsVisible = false;
            btnRollIntelligence.IsVisible = false;
            btnRollWisdom.IsVisible = false;
        }
        else
        {
            if (Combat.GetPlayerWisdomSuccess() > 1) Combat.ResetPlayerWisdomSuccess();

            txtDisplayPlayerHealth.Text = Character.GetPlayerCharacter().GetHealth().ToString();
            txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
        }

    }

    private void RollWisdom_Click(object sender, EventArgs e)
    {
        Combat.SetWisdomActive(true);

        if (Combat.GetEnemiesActive() != 0)
        {
            for (uint i = 0; i < Combat.GetEnemiesActive(); i++)
                CharacterActions.GetEnemyAttack(Character.GetEnemies()[i].GetStrength(),
                                                Character.GetEnemies()[i].GetStrengthModifier(),
                                                Character.GetPlayerCharacter().GetStrength(),
                                                Character.GetPlayerCharacter().GetConstitution(),
                                                i);
        }

        Combat.SetWisdomActive(false);

        txtDisplayPlayerHealth.Text = Character.GetPlayerCharacter().GetHealth().ToString();
        txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
    }

    private void RollCharisma_Click(object sender, EventArgs e)
    {
        //
    }

    private void btnTargetLeft_Click(object sender, EventArgs e)
    {
        target = 0;
    }

    private void btnTargetCenter_Click(object sender, EventArgs e)
    {
        target = 1;
    }

    private void btnTargetRight_Click(object sender, EventArgs e)
    {
        target = 2;
    }
}


//    // If not using randomly generated values, consider changing the damage Calculation to (attackRoll * wisdomSuccess - defenseRoll - enemyConstitution)



            //<Image
            //Source = "zombie.webp"
            //Scale="0.2"
            //Margin="150,150,-150,-150"
            //HorizontalOptions="Start" VerticalOptions="Start"
            ///>
