using System.Media;

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

            Application.Run(new CreateCharacterUI());

            Application.Run(new Dialogue());
        }

    }
}