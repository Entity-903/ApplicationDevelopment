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
        }

        uint target = 0;

        private void RollStrength_Click(object sender, EventArgs e)
        {
            CharacterActions.GetAttackRoll(CharacterCreation.GetPlayerCharacter().getStrength(),
                                           CharacterCreation.GetPlayerCharacter().getStrengthModifier(),
                                           CharacterCreation.GetEnemies()[target].getStrength(),
                                           CharacterCreation.GetEnemies()[target].getStrengthModifier(),
                                           Combat.GetPlayerWisdomSuccess(),
                                           CharacterCreation.GetEnemies()[target].getConstitution(),
                                           target);
        }

        private void RollDexterity_Click(object sender, EventArgs e)
        {
            CharacterActions.GetAttackRoll(CharacterCreation.GetPlayerCharacter().getDexterity(),
                               CharacterCreation.GetPlayerCharacter().getDexterityModifier(),
                               CharacterCreation.GetEnemies()[target].getDexterity(),
                               CharacterCreation.GetEnemies()[target].getDexterityModifier(),
                               Combat.GetPlayerWisdomSuccess(),
                               CharacterCreation.GetEnemies()[target].getConstitution(),
                               target);
        }

        private void RollIntelligence_Click(object sender, EventArgs e)
        {
            CharacterActions.GetAttackRoll(CharacterCreation.GetPlayerCharacter().getIntelligence(),
                               CharacterCreation.GetPlayerCharacter().getIntelligenceModifier(),
                               CharacterCreation.GetEnemies()[target].getIntelligence(),
                               CharacterCreation.GetEnemies()[target].getIntelligenceModifier(),
                               Combat.GetPlayerWisdomSuccess(),
                               CharacterCreation.GetEnemies()[target].getConstitution(),
                               target);
        }

        private void RollWisdom_Click(object sender, EventArgs e)
        {
            Combat.SetWisdomActive(true);

            //CharacterActions.GetWisdomSuccess(CharacterCreation.GetPlayerCharacter().getWisdom(), CharacterCreation.GetPlayerCharacter().getWisdomModifier());
        }

        private void RollCharisma_Click(object sender, EventArgs e)
        {

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


    // if (health == 0)
    //{
    //  enemies[wherever this enemy is in array] = null;
    //}
}