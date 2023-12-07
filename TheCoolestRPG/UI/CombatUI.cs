using TheCoolestRPG.GameLogic.Character;
using TheCoolestRPG.GameLogic.Combat;

namespace TheCoolestRPG
{
    public partial class CombatUI : Form
    {
        public CombatUI()
        {
            InitializeComponent();
            txtEnemyNameLeft.Text = CharacterCreation.GetEnemies()[0].GetCharacterType().ToString();
            txtEnemyNameCenter.Text = CharacterCreation.GetEnemies()[1].GetCharacterType().ToString();
            txtEnemyNameRight.Text = CharacterCreation.GetEnemies()[2].GetCharacterType().ToString();

            txtEnemyHealthLeft.Text = CharacterCreation.GetEnemies()[0].GetHealth().ToString();
            txtEnemyHealthCenter.Text = CharacterCreation.GetEnemies()[1].GetHealth().ToString();
            txtEnemyHealthRight.Text = CharacterCreation.GetEnemies()[2].GetHealth().ToString();

            txtDisplayPlayerHealth.Text = CharacterCreation.GetPlayerCharacter().GetHealth().ToString();
            txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
        }

        uint target = 0;
        static uint enemiesActive = 3;
        static bool[] reveals = { false, false, false };

        public static bool[] GetReveals()
        {
            return reveals;
        }

        public static uint GetEnemiesActive()
        {
            return enemiesActive;
        }

        public static void SetReveal(bool value, uint target)
        {
            reveals[target] = value;
        }

        private void RollStrength_Click(object sender, EventArgs e)
        {
            CharacterActions.GetAttackRoll(CharacterCreation.GetPlayerCharacter().GetStrength(),
                                           CharacterCreation.GetPlayerCharacter().GetStrengthModifier(),
                                           CharacterCreation.GetEnemies()[target].GetStrength(),
                                           CharacterCreation.GetEnemies()[target].GetStrengthModifier(),
                                           Combat.GetPlayerWisdomSuccess(),
                                           CharacterCreation.GetEnemies()[target].GetConstitution(),
                                           target);

            if (CharacterCreation.GetEnemies()[target].GetHealth() > 1000)
            {
                CharacterCreation.GetEnemies()[target] = new Character(0, Character.Type.zombie, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                enemiesActive--;
            }

            if (target == 0) txtEnemyHealthLeft.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();
            if (target == 1) txtEnemyHealthCenter.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();
            if (target == 2) txtEnemyHealthRight.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();

            if (enemiesActive == 0)
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

            if (enemiesActive != 0)
            {
                for (uint i = 0; i < enemiesActive; i++)
                    CharacterActions.GetEnemyAttack(CharacterCreation.GetEnemies()[i].GetStrength(),
                                                    CharacterCreation.GetPlayerCharacter().GetStrength(),
                                                    CharacterCreation.GetEnemies()[i].GetStrengthModifier(),
                                                    CharacterCreation.GetPlayerCharacter().GetConstitution(),
                                                    i);
            }

            if (CharacterCreation.GetPlayerCharacter().GetHealth() > 1000) CharacterCreation.KillPlayer();

            if (CharacterCreation.GetPlayerExists() == false)
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

                txtDisplayPlayerHealth.Text = CharacterCreation.GetPlayerCharacter().GetHealth().ToString();
                txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
            }

        }

        private void RollDexterity_Click(object sender, EventArgs e)
        {
            CharacterActions.GetAttackRoll(CharacterCreation.GetPlayerCharacter().GetDexterity(),
                                           CharacterCreation.GetPlayerCharacter().GetDexterityModifier(),
                                           CharacterCreation.GetEnemies()[target].GetDexterity(),
                                           CharacterCreation.GetEnemies()[target].GetDexterityModifier(),
                                           Combat.GetPlayerWisdomSuccess(),
                                           CharacterCreation.GetEnemies()[target].GetConstitution(),
                                           target);

            if (CharacterCreation.GetEnemies()[target].GetHealth() > 1000)
            {
                CharacterCreation.GetEnemies()[target] = new Character(0, Character.Type.zombie, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                enemiesActive--;
            }

            if (target == 0) txtEnemyHealthLeft.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();
            if (target == 1) txtEnemyHealthCenter.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();
            if (target == 2) txtEnemyHealthRight.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();

            if (enemiesActive == 0)
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

            if (enemiesActive != 0)
            {
                for (uint i = 0; i < enemiesActive; i++)
                    CharacterActions.GetEnemyAttack(CharacterCreation.GetEnemies()[i].GetDexterity(),
                                                    CharacterCreation.GetPlayerCharacter().GetDexterity(),
                                                    CharacterCreation.GetEnemies()[i].GetDexterityModifier(),
                                                    CharacterCreation.GetPlayerCharacter().GetConstitution(),
                                                    i);
            }

            if (CharacterCreation.GetPlayerCharacter().GetHealth() > 1000) CharacterCreation.KillPlayer();

            if (CharacterCreation.GetPlayerExists() == false)
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

                txtDisplayPlayerHealth.Text = CharacterCreation.GetPlayerCharacter().GetHealth().ToString();
                txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
            }

        }

