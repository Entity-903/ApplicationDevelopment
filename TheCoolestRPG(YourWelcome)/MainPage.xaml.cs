using TheCoolestRPG.GameLogic.Character;
using TheCoolestRPG_YourWelcome_.Additional_UI;

namespace TheCoolestRPG_YourWelcome_
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCustomCreate(object sender, EventArgs e)
        {
            uint strength             = (uint)(int.Parse(txtStrength.Text));
            uint dexterity            = (uint)(int.Parse(txtDexterity.Text));
            uint intelligence         = (uint)(int.Parse(txtIntelligence.Text));
            uint constitution         = (uint)(int.Parse(txtConstitution.Text));
            uint wisdom               = (uint)(int.Parse(txtWisdom.Text));
            uint charisma             = (uint)(int.Parse(txtCharisma.Text));

            uint strengthModifier     = (uint)((strength) * 0.25f);
            uint dexterityModifier    = (uint)((dexterity) * 0.25f);
            uint intelligenceModifier = (uint)((intelligence) * 0.25f);
            uint constitutionModifier = (uint)((constitution) * 0.25f);
            uint wisdomModifier       = (uint)((wisdom) * 0.25f);
            uint charismaModifier     = (uint)((charisma) * 0.25f);

            Character.SetPlayerExists(true, new Character(10 * constitution, Character.Type.custom, strength, strengthModifier, dexterity, dexterityModifier, intelligence, intelligenceModifier, constitution, constitutionModifier, wisdom, wisdomModifier, charisma, charismaModifier));

            uint zombieStrength = 13;
            uint zombieDexterity = 8;
            uint zombieIntelligence = 7;
            uint zombieConstitution = 10;
            uint zombieWisdom = 1;
            uint zombieCharisma = 0;

            uint zombieStrengthModifier = (uint)((zombieStrength) * 0.25f);
            uint zombieDexterityModifier = (uint)((zombieDexterity) * 0.25f);
            uint zombieIntelligenceModifier = (uint)((zombieIntelligence) * 0.25f);
            uint zombieConstitutionModifier = (uint)((zombieConstitution) * 0.25f);
            uint zombieWisdomModifier = (uint)((zombieWisdom) * 0.25f);
            uint zombieCharismaModifier = (uint)((zombieCharisma) * 0.25f);

            Character.SetEnemies(new Character(10 * zombieConstitution, Character.Type.zombie, zombieStrength, zombieStrengthModifier, zombieDexterity, zombieDexterityModifier, zombieIntelligence, zombieIntelligenceModifier, zombieConstitution, zombieConstitutionModifier, zombieWisdom, zombieWisdomModifier, zombieCharisma, zombieCharismaModifier));

            Application.Current.OpenWindow(new Window(new DialogueUI()));
            Application.Current.CloseWindow(Window);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char character in e.NewTextValue)
            {
                if (!char.IsDigit(character))
                {
                    ((Entry)sender).Text = e.OldTextValue;
                    return;
                }
            }

            //if ((Entry)sender.Text == "")
            if (int.Parse(((Entry)sender).Text) > 20) 
            {
                ((Entry)sender).Text = 20.ToString(); 
            }
        }
    }
}