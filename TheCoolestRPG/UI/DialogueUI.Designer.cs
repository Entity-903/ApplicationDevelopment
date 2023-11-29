namespace TheCoolestRPG
{
    partial class DialogueUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtCurrentDialogue = new TextBox();
            DialogueOptions = new GroupBox();
            btnContinue = new Button();
            DialogueOptions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(410, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CharacterImageGoesHere";
            // 
            // txtCurrentDialogue
            // 
            txtCurrentDialogue.Enabled = false;
            txtCurrentDialogue.Location = new Point(243, 373);
            txtCurrentDialogue.Multiline = true;
            txtCurrentDialogue.Name = "txtCurrentDialogue";
            txtCurrentDialogue.Size = new Size(694, 150);
            txtCurrentDialogue.TabIndex = 0;
            txtCurrentDialogue.Text = "Sample Dialogue";
            txtCurrentDialogue.TextAlign = HorizontalAlignment.Center;
            // 
            // DialogueOptions
            // 
            DialogueOptions.Controls.Add(btnContinue);
            DialogueOptions.Location = new Point(157, 529);
            DialogueOptions.Name = "DialogueOptions";
            DialogueOptions.Size = new Size(858, 150);
            DialogueOptions.TabIndex = 2;
            DialogueOptions.TabStop = false;
            DialogueOptions.Text = "DialogueOptionsGoHere";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(305, 83);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(249, 61);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // DialogueUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 776);
            Controls.Add(txtCurrentDialogue);
            Controls.Add(DialogueOptions);
            Controls.Add(groupBox1);
            Name = "DialogueUI";
            Text = "Dialogue";
            DialogueOptions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox DialogueOptions;
        private Button btnContinue;
        private TextBox txtCurrentDialogue;
        private Label CurrentDialogueText;
    }
}