using System;

namespace TheCoolestSafe
{
    public partial class Form1 : Form
    {
        int numGuesses = 10;
        bool winGame = false;

        int firstValue;
        int secondValue;
        int thirdValue;

        int firstGuess;
        int secondGuess;
        int thirdGuess;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            GenerateCode();
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            if (firstPlayerNumber.Text != "" &&
                secondPlayerNumber.Text != "" &&
                thirdPlayerNumber.Text != "")
            {
                displayGameOver.Text = "";
                numGuesses--;
                DisplayGuesses.Text = "Guesses Remaining: " + numGuesses.ToString();
                int numCorrectValues = 0;

                firstGuess = int.Parse(firstPlayerNumber.Text);
                secondGuess = int.Parse(secondPlayerNumber.Text);
                thirdGuess = int.Parse(thirdPlayerNumber.Text);

                if (firstGuess == firstValue) numCorrectValues++;

                if (secondGuess == secondValue) numCorrectValues++;

                if (thirdGuess == thirdValue) numCorrectValues++;

                if (howClose1.Text != null)
                {
                    howClose2.Text = howClose1.Text;

                    secondPrevious1.Text = firstPrevious1.Text;
                    secondPrevious2.Text = firstPrevious2.Text;
                    secondPrevious3.Text = firstPrevious3.Text;

                    firstPrevious1.Text = firstPlayerNumber.Text;
                    firstPrevious2.Text = secondPlayerNumber.Text;
                    firstPrevious3.Text = thirdPlayerNumber.Text;
                }

                switch (numCorrectValues)
                {

                    case 0: // Cold
                        howClose1.Text = "Cold";
                        break;
                    case 1: // Warm
                        howClose1.Text = "Warm";
                        break;
                    case 2: // Hot
                        howClose1.Text = "Hot";
                        // change image here
                        currentImage.Image = new Bitmap("../../../SafeImages/SlightlyOpenSafe.jpg");
                        break;
                    case 3: // AHHHHHHH!(Correct)
                        howClose1.Text = "AHHHHHHH";
                        // change image here
                        currentImage.Image = new Bitmap("OpenSafe.jpg");
                        winGame = true;
                        break;
                    default: // Game Breaks
                        howClose1.Text = "numCorrectValues has exceeded legal value range!";
                        break;
                }

                if (winGame == true && numGuesses >= 0)
                {
                    displayGameOver.Text = "You cracked the code!";
                }
                else if (winGame == false && numGuesses <= 0)
                {
                    checkGuess.Enabled = false;
                    DisplayGuesses.Text = "Guesses Remaining: 0";
                    displayGameOver.Text = "You failed to cracked the code!";
                }

            }
            else
            {
                displayGameOver.Text = "Guesses cannot be empty!";
            }
        }

        private void Cheat_Click(object sender, EventArgs e)
        {
            displayCorrectCode.Text = "Code: " + firstValue.ToString() + secondValue.ToString() + thirdValue.ToString();
        }

        private void GenerateCode()
        {
            firstValue = random.Next(1, 9);
            secondValue = random.Next(1, 9);
            thirdValue = random.Next(1, 9);
        }

        private void displayPreviousGuesses_Enter(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            checkGuess.Enabled = true;

            firstValue = random.Next(1, 9);
            secondValue = random.Next(1, 9);
            thirdValue = random.Next(1, 9);

            displayCorrectCode.Text = "";

            numGuesses = 10;
            winGame = false;

            howClose1.Text = "";
            howClose2.Text = "";

            firstPrevious1.Text = "";
            firstPrevious2.Text = "";
            firstPrevious3.Text = "";

            secondPrevious1.Text = "";
            secondPrevious2.Text = "";
            secondPrevious3.Text = "";

            firstPlayerNumber.Text = "";
            secondPlayerNumber.Text = "";
            thirdPlayerNumber.Text = "";

            displayGameOver.Text = "";
            DisplayGuesses.Text = "Guesses Remaining: " + numGuesses.ToString();

        }

        //TODO: Get images for program

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firstPlayerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}