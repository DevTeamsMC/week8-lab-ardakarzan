namespace HangmanGame
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.labelHangmanText = new System.Windows.Forms.Label();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.buttonClue = new System.Windows.Forms.Button();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.labelClue = new System.Windows.Forms.Label();
            this.labelGuessedLetters = new System.Windows.Forms.Label();
            this.labelUnderscores = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelWrongGuesses = new System.Windows.Forms.Label();
            this.labelWordLength = new System.Windows.Forms.Label();
            this.labelEnterGuess = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCurrentSettings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHangmanText
            // 
            this.labelHangmanText.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHangmanText.Location = new System.Drawing.Point(514, -2);
            this.labelHangmanText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHangmanText.Name = "labelHangmanText";
            this.labelHangmanText.Size = new System.Drawing.Size(355, 91);
            this.labelHangmanText.TabIndex = 0;
            this.labelHangmanText.Text = "HANGMAN";
            this.labelHangmanText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHangman.Image")));
            this.pictureBoxHangman.Location = new System.Drawing.Point(795, 95);
            this.pictureBoxHangman.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(627, 542);
            this.pictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHangman.TabIndex = 1;
            this.pictureBoxHangman.TabStop = false;
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGuess.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuess.Location = new System.Drawing.Point(413, 607);
            this.buttonGuess.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(139, 69);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "GUESS";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.BackColor = System.Drawing.Color.Gold;
            this.buttonEndGame.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEndGame.Location = new System.Drawing.Point(560, 607);
            this.buttonEndGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(176, 69);
            this.buttonEndGame.TabIndex = 3;
            this.buttonEndGame.Text = "END GAME";
            this.buttonEndGame.UseVisualStyleBackColor = false;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // buttonClue
            // 
            this.buttonClue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClue.Location = new System.Drawing.Point(39, 503);
            this.buttonClue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClue.Name = "buttonClue";
            this.buttonClue.Size = new System.Drawing.Size(100, 47);
            this.buttonClue.TabIndex = 4;
            this.buttonClue.Text = "CLUE ?";
            this.buttonClue.UseVisualStyleBackColor = true;
            this.buttonClue.Click += new System.EventHandler(this.buttonClue_Click);
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGuess.Location = new System.Drawing.Point(311, 619);
            this.textBoxGuess.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(93, 44);
            this.textBoxGuess.TabIndex = 5;
            this.textBoxGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelClue
            // 
            this.labelClue.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelClue.Location = new System.Drawing.Point(147, 517);
            this.labelClue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClue.Name = "labelClue";
            this.labelClue.Size = new System.Drawing.Size(612, 46);
            this.labelClue.TabIndex = 6;
            this.labelClue.Text = "CLUE";
            // 
            // labelGuessedLetters
            // 
            this.labelGuessedLetters.BackColor = System.Drawing.Color.Transparent;
            this.labelGuessedLetters.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGuessedLetters.Location = new System.Drawing.Point(93, 100);
            this.labelGuessedLetters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuessedLetters.Name = "labelGuessedLetters";
            this.labelGuessedLetters.Size = new System.Drawing.Size(615, 72);
            this.labelGuessedLetters.TabIndex = 7;
            this.labelGuessedLetters.Text = "label1";
            // 
            // labelUnderscores
            // 
            this.labelUnderscores.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUnderscores.Location = new System.Drawing.Point(95, 155);
            this.labelUnderscores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnderscores.Name = "labelUnderscores";
            this.labelUnderscores.Size = new System.Drawing.Size(615, 82);
            this.labelUnderscores.TabIndex = 8;
            this.labelUnderscores.Text = "label2";
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.Location = new System.Drawing.Point(31, 450);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(213, 49);
            this.labelScore.TabIndex = 9;
            this.labelScore.Text = "SCORE:";
            // 
            // labelWrongGuesses
            // 
            this.labelWrongGuesses.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWrongGuesses.Location = new System.Drawing.Point(31, 369);
            this.labelWrongGuesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWrongGuesses.Name = "labelWrongGuesses";
            this.labelWrongGuesses.Size = new System.Drawing.Size(727, 50);
            this.labelWrongGuesses.TabIndex = 10;
            this.labelWrongGuesses.Text = "WRONG GUESSES:";
            // 
            // labelWordLength
            // 
            this.labelWordLength.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWordLength.Location = new System.Drawing.Point(32, 407);
            this.labelWordLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWordLength.Name = "labelWordLength";
            this.labelWordLength.Size = new System.Drawing.Size(332, 43);
            this.labelWordLength.TabIndex = 11;
            this.labelWordLength.Text = "WORD LENGTH:";
            // 
            // labelEnterGuess
            // 
            this.labelEnterGuess.AutoSize = true;
            this.labelEnterGuess.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterGuess.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEnterGuess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEnterGuess.Location = new System.Drawing.Point(56, 625);
            this.labelEnterGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnterGuess.Name = "labelEnterGuess";
            this.labelEnterGuess.Size = new System.Drawing.Size(233, 29);
            this.labelEnterGuess.TabIndex = 12;
            this.labelEnterGuess.Text = "ENTER YOUR GUESS:";
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.Location = new System.Drawing.Point(33, 337);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(87, 32);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "TIME:";
            // 
            // labelCurrentSettings
            // 
            this.labelCurrentSettings.AutoSize = true;
            this.labelCurrentSettings.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentSettings.Location = new System.Drawing.Point(825, 41);
            this.labelCurrentSettings.Name = "labelCurrentSettings";
            this.labelCurrentSettings.Size = new System.Drawing.Size(61, 25);
            this.labelCurrentSettings.TabIndex = 14;
            this.labelCurrentSettings.Text = "label1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1445, 690);
            this.Controls.Add(this.labelCurrentSettings);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelEnterGuess);
            this.Controls.Add(this.labelWordLength);
            this.Controls.Add(this.labelWrongGuesses);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelUnderscores);
            this.Controls.Add(this.labelGuessedLetters);
            this.Controls.Add(this.labelClue);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.buttonClue);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.pictureBoxHangman);
            this.Controls.Add(this.labelHangmanText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Text = "Hangman (Game Screen) ";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHangmanText;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Button buttonClue;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label labelClue;
        private System.Windows.Forms.Label labelGuessedLetters;
        private System.Windows.Forms.Label labelUnderscores;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelWrongGuesses;
        private System.Windows.Forms.Label labelWordLength;
        private System.Windows.Forms.Label labelEnterGuess;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCurrentSettings;
    }
}