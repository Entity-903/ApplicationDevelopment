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
            btnCombatStart = new Button();
            btnConfirm = new Button();
            btnDeny = new Button();
            btnContinue = new Button();
            btnAvoid = new Button();
            btnApproach = new Button();
            btnRecall = new Button();
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
            txtCurrentDialogue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCurrentDialogue.Location = new Point(243, 373);
            txtCurrentDialogue.Multiline = true;
            txtCurrentDialogue.Name = "txtCurrentDialogue";
            txtCurrentDialogue.Size = new Size(694, 150);
            txtCurrentDialogue.TabIndex = 0;
            txtCurrentDialogue.Text = "Start with Path(0)[0]";
            txtCurrentDialogue.TextAlign = HorizontalAlignment.Center;
            // 
            // DialogueOptions
            // 
            DialogueOptions.Controls.Add(btnCombatStart);
            DialogueOptions.Controls.Add(btnConfirm);
            DialogueOptions.Controls.Add(btnDeny);
            DialogueOptions.Controls.Add(btnContinue);
            DialogueOptions.Controls.Add(btnAvoid);
            DialogueOptions.Controls.Add(btnApproach);
            DialogueOptions.Controls.Add(btnRecall);
            DialogueOptions.Location = new Point(157, 529);
            DialogueOptions.Name = "DialogueOptions";
            DialogueOptions.Size = new Size(858, 150);
            DialogueOptions.TabIndex = 2;
            DialogueOptions.TabStop = false;
            DialogueOptions.Text = "DialogueOptionsGoHere";
            // 
            // btnCombatStart
            // 
            btnCombatStart.Location = new Point(305, 83);
            btnCombatStart.Name = "btnCombatStart";
            btnCombatStart.Size = new Size(261, 61);
            btnCombatStart.TabIndex = 3;
            btnCombatStart.Text = "Fight";
            btnCombatStart.UseVisualStyleBackColor = true;
            btnCombatStart.Visible = false;
            btnCombatStart.Click += btnCombatStart_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(172, 83);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(261, 61);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Visible = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(439, 83);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(261, 61);
            btnDeny.TabIndex = 7;
            btnDeny.Text = "Deny (Charisma)";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Visible = false;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(305, 83);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(261, 61);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnAvoid
            // 
            btnAvoid.Location = new Point(439, 83);
            btnAvoid.Name = "btnAvoid";
            btnAvoid.Size = new Size(261, 61);
            btnAvoid.TabIndex = 4;
            btnAvoid.Text = "Avoid";
            btnAvoid.UseVisualStyleBackColor = true;
            btnAvoid.Visible = false;
            btnAvoid.Click += btnAvoid_Click;
            // 
            // btnApproach
            // 
            btnApproach.Location = new Point(172, 83);
            btnApproach.Name = "btnApproach";
            btnApproach.Size = new Size(261, 61);
            btnApproach.TabIndex = 3;
            btnApproach.Text = "Approach";
            btnApproach.UseVisualStyleBackColor = true;
            btnApproach.Visible = false;
            btnApproach.Click += btnApproach_Click;
            // 
            // btnRecall
            // 
            btnRecall.Location = new Point(305, 16);
            btnRecall.Name = "btnRecall";
            btnRecall.Size = new Size(261, 61);
            btnRecall.TabIndex = 5;
            btnRecall.Text = "Recall (Wisdom)";
            btnRecall.UseVisualStyleBackColor = true;
            btnRecall.Visible = false;
            btnRecall.Click += btnCheckFamiliarity_Click;
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
        private Button btnApproach;
        private Button btnAvoid;
        private Button btnRecall;
        private Button btnConfirm;
        private Button btnDeny;
        private Button btnCombatStart;
    }
}