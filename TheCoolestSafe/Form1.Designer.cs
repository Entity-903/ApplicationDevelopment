namespace TheCoolestSafe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            utilizeCheat = new Button();
            checkGuess = new Button();
            firstPrevious1 = new TextBox();
            label1 = new Label();
            firstPrevious2 = new TextBox();
            firstPrevious3 = new TextBox();
            secondPrevious3 = new TextBox();
            secondPrevious2 = new TextBox();
            secondPrevious1 = new TextBox();
            label2 = new Label();
            thirdPlayerNumber = new TextBox();
            secondPlayerNumber = new TextBox();
            firstPlayerNumber = new TextBox();
            displayCorrectCode = new Label();
            howClose1 = new Label();
            howClose2 = new Label();
            displayGameOver = new Label();
            displayPreviousGuesses = new GroupBox();
            NewGame = new Button();
            ExitGame = new Button();
            DisplayGuesses = new Label();
            currentImage = new PictureBox();
            displayPreviousGuesses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentImage).BeginInit();
            SuspendLayout();
            // 
            // utilizeCheat
            // 
            utilizeCheat.Location = new Point(50, 404);
            utilizeCheat.Name = "utilizeCheat";
            utilizeCheat.Size = new Size(112, 34);
            utilizeCheat.TabIndex = 3;
            utilizeCheat.Text = "Cheat";
            utilizeCheat.UseVisualStyleBackColor = true;
            utilizeCheat.Click += Cheat_Click;
            // 
            // checkGuess
            // 
            checkGuess.Location = new Point(638, 404);
            checkGuess.Name = "checkGuess";
            checkGuess.Size = new Size(112, 34);
            checkGuess.TabIndex = 4;
            checkGuess.Text = "Guess";
            checkGuess.UseVisualStyleBackColor = true;
            checkGuess.Click += Guess_Click;
            // 
            // firstPrevious1
            // 
            firstPrevious1.Location = new Point(172, 24);
            firstPrevious1.MaxLength = 3;
            firstPrevious1.Name = "firstPrevious1";
            firstPrevious1.Size = new Size(33, 31);
            firstPrevious1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 6;
            label1.Text = "1st Previous Guess:";
            // 
            // firstPrevious2
            // 
            firstPrevious2.Location = new Point(211, 24);
            firstPrevious2.MaxLength = 3;
            firstPrevious2.Name = "firstPrevious2";
            firstPrevious2.Size = new Size(33, 31);
            firstPrevious2.TabIndex = 7;
            // 
            // firstPrevious3
            // 
            firstPrevious3.Location = new Point(250, 24);
            firstPrevious3.MaxLength = 3;
            firstPrevious3.Name = "firstPrevious3";
            firstPrevious3.Size = new Size(33, 31);
            firstPrevious3.TabIndex = 8;
            // 
            // secondPrevious3
            // 
            secondPrevious3.Location = new Point(250, 61);
            secondPrevious3.MaxLength = 3;
            secondPrevious3.Name = "secondPrevious3";
            secondPrevious3.Size = new Size(33, 31);
            secondPrevious3.TabIndex = 9;
            // 
            // secondPrevious2
            // 
            secondPrevious2.Location = new Point(211, 61);
            secondPrevious2.MaxLength = 3;
            secondPrevious2.Name = "secondPrevious2";
            secondPrevious2.Size = new Size(33, 31);
            secondPrevious2.TabIndex = 10;
            // 
            // secondPrevious1
            // 
            secondPrevious1.Location = new Point(172, 61);
            secondPrevious1.MaxLength = 3;
            secondPrevious1.Name = "secondPrevious1";
            secondPrevious1.Size = new Size(33, 31);
            secondPrevious1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 61);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 12;
            label2.Text = "2nd Previous Guess:";
            // 
            // thirdPlayerNumber
            // 
            thirdPlayerNumber.Location = new Point(717, 367);
            thirdPlayerNumber.MaxLength = 1;
            thirdPlayerNumber.Name = "thirdPlayerNumber";
            thirdPlayerNumber.Size = new Size(33, 31);
            thirdPlayerNumber.TabIndex = 13;
            // 
            // secondPlayerNumber
            // 
            secondPlayerNumber.Location = new Point(678, 367);
            secondPlayerNumber.MaxLength = 1;
            secondPlayerNumber.Name = "secondPlayerNumber";
            secondPlayerNumber.Size = new Size(33, 31);
            secondPlayerNumber.TabIndex = 14;
            // 
            // firstPlayerNumber
            // 
            firstPlayerNumber.Location = new Point(639, 367);
            firstPlayerNumber.MaxLength = 1;
            firstPlayerNumber.Name = "firstPlayerNumber";
            firstPlayerNumber.Size = new Size(33, 31);
            firstPlayerNumber.TabIndex = 15;
            firstPlayerNumber.KeyPress += firstPlayerNumber_KeyPress;
            // 
            // displayCorrectCode
            // 
            displayCorrectCode.AutoSize = true;
            displayCorrectCode.Location = new Point(59, 367);
            displayCorrectCode.Name = "displayCorrectCode";
            displayCorrectCode.Size = new Size(0, 25);
            displayCorrectCode.TabIndex = 16;
            // 
            // howClose1
            // 
            howClose1.AutoSize = true;
            howClose1.Location = new Point(289, 27);
            howClose1.Name = "howClose1";
            howClose1.Size = new Size(0, 25);
            howClose1.TabIndex = 17;
            // 
            // howClose2
            // 
            howClose2.AutoSize = true;
            howClose2.Location = new Point(289, 64);
            howClose2.Name = "howClose2";
            howClose2.Size = new Size(0, 25);
            howClose2.TabIndex = 18;
            // 
            // displayGameOver
            // 
            displayGameOver.AutoSize = true;
            displayGameOver.Location = new Point(304, 409);
            displayGameOver.Name = "displayGameOver";
            displayGameOver.Size = new Size(0, 25);
            displayGameOver.TabIndex = 19;
            // 
            // displayPreviousGuesses
            // 
            displayPreviousGuesses.Controls.Add(label1);
            displayPreviousGuesses.Controls.Add(firstPrevious1);
            displayPreviousGuesses.Controls.Add(howClose2);
            displayPreviousGuesses.Controls.Add(firstPrevious2);
            displayPreviousGuesses.Controls.Add(howClose1);
            displayPreviousGuesses.Controls.Add(firstPrevious3);
            displayPreviousGuesses.Controls.Add(secondPrevious3);
            displayPreviousGuesses.Controls.Add(secondPrevious2);
            displayPreviousGuesses.Controls.Add(secondPrevious1);
            displayPreviousGuesses.Controls.Add(label2);
            displayPreviousGuesses.Location = new Point(213, 12);
            displayPreviousGuesses.Name = "displayPreviousGuesses";
            displayPreviousGuesses.Size = new Size(415, 100);
            displayPreviousGuesses.TabIndex = 20;
            displayPreviousGuesses.TabStop = false;
            displayPreviousGuesses.Text = "PreviousGuesses";
            // 
            // NewGame
            // 
            NewGame.Location = new Point(676, 12);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(112, 34);
            NewGame.TabIndex = 21;
            NewGame.Text = "New Game";
            NewGame.UseVisualStyleBackColor = true;
            NewGame.Click += NewGame_Click;
            // 
            // ExitGame
            // 
            ExitGame.Location = new Point(676, 52);
            ExitGame.Name = "ExitGame";
            ExitGame.Size = new Size(112, 34);
            ExitGame.TabIndex = 22;
            ExitGame.Text = "Exit Game";
            ExitGame.UseVisualStyleBackColor = true;
            ExitGame.Click += ExitGame_Click;
            // 
            // DisplayGuesses
            // 
            DisplayGuesses.AutoSize = true;
            DisplayGuesses.Location = new Point(2, 42);
            DisplayGuesses.Name = "DisplayGuesses";
            DisplayGuesses.Size = new Size(193, 25);
            DisplayGuesses.TabIndex = 23;
            DisplayGuesses.Text = "Guesses Remaining: 10";
            // 
            // currentImage
            // 
            currentImage.Image = Properties.Resources.ClosedSafe;
            currentImage.ImageLocation = "";
            currentImage.Location = new Point(212, 118);
            currentImage.Name = "currentImage";
            currentImage.Size = new Size(416, 246);
            currentImage.SizeMode = PictureBoxSizeMode.Zoom;
            currentImage.TabIndex = 24;
            currentImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currentImage);
            Controls.Add(DisplayGuesses);
            Controls.Add(ExitGame);
            Controls.Add(NewGame);
            Controls.Add(displayPreviousGuesses);
            Controls.Add(displayGameOver);
            Controls.Add(displayCorrectCode);
            Controls.Add(firstPlayerNumber);
            Controls.Add(secondPlayerNumber);
            Controls.Add(thirdPlayerNumber);
            Controls.Add(checkGuess);
            Controls.Add(utilizeCheat);
            Name = "Form1";
            Text = "Open The Safe!";
            displayPreviousGuesses.ResumeLayout(false);
            displayPreviousGuesses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstPlayerNumber;
        private TextBox secondPlayerNumber;
        private TextBox thirdPlayerNumber;
        private Button utilizeCheat;
        private Button checkGuess;
        private TextBox firstPrevious1;
        private Label label1;
        private TextBox firstPrevious2;
        private TextBox firstPrevious3;
        private TextBox secondPrevious3;
        private TextBox secondPrevious2;
        private TextBox secondPrevious1;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label3;
        private Label displayCorrectCode;
        private Label howClose1;
        private Label howClose2;
        private Label displayGameOver;
        private GroupBox displayPreviousGuesses;
        private Button NewGame;
        private Button ExitGame;
        private Label DisplayGuesses;
        private PictureBox currentImage;
    }
}