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