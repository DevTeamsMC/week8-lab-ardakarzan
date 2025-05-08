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
    public partial class SettingsScreen : Form
    {
        public SettingsScreen()
        {
            InitializeComponent();
            AddThemes();
            LoadSettings();
        }

        private void AddThemes()
        {
            comboBoxImageTheme.Items.Clear();
            comboBoxImageTheme.Items.AddRange(new[] { "Hangman", "Flowers", "Baloons" });
        }

        private void LoadSettings()
        {
            numericUpDownDuration.Value = GameSettings.GameDurationSeconds;

            switch (GameSettings.SelectedDifficulty)
            {
                case DifficultySetting.Easy:
                    radioButtonEasy.Checked = true;
                    break;
                case DifficultySetting.Medium:
                    radioButtonMedium.Checked = true;
                    break;
                case DifficultySetting.Hard:
                    radioButtonHard.Checked = true;
                    break;
            }

            comboBoxImageTheme.SelectedItem = GameSettings.SelectedImageTheme.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            GameSettings.GameDurationSeconds = (int)numericUpDownDuration.Value;

            if (radioButtonEasy.Checked)
            {
                GameSettings.SelectedDifficulty = DifficultySetting.Easy;
            }
            else if (radioButtonMedium.Checked)
            {
                GameSettings.SelectedDifficulty = DifficultySetting.Medium;
            }
            else if (radioButtonHard.Checked)
            {
                GameSettings.SelectedDifficulty = DifficultySetting.Hard;
            }

            var theme = comboBoxImageTheme.SelectedItem.ToString();
            GameSettings.SelectedImageTheme = (ImageThemeSetting)Enum.Parse(typeof(ImageThemeSetting), theme);

            this.Close();
        }
    }
}