        private void RollIntelligence_Click(object sender, EventArgs e)
        {
            CharacterActions.GetAttackRoll(CharacterCreation.GetPlayerCharacter().GetIntelligence(),
                                           CharacterCreation.GetPlayerCharacter().GetIntelligenceModifier(),
                                           CharacterCreation.GetEnemies()[target].GetIntelligence(),
                                           CharacterCreation.GetEnemies()[target].GetIntelligenceModifier(),
                                           Combat.GetPlayerWisdomSuccess(),
                                           CharacterCreation.GetEnemies()[target].GetConstitution(),
                                           target);

            if (CharacterCreation.GetEnemies()[target].GetHealth() > 1000)
            {
                CharacterCreation.GetEnemies()[target] = new Character(0, Character.Type.zombie, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                enemiesActive--;
            }

            if (target == 0) txtEnemyHealthLeft.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();
            if (target == 1) txtEnemyHealthCenter.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();
            if (target == 2) txtEnemyHealthRight.Text = CharacterCreation.GetEnemies()[target].GetHealth().ToString();

            if (enemiesActive == 0)
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

            if (enemiesActive != 0)
            {
                for (uint i = 0; i < enemiesActive; i++)
                    CharacterActions.GetEnemyAttack(CharacterCreation.GetEnemies()[i].GetIntelligence(),
                                                    CharacterCreation.GetPlayerCharacter().GetIntelligence(),
                                                    CharacterCreation.GetEnemies()[i].GetIntelligenceModifier(),
                                                    CharacterCreation.GetPlayerCharacter().GetConstitution(),
                                                    i);
            }

            if (CharacterCreation.GetPlayerCharacter().GetHealth() > 1000) CharacterCreation.KillPlayer();

            if (CharacterCreation.GetPlayerExists() == false)
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

                txtDisplayPlayerHealth.Text = CharacterCreation.GetPlayerCharacter().GetHealth().ToString();
                txtDisplayWisdomSuccess.Text = Combat.GetPlayerWisdomSuccess().ToString();
            }

        }

        private void RollWisdom_Click(object sender, EventArgs e)
        {
            Combat.SetWisdomActive(true);

            if (enemiesActive != 0)
            {
                for (uint i = 0; i < enemiesActive; i++)
                    CharacterActions.GetEnemyAttack(CharacterCreation.GetEnemies()[i].GetStrength(),
                                                    CharacterCreation.GetEnemies()[i].GetStrengthModifier(),
                                                    CharacterCreation.GetPlayerCharacter().GetStrength(),
                                                    CharacterCreation.GetPlayerCharacter().GetConstitution(),
                                                    i);
            }

            Combat.SetWisdomActive(false);

            if (reveals[0] == true)
            {
                txtEnemyStrengthLeft.Text = CharacterCreation.GetEnemies()[0].GetStrength().ToString();
                txtEnemyStrengthModifierLeft.Text = CharacterCreation.GetEnemies()[0].GetStrengthModifier().ToString();
                txtEnemyDexterityLeft.Text = CharacterCreation.GetEnemies()[0].GetDexterity().ToString();
                txtEnemyDexterityModifierLeft.Text = CharacterCreation.GetEnemies()[0].GetDexterityModifier().ToString();
                txtEnemyIntelligenceLeft.Text = CharacterCreation.GetEnemies()[0].GetIntelligence().ToString();
                txtEnemyIntelligenceModifierLeft.Text = CharacterCreation.GetEnemies()[0].GetIntelligenceModifier().ToString();
                txtEnemyConstitutionLeft.Text = CharacterCreation.GetEnemies()[0].GetConstitution().ToString();
                txtEnemyConstitutionModifierLeft.Text = CharacterCreation.GetEnemies()[0].GetConstitutionModifier().ToString();
                txtEnemyWisdomLeft.Text = CharacterCreation.GetEnemies()[0].GetWisdom().ToString();
                txtEnemyWisdomModifierLeft.Text = CharacterCreation.GetEnemies()[0].GetWisdomModifier().ToString();
                txtEnemyCharismaLeft.Text = CharacterCreation.GetEnemies()[0].GetCharisma().ToString();
                txtEnemyCharismaModifierLeft.Text = CharacterCreation.GetEnemies()[0].GetCharismaModifier().ToString();
            }
            if (reveals[1] == true)
            {
                txtEnemyStrengthCenter.Text = CharacterCreation.GetEnemies()[1].GetStrength().ToString();
                txtEnemyStrengthModifierCenter.Text = CharacterCreation.GetEnemies()[1].GetStrengthModifier().ToString();
                txtEnemyDexterityCenter.Text = CharacterCreation.GetEnemies()[1].GetDexterity().ToString();
                txtEnemyDexterityModifierCenter.Text = CharacterCreation.GetEnemies()[1].GetDexterityModifier().ToString();
                txtEnemyIntelligenceCenter.Text = CharacterCreation.GetEnemies()[1].GetIntelligence().ToString();
                txtEnemyIntelligenceModifierCenter.Text = CharacterCreation.GetEnemies()[1].GetIntelligenceModifier().ToString();
                txtEnemyConstitutionCenter.Text = CharacterCreation.GetEnemies()[1].GetConstitution().ToString();
                txtEnemyConstitutionModifierCenter.Text = CharacterCreation.GetEnemies()[1].GetConstitutionModifier().ToString();
                txtEnemyWisdomCenter.Text = CharacterCreation.GetEnemies()[1].GetWisdom().ToString();
                txtEnemyWisdomModifierCenter.Text = CharacterCreation.GetEnemies()[1].GetWisdomModifier().ToString();
                txtEnemyCharismaCenter.Text = CharacterCreation.GetEnemies()[1].GetCharisma().ToString();
                txtEnemyCharismaModifierCenter.Text = CharacterCreation.GetEnemies()[1].GetCharismaModifier().ToString();
            }
            if (reveals[2] == true)
            {
                txtEnemyStrengthRight.Text = CharacterCreation.GetEnemies()[2].GetStrength().ToString();
                txtEnemyStrengthModifierRight.Text = CharacterCreation.GetEnemies()[2].GetStrengthModifier().ToString();
                txtEnemyDexterityRight.Text = CharacterCreation.GetEnemies()[2].GetDexterity().ToString();
                txtEnemyDexterityModifierRight.Text = CharacterCreation.GetEnemies()[2].GetDexterityModifier().ToString();
                txtEnemyIntelligenceRight.Text = CharacterCreation.GetEnemies()[2].GetIntelligence().ToString();
                txtEnemyIntelligenceModifierRight.Text = CharacterCreation.GetEnemies()[2].GetIntelligenceModifier().ToString();
                txtEnemyConstitutionRight.Text = CharacterCreation.GetEnemies()[2].GetConstitution().ToString();
                txtEnemyConstitutionModifierRight.Text = CharacterCreation.GetEnemies()[2].GetConstitutionModifier().ToString();
                txtEnemyWisdomRight.Text = CharacterCreation.GetEnemies()[2].GetWisdom().ToString();
                txtEnemyWisdomModifierRight.Text = CharacterCreation.GetEnemies()[2].GetWisdomModifier().ToString();
                txtEnemyCharismaRight.Text = CharacterCreation.GetEnemies()[2].GetCharisma().ToString();
                txtEnemyCharismaModifierRight.Text = CharacterCreation.GetEnemies()[2].GetCharismaModifier().ToString();
            }

            txtDisplayPlayerHealth.Text = CharacterCreation.GetPlayerCharacter().GetHealth().ToString();
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