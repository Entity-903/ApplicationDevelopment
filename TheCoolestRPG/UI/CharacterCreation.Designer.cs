namespace TheCoolestRPG
{
    partial class CreateCharacterUI
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
            numericStrength = new NumericUpDown();
            numericCharisma = new NumericUpDown();
            numericWisdom = new NumericUpDown();
            numericConstitution = new NumericUpDown();
            numericIntelligence = new NumericUpDown();
            numericDexterity = new NumericUpDown();
            label1 = new Label();
            labelCharisma = new Label();
            labelWisdom = new Label();
            labelConstitution = new Label();
            labelIntelligence = new Label();
            labelDexterity = new Label();
            labelStrength = new Label();
            btnCustomCreate = new Button();
            labelStrengthModifier = new Label();
            labelCharismaModifier = new Label();
            labelWisdomModifier = new Label();
            labelConstitutionModifier = new Label();
            labelIntelligenceModifier = new Label();
            labelDexterityModifier = new Label();
            ((System.ComponentModel.ISupportInitialize)numericStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCharisma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWisdom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericConstitution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIntelligence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDexterity).BeginInit();
            SuspendLayout();
            // 
            // numericStrength
            // 
            numericStrength.Location = new Point(134, 55);
            numericStrength.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericStrength.Name = "numericStrength";
            numericStrength.Size = new Size(51, 31);
            numericStrength.TabIndex = 0;
            numericStrength.TextAlign = HorizontalAlignment.Center;
            numericStrength.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericStrength.ValueChanged += numericStrength_ValueChanged;
            // 
            // numericCharisma
            // 
            numericCharisma.Location = new Point(134, 242);
            numericCharisma.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericCharisma.Name = "numericCharisma";
            numericCharisma.Size = new Size(51, 31);
            numericCharisma.TabIndex = 1;
            numericCharisma.TextAlign = HorizontalAlignment.Center;
            numericCharisma.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericCharisma.ValueChanged += numericCharisma_ValueChanged;
            // 
            // numericWisdom
            // 
            numericWisdom.Location = new Point(134, 205);
            numericWisdom.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericWisdom.Name = "numericWisdom";
            numericWisdom.Size = new Size(51, 31);
            numericWisdom.TabIndex = 2;
            numericWisdom.TextAlign = HorizontalAlignment.Center;
            numericWisdom.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericWisdom.ValueChanged += numericWisdom_ValueChanged;
            // 
            // numericConstitution
            // 
            numericConstitution.Location = new Point(134, 168);
            numericConstitution.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericConstitution.Name = "numericConstitution";
            numericConstitution.Size = new Size(51, 31);
            numericConstitution.TabIndex = 3;
            numericConstitution.TextAlign = HorizontalAlignment.Center;
            numericConstitution.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericConstitution.ValueChanged += numericConstitution_ValueChanged;
            // 
            // numericIntelligence
            // 
            numericIntelligence.Location = new Point(134, 131);
            numericIntelligence.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericIntelligence.Name = "numericIntelligence";
            numericIntelligence.Size = new Size(51, 31);
            numericIntelligence.TabIndex = 4;
            numericIntelligence.TextAlign = HorizontalAlignment.Center;
            numericIntelligence.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericIntelligence.ValueChanged += numericIntelligence_ValueChanged;
            // 
            // numericDexterity
            // 
            numericDexterity.Location = new Point(134, 94);
            numericDexterity.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericDexterity.Name = "numericDexterity";
            numericDexterity.Size = new Size(51, 31);
            numericDexterity.TabIndex = 5;
            numericDexterity.TextAlign = HorizontalAlignment.Center;
            numericDexterity.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericDexterity.ValueChanged += numericDexterity_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 6;
            label1.Text = "Custom Character";
            // 
            // labelCharisma
            // 
            labelCharisma.AutoSize = true;
            labelCharisma.Location = new Point(12, 244);
            labelCharisma.Name = "labelCharisma";
            labelCharisma.Size = new Size(89, 25);
            labelCharisma.TabIndex = 7;
            labelCharisma.Text = "Charisma:";
            // 
            // labelWisdom
            // 
            labelWisdom.AutoSize = true;
            labelWisdom.Location = new Point(12, 207);
            labelWisdom.Name = "labelWisdom";
            labelWisdom.Size = new Size(83, 25);
            labelWisdom.TabIndex = 8;
            labelWisdom.Text = "Wisdom:";
            // 
            // labelConstitution
            // 
            labelConstitution.AutoSize = true;
            labelConstitution.Location = new Point(12, 170);
            labelConstitution.Name = "labelConstitution";
            labelConstitution.Size = new Size(113, 25);
            labelConstitution.TabIndex = 9;
            labelConstitution.Text = "Constitution:";
            // 
            // labelIntelligence
            // 
            labelIntelligence.AutoSize = true;
            labelIntelligence.Location = new Point(12, 133);
            labelIntelligence.Name = "labelIntelligence";
            labelIntelligence.Size = new Size(105, 25);
            labelIntelligence.TabIndex = 10;
            labelIntelligence.Text = "Intelligence:";
            // 
            // labelDexterity
            // 
            labelDexterity.AutoSize = true;
            labelDexterity.Location = new Point(12, 96);
            labelDexterity.Name = "labelDexterity";
            labelDexterity.Size = new Size(86, 25);
            labelDexterity.TabIndex = 11;
            labelDexterity.Text = "Dexterity:";
            // 
            // labelStrength
            // 
            labelStrength.AutoSize = true;
            labelStrength.Location = new Point(12, 57);
            labelStrength.Name = "labelStrength";
            labelStrength.Size = new Size(83, 25);
            labelStrength.TabIndex = 12;
            labelStrength.Text = "Strength:";
            // 
            // btnCustomCreate
            // 
            btnCustomCreate.Location = new Point(12, 279);
            btnCustomCreate.Name = "btnCustomCreate";
            btnCustomCreate.Size = new Size(202, 34);
            btnCustomCreate.TabIndex = 13;
            btnCustomCreate.Text = "Create Void Entity";
            btnCustomCreate.UseVisualStyleBackColor = true;
            btnCustomCreate.Click += btnCustomCreate_Click;
            // 
            // labelStrengthModifier
            // 
            labelStrengthModifier.AutoSize = true;
            labelStrengthModifier.Location = new Point(191, 57);
            labelStrengthModifier.Name = "labelStrengthModifier";
            labelStrengthModifier.Size = new Size(34, 25);
            labelStrengthModifier.TabIndex = 14;
            labelStrengthModifier.Text = "+2";
            // 
            // labelCharismaModifier
            // 
            labelCharismaModifier.AutoSize = true;
            labelCharismaModifier.Location = new Point(191, 244);
            labelCharismaModifier.Name = "labelCharismaModifier";
            labelCharismaModifier.Size = new Size(34, 25);
            labelCharismaModifier.TabIndex = 15;
            labelCharismaModifier.Text = "+2";
            // 
            // labelWisdomModifier
            // 
            labelWisdomModifier.AutoSize = true;
            labelWisdomModifier.Location = new Point(191, 207);
            labelWisdomModifier.Name = "labelWisdomModifier";
            labelWisdomModifier.Size = new Size(34, 25);
            labelWisdomModifier.TabIndex = 16;
            labelWisdomModifier.Text = "+2";
            // 
            // labelConstitutionModifier
            // 
            labelConstitutionModifier.AutoSize = true;
            labelConstitutionModifier.Location = new Point(191, 170);
            labelConstitutionModifier.Name = "labelConstitutionModifier";
            labelConstitutionModifier.Size = new Size(34, 25);
            labelConstitutionModifier.TabIndex = 17;
            labelConstitutionModifier.Text = "+2";
            // 
            // labelIntelligenceModifier
            // 
            labelIntelligenceModifier.AutoSize = true;
            labelIntelligenceModifier.Location = new Point(191, 133);
            labelIntelligenceModifier.Name = "labelIntelligenceModifier";
            labelIntelligenceModifier.Size = new Size(34, 25);
            labelIntelligenceModifier.TabIndex = 18;
            labelIntelligenceModifier.Text = "+2";
            // 
            // labelDexterityModifier
            // 
            labelDexterityModifier.AutoSize = true;
            labelDexterityModifier.Location = new Point(191, 96);
            labelDexterityModifier.Name = "labelDexterityModifier";
            labelDexterityModifier.Size = new Size(34, 25);
            labelDexterityModifier.TabIndex = 19;
            labelDexterityModifier.Text = "+2";
            // 
            // CreateCharacterUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 776);
            Controls.Add(labelDexterityModifier);
            Controls.Add(labelIntelligenceModifier);
            Controls.Add(labelConstitutionModifier);
            Controls.Add(labelWisdomModifier);
            Controls.Add(labelCharismaModifier);
            Controls.Add(labelStrengthModifier);
            Controls.Add(btnCustomCreate);
            Controls.Add(labelStrength);
            Controls.Add(labelDexterity);
            Controls.Add(labelIntelligence);
            Controls.Add(labelConstitution);
            Controls.Add(labelWisdom);
            Controls.Add(labelCharisma);
            Controls.Add(label1);
            Controls.Add(numericDexterity);
            Controls.Add(numericIntelligence);
            Controls.Add(numericConstitution);
            Controls.Add(numericWisdom);
            Controls.Add(numericCharisma);
            Controls.Add(numericStrength);
            Name = "CreateCharacterUI";
            Text = "Character Selection/Creation";
            ((System.ComponentModel.ISupportInitialize)numericStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCharisma).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWisdom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericConstitution).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIntelligence).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDexterity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericStrength;
        private NumericUpDown numericCharisma;
        private NumericUpDown numericWisdom;
        private NumericUpDown numericConstitution;
        private NumericUpDown numericIntelligence;
        private NumericUpDown numericDexterity;
        private Label label1;
        private Label labelCharisma;
        private Label labelWisdom;
        private Label labelConstitution;
        private Label labelIntelligence;
        private Label labelDexterity;
        private Label labelStrength;
        private Button btnCustomCreate;
        private Label labelStrengthModifier;
        private Label labelCharismaModifier;
        private Label labelWisdomModifier;
        private Label labelConstitutionModifier;
        private Label labelIntelligenceModifier;
        private Label labelDexterityModifier;
    }
}