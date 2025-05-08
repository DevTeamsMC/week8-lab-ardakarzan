namespace HangmanGame
{
    partial class SettingsScreen
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
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.comboBoxImageTheme = new System.Windows.Forms.ComboBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonEasy.Location = new System.Drawing.Point(28, 108);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(138, 46);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "EASY";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMedium.Location = new System.Drawing.Point(28, 151);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(138, 46);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "MEDIUM";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonHard.Location = new System.Drawing.Point(28, 194);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(138, 46);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "HARD";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDifficulty.Location = new System.Drawing.Point(3, 72);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(181, 33);
            this.labelDifficulty.TabIndex = 3;
            this.labelDifficulty.Text = "DIFFICULTY";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxImageTheme
            // 
            this.comboBoxImageTheme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxImageTheme.FormattingEnabled = true;
            this.comboBoxImageTheme.Location = new System.Drawing.Point(26, 42);
            this.comboBoxImageTheme.Name = "comboBoxImageTheme";
            this.comboBoxImageTheme.Size = new System.Drawing.Size(140, 27);
            this.comboBoxImageTheme.TabIndex = 4;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTheme.Location = new System.Drawing.Point(21, 9);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(89, 30);
            this.labelTheme.TabIndex = 5;
            this.labelTheme.Text = "THEME";
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownDuration.Location = new System.Drawing.Point(26, 273);
            this.numericUpDownDuration.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownDuration.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(140, 34);
            this.numericUpDownDuration.TabIndex = 6;
            this.numericUpDownDuration.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "GAME DURATION";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(12, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(189, 73);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "SAVE SETTINGS";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(213, 389);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.comboBoxImageTheme);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.radioButtonHard);
            this.Controls.Add(this.radioButtonMedium);
            this.Controls.Add(this.radioButtonEasy);
            this.Name = "SettingsScreen";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.ComboBox comboBoxImageTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
    }
}