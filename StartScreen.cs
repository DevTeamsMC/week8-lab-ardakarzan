using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class StartScreen : Form
    {
        private readonly string[] gameCategories = { "History", "Computer Science", "Mathematics" };

        public StartScreen()
        {
            InitializeComponent();

            labelHangmanText.Parent = pictureBoxStartScreen;
            labelHangmanText.BackColor = System.Drawing.Color.Transparent;

            comboBoxCategories.Items.Clear();
            comboBoxCategories.Items.AddRange(gameCategories);
            comboBoxCategories.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameSettings.SelectedCategory = comboBoxCategories.SelectedItem.ToString();

            GameScreen gameScr = new GameScreen();
            this.Hide();
            gameScr.ShowDialog();
            this.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsSc = new SettingsScreen();
            settingsSc.ShowDialog();
        }
    }
}