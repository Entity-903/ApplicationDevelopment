namespace TheCoolestRPG
{
    public partial class CombatUI : Form
    {
        public CombatUI()
        {
            InitializeComponent();
        }
    }
    // Call game functions from this class

    // Use enum to track enemy positions in an array

    // Combat Form

    // Dialogue Form

    // Character Creation Form

    /* What if, to determine which character acted first, we implemented the following:
     * Each character had a value attackSpeed = 10;
     * Each character had a value statusEffect = 1;
     * The character's attack speed would be calculated by attackSpeed + (dexterity + dexterityModifier) * statusEffect;
     * attackSpeed represents the time it takes for the character to attack again
     * Therefore, characters with the highest attack speed would attack first
     * If an enemy and player share the same attackSpeed, the player acts first
     * If two or more enemies share the same attackSpeed, the order of such enemies goes from left to right (in the array, if we ever implemement an array).
    */

    // if (health == 0)
    //{
    //  enemies[wherever this enemy is in array] = null;
    //}
}