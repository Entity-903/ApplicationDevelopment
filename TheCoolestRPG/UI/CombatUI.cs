using TheCoolestRPG.GameLogic.Character;
using TheCoolestRPG.GameLogic.Combat;

namespace TheCoolestRPG
{
    public partial class CombatUI : Form
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
                txtDisplayWinLose.Text = "You have succeeded!";
                btnTargetLeft.Visible = false;
                btnTargetCenter.Visible = false;
                btnTargetRight.Visible = false;
                btnRollStrength.Visible = false;
                btnRollDexterity.Visible = false;
                btnRollIntelligence.Visible = false;
                btnRollWisdom.Visible = false;
                btnRollCharisma.Visible = false;
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
                txtDisplayWinLose.Text = "You have fallen!";
                btnTargetLeft.Visible = false;
                btnTargetCenter.Visible = false;
                btnTargetRight.Visible = false;
                btnRollStrength.Visible = false;
                btnRollDexterity.Visible = false;
                btnRollIntelligence.Visible = false;
                btnRollWisdom.Visible = false;
                btnRollCharisma.Visible = false;
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

            if (target == 0) txtEnemyHealthLeft.Text   = Character.GetEnemies()[target].GetHealth().ToString();
            if (target == 1) txtEnemyHealthCenter.Text = Character.GetEnemies()[target].GetHealth().ToString();
            if (target == 2) txtEnemyHealthRight.Text  = Character.GetEnemies()[target].GetHealth().ToString();

            if (Combat.GetEnemiesActive() == 0)
            {
                txtDisplayWinLose.Text = "You have succeeded!";
                btnTargetLeft.Visible = false;
                btnTargetCenter.Visible = false;
                btnTargetRight.Visible = false;
                btnRollStrength.Visible = false;
                btnRollDexterity.Visible = false;
                btnRollIntelligence.Visible = false;
                btnRollWisdom.Visible = false;
                btnRollCharisma.Visible = false;
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
                txtDisplayWinLose.Text = "You have fallen!";
                btnTargetLeft.Visible = false;
                btnTargetCenter.Visible = false;
                btnTargetRight.Visible = false;
                btnRollStrength.Visible = false;
                btnRollDexterity.Visible = false;
                btnRollIntelligence.Visible = false;
                btnRollWisdom.Visible = false;
                btnRollCharisma.Visible = false;
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
                txtDisplayWinLose.Text = "You have succeeded!";
                btnTargetLeft.Visible = false;
                btnTargetCenter.Visible = false;
                btnTargetRight.Visible = false;
                btnRollStrength.Visible = false;
                btnRollDexterity.Visible = false;
                btnRollIntelligence.Visible = false;
                btnRollWisdom.Visible = false;
                btnRollCharisma.Visible = false;
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
                txtDisplayWinLose.Text = "You have fallen!";
                btnTargetLeft.Visible = false;
                btnTargetCenter.Visible = false;
                btnTargetRight.Visible = false;
                btnRollStrength.Visible = false;
                btnRollDexterity.Visible = false;
                btnRollIntelligence.Visible = false;
                btnRollWisdom.Visible = false;
                btnRollCharisma.Visible = false;
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

            if (Combat.GetReveals()[0] == true)
            {
                txtEnemyStrengthLeft.Text = Character.GetEnemies()[0].GetStrength().ToString();
                txtEnemyStrengthModifierLeft.Text = Character.GetEnemies()[0].GetStrengthModifier().ToString();
                txtEnemyDexterityLeft.Text = Character.GetEnemies()[0].GetDexterity().ToString();
                txtEnemyDexterityModifierLeft.Text = Character.GetEnemies()[0].GetDexterityModifier().ToString();
                txtEnemyIntelligenceLeft.Text = Character.GetEnemies()[0].GetIntelligence().ToString();
                txtEnemyIntelligenceModifierLeft.Text = Character.GetEnemies()[0].GetIntelligenceModifier().ToString();
                txtEnemyConstitutionLeft.Text = Character.GetEnemies()[0].GetConstitution().ToString();
                txtEnemyConstitutionModifierLeft.Text = Character.GetEnemies()[0].GetConstitutionModifier().ToString();
                txtEnemyWisdomLeft.Text = Character.GetEnemies()[0].GetWisdom().ToString();
                txtEnemyWisdomModifierLeft.Text = Character.GetEnemies()[0].GetWisdomModifier().ToString();
                txtEnemyCharismaLeft.Text = Character.GetEnemies()[0].GetCharisma().ToString();
                txtEnemyCharismaModifierLeft.Text = Character.GetEnemies()[0].GetCharismaModifier().ToString();
            }
            if (Combat.GetReveals()[1] == true)
            {
                txtEnemyStrengthCenter.Text = Character.GetEnemies()[1].GetStrength().ToString();
                txtEnemyStrengthModifierCenter.Text = Character.GetEnemies()[1].GetStrengthModifier().ToString();
                txtEnemyDexterityCenter.Text = Character.GetEnemies()[1].GetDexterity().ToString();
                txtEnemyDexterityModifierCenter.Text = Character.GetEnemies()[1].GetDexterityModifier().ToString();
                txtEnemyIntelligenceCenter.Text = Character.GetEnemies()[1].GetIntelligence().ToString();
                txtEnemyIntelligenceModifierCenter.Text = Character.GetEnemies()[1].GetIntelligenceModifier().ToString();
                txtEnemyConstitutionCenter.Text = Character.GetEnemies()[1].GetConstitution().ToString();
                txtEnemyConstitutionModifierCenter.Text = Character.GetEnemies()[1].GetConstitutionModifier().ToString();
                txtEnemyWisdomCenter.Text = Character.GetEnemies()[1].GetWisdom().ToString();
                txtEnemyWisdomModifierCenter.Text = Character.GetEnemies()[1].GetWisdomModifier().ToString();
                txtEnemyCharismaCenter.Text = Character.GetEnemies()[1].GetCharisma().ToString();
                txtEnemyCharismaModifierCenter.Text = Character.GetEnemies()[1].GetCharismaModifier().ToString();
            }
            if (Combat.GetReveals()[2] == true)
            {
                txtEnemyStrengthRight.Text = Character.GetEnemies()[2].GetStrength().ToString();
                txtEnemyStrengthModifierRight.Text = Character.GetEnemies()[2].GetStrengthModifier().ToString();
                txtEnemyDexterityRight.Text = Character.GetEnemies()[2].GetDexterity().ToString();
                txtEnemyDexterityModifierRight.Text = Character.GetEnemies()[2].GetDexterityModifier().ToString();
                txtEnemyIntelligenceRight.Text = Character.GetEnemies()[2].GetIntelligence().ToString();
                txtEnemyIntelligenceModifierRight.Text = Character.GetEnemies()[2].GetIntelligenceModifier().ToString();
                txtEnemyConstitutionRight.Text = Character.GetEnemies()[2].GetConstitution().ToString();
                txtEnemyConstitutionModifierRight.Text = Character.GetEnemies()[2].GetConstitutionModifier().ToString();
                txtEnemyWisdomRight.Text = Character.GetEnemies()[2].GetWisdom().ToString();
                txtEnemyWisdomModifierRight.Text = Character.GetEnemies()[2].GetWisdomModifier().ToString();
                txtEnemyCharismaRight.Text = Character.GetEnemies()[2].GetCharisma().ToString();
                txtEnemyCharismaModifierRight.Text = Character.GetEnemies()[2].GetCharismaModifier().ToString();
            }

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


    // If not using randomly generated values, consider changing the damage Calculation to (attackRoll * wisdomSuccess - defenseRoll - enemyConstitution)
}