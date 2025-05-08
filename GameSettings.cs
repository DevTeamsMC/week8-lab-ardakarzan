using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public enum DifficultySetting
    {
        Easy,
        Medium,
        Hard
    }

    public enum ImageThemeSetting
    {
        Hangman,
        Flowers,
        Baloons
    }

    public static class GameSettings
    {
        public static string SelectedCategory { get; set; } = "History";
        public static int GameDurationSeconds { get; set; } = 300;
        public static DifficultySetting SelectedDifficulty { get; set; } = DifficultySetting.Medium;

        public const int MaxWrongGuesses = 10;

        public static ImageThemeSetting SelectedImageTheme { get; set; } = ImageThemeSetting.Hangman;

        public static string GetImageFolderName()
        {
            return SelectedImageTheme.ToString().ToLower();
        }
    }
}
