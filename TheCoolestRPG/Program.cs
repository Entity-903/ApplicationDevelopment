using System.Media;
using TheCoolestRPG.GameLogic.Story;
using TheCoolestRPG.UI;

namespace TheCoolestRPG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // How we open new instances of forms
            // Next form opens when the previous one closes

            Application.Run(new CharacterCreation());

            // Opens once CreateCharacterUI is closed and player != null
            if (CharacterCreation.GetPlayerExists()) Application.Run(new DialogueUI());

            // Opens once DialogueUI is closed and initializeFight is true
            if (Story.GetInitalizeFight()) Application.Run(new CombatUI());

        }

    }
}