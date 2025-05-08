namespace HangmanGame
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.pictureBoxStartScreen = new System.Windows.Forms.PictureBox();
            this.labelHangmanText = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStartScreen
            // 
            this.pictureBoxStartScreen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStartScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxStartScreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStartScreen.Image")));
            this.pictureBoxStartScreen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStartScreen.Name = "pictureBoxStartScreen";
            this.pictureBoxStartScreen.Size = new System.Drawing.Size(1084, 561);
            this.pictureBoxStartScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStartScreen.TabIndex = 0;
            this.pictureBoxStartScreen.TabStop = false;
            // 
            // labelHangmanText
            // 
            this.labelHangmanText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHangmanText.BackColor = System.Drawing.Color.Transparent;
            this.labelHangmanText.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHangmanText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHangmanText.Location = new System.Drawing.Point(392, 325);
            this.labelHangmanText.Name = "labelHangmanText";
            this.labelHangmanText.Size = new System.Drawing.Size(272, 78);
            this.labelHangmanText.TabIndex = 1;
            this.labelHangmanText.Text = "HANGMAN";
            this.labelHangmanText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Peru;
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.Location = new System.Drawing.Point(447, 422);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(165, 58);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSettings.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSettings.Location = new System.Drawing.Point(208, 335);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(147, 62);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.BackColor = System.Drawing.Color.YellowGreen;
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(699, 373);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCategories.TabIndex = 4;
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.Color.YellowGreen;
            this.labelCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCategory.Location = new System.Drawing.Point(723, 347);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(100, 23);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "CATEGORY";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelHangmanText);
            this.Controls.Add(this.pictureBoxStartScreen);
            this.Name = "StartScreen";
            this.Text = "Hangman (Start Screen)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStartScreen;
        private System.Windows.Forms.Label labelHangmanText;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label labelCategory;
    }
}

