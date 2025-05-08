using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class GameScreen : Form
    {
        List<WordList> allWords;
        private int maxWrongGuessesNum;
        private int wrongGuessesNum;
        private List<char> wrongGuesses;
        private string currentWord = "";
        private string currentClue = "";
        private char[] wordDisplayState;
        private int score;
        private List<Image> hangmanImages = new List<Image>();
        private int timeLeft;

        public GameScreen()
        {
            InitializeComponent();
            loadImages();
            labelCurrentSettings.Text = $"Difficulty:{GameSettings.SelectedDifficulty}, Category:{GameSettings.SelectedCategory}, Time Limit:{GameSettings.GameDurationSeconds} Seconds";
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            startGame();
        }

        private void startGame()
        {
            timeLeft = GameSettings.GameDurationSeconds;
            labelTime.Text = $"TIME: {TimeSpan.FromSeconds(timeLeft):mm\\:ss}";
            timerGame.Start();

            score = 100;
            wrongGuessesNum = 0;
            wrongGuesses = new List<char>();
            textBoxGuess.Enabled = true;
            buttonGuess.Enabled = true;
            buttonClue.Enabled = true;
            labelClue.Text = "";

            maxWrongGuessesNum = GameSettings.MaxWrongGuesses;

            switch (GameSettings.SelectedCategory)
            {
                case "History":
                    allWords = new List<WordList>
                    {
                                // 7 Easy
                    new WordList("EGYPT",        "Land of the Pharaohs",                         DifficultySetting.Easy),
                    new WordList("ROME",         "Ancient city of the Caesars",                 DifficultySetting.Easy),
                    new WordList("MAYA",         "Civilization in Central America",             DifficultySetting.Easy),
                    new WordList("SALT",         "Ancient trade good that led to wars",         DifficultySetting.Easy),
                    new WordList("COIN",         "First currency units",                        DifficultySetting.Easy),
                    new WordList("WALL",         "Famous defensive structure in China",         DifficultySetting.Easy),
                    new WordList("FLAG",         "Symbol of nations",                           DifficultySetting.Easy),

                    // 7 Medium
                    new WordList("RENAISSANCE",  "Cultural movement of 14th–17th centuries",    DifficultySetting.Medium),
                    new WordList("REVOLUTION",   "Rapid, fundamental political change",         DifficultySetting.Medium),
                    new WordList("COLONIAL",     "Period of foreign territories",               DifficultySetting.Medium),
                    new WordList("FRENCH",       "Revolution that began in 1789",               DifficultySetting.Medium),
                    new WordList("INDUSTRIAL",   "Era that transformed agrarian economies",     DifficultySetting.Medium),
                    new WordList("MEDIEVAL",     "Also known as the Middle Ages",               DifficultySetting.Medium),
                    new WordList("PERSIAN",      "Empire that fought the Greeks at Thermopylae",DifficultySetting.Medium),

                    // 6 Hard
                    new WordList("PELOPONNESIAN","War between Sparta and Athens",               DifficultySetting.Hard),
                    new WordList("CONSTITUTION", "Supreme law of a nation",                     DifficultySetting.Hard),
                    new WordList("FEUDALISM",    "Medieval social and economic system",         DifficultySetting.Hard),
                    new WordList("BOLSHEVIK",    "Russian revolutionary faction of 1917",       DifficultySetting.Hard),
                    new WordList("BYZANTIUM",    "Eastern Roman Empire’s capital",              DifficultySetting.Hard),
                    new WordList("DEMOGRAPHY",   "Study of populations",                        DifficultySetting.Hard)
                    };
                break;

                case "Mathematics":
                    allWords = new List<WordList>
                {
                    // Easy
                    new WordList("PLUS",         "Addition operator",                          DifficultySetting.Easy),
                    new WordList("MINUS",        "Subtraction operator",                       DifficultySetting.Easy),
                    new WordList("ZERO",         "The integer between -1 and 1",                DifficultySetting.Easy),
                    new WordList("LINE",         "Straight one-dimensional figure",             DifficultySetting.Easy),
                    new WordList("POINT",        "Zero-dimensional location",                   DifficultySetting.Easy),
                    new WordList("ANGLE",        "Figure formed by two rays",                   DifficultySetting.Easy),
                    new WordList("ROUND",        "To approximate to the nearest integer",       DifficultySetting.Easy),

                    // Medium
                    new WordList("ALGEBRA",      "Branch dealing with symbols and rules",       DifficultySetting.Medium),
                    new WordList("GEOMETRY",     "Study of shapes and spaces",                  DifficultySetting.Medium),
                    new WordList("HYPOTENUSE",   "Longest side of a right triangle",            DifficultySetting.Medium),
                    new WordList("INTEGRAL",     "Area under a curve",                          DifficultySetting.Medium),
                    new WordList("FACTORIAL",    "Product of all positive integers ≤ n",        DifficultySetting.Medium),
                    new WordList("MATRIX",       "Rectangular array of numbers",                DifficultySetting.Medium),
                    new WordList("LOGARITHM",    "Inverse of exponentiation",                   DifficultySetting.Medium),

                    // Hard
                    new WordList("DIFFERENTIAL","Relating to derivatives",                      DifficultySetting.Hard),
                    new WordList("TOPOLOGY",     "Study of properties preserved under deformations", DifficultySetting.Hard),
                    new WordList("COMBINATORICS","Counting and arrangement of sets",             DifficultySetting.Hard),
                    new WordList("FOURIER",      "Analysis of functions via sine/cosine series",DifficultySetting.Hard),
                    new WordList("STOCHASTICS",  "Branch covering random processes",             DifficultySetting.Hard),
                    new WordList("EIGENVALUE",   "Scalar associated with a linear transformation",DifficultySetting.Hard)
                };
                break;

                default: // compsci
                    allWords = new List<WordList>
                {
                    // Easy
                    new WordList("CODE",         "Instructions written for computers",          DifficultySetting.Easy),
                    new WordList("BINARY",       "System of 0s and 1s",                        DifficultySetting.Easy),
                    new WordList("BUG",          "Error in software",                           DifficultySetting.Easy),
                    new WordList("ARRAY",        "Collection of elements indexed by position",  DifficultySetting.Easy),
                    new WordList("LOOP",         "Structure for repeating code",                DifficultySetting.Easy),
                    new WordList("HASH",         "Map of keys to values",                       DifficultySetting.Easy),
                    new WordList("STACK",        "LIFO data structure",                         DifficultySetting.Easy),

                    // Medium
                    new WordList("ALGORITHM",    "Step-by-step procedure for calculations",     DifficultySetting.Medium),
                    new WordList("FUNCTION",     "Reusable block of code",                      DifficultySetting.Medium),
                    new WordList("VARIABLE",     "Storage location identified by name",         DifficultySetting.Medium),
                    new WordList("DATABASE",     "Structured collection of data",               DifficultySetting.Medium),
                    new WordList("OBJECT",       "Instance of a class",                         DifficultySetting.Medium),
                    new WordList("NETWORK",      "Interconnected computers",                    DifficultySetting.Medium),
                    new WordList("PROTOCOL",     "Rules for data communication",                DifficultySetting.Medium),

                    // Hard
                    new WordList("CRYPTOGRAPHY", "Art of secure communication",                 DifficultySetting.Hard),
                    new WordList("PARALLELISM",  "Performing multiple calculations simultaneously", DifficultySetting.Hard),
                    new WordList("CONCURRENCY",  "Managing multiple tasks at once",             DifficultySetting.Hard),
                    new WordList("ENCAPSULATION","Hiding internal object details",               DifficultySetting.Hard),
                    new WordList("METAPROGRAMMING","Writing code that writes code",              DifficultySetting.Hard),
                    new WordList("VIRTUALIZATION","Creating virtual versions of resources",       DifficultySetting.Hard)
                };
                break;
            }

            var filtered = allWords.Where(w => w.Difficulty == GameSettings.SelectedDifficulty).ToList();

            var rand = new Random();
            var pick = filtered[rand.Next(filtered.Count)];
            currentWord = pick.Word;
            currentClue = pick.Clue;

            wordDisplayState = Enumerable.Repeat('_', currentWord.Length).ToArray();
            labelUnderscores.Text = string.Join(" ", wordDisplayState);
            labelGuessedLetters.Text = new string(' ', currentWord.Length * 2 - 1);

            updateScreen();
        }

        private void updateScreen()
        {
            var disp = wordDisplayState
                .Select(c => c == '_' ? ' ' : c)
                .Select((c, i) => i < wordDisplayState.Length - 1 ? $"{c} " : c.ToString());
            labelGuessedLetters.Text = string.Concat(disp);

            labelWordLength.Text = $"WORD LENGTH: {currentWord.Length}";
            labelScore.Text = $"SCORE: {score} P";
            labelWrongGuesses.Text = $"WRONG GUESSES: {string.Join(", ", wrongGuesses)}";

            int imageIndex = wrongGuessesNum;
            if (imageIndex < hangmanImages.Count && hangmanImages[imageIndex] != null)
                pictureBoxHangman.Image = hangmanImages[imageIndex];
        }

        private void endGame(bool win)
        {
            timerGame.Stop();
            labelTime.Visible = false;
            textBoxGuess.Enabled = false;
            buttonGuess.Enabled = false;
            buttonClue.Enabled = false;

            if (win)
            {
                this.BackColor = Color.LightGreen;
                MessageBox.Show($"YOU'VE WON! The word was: {currentWord}", "YOU'VE WON!");
            }
            else
            {
                this.BackColor = Color.LightCoral;
                for (int i = 0; i < currentWord.Length; i++)
                    wordDisplayState[i] = currentWord[i];
                updateScreen();
                MessageBox.Show($"YOU'VE LOST! The word was: {currentWord}", "Game Over");
            }
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "End Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void buttonClue_Click(object sender, EventArgs e)
        {
            labelClue.Text = $"CLUE: {currentClue}";
            buttonClue.Enabled = false;
        }

        private void loadImages()
        {
            hangmanImages.Clear();
            string theme = GameSettings.GetImageFolderName();
            string folder = Path.Combine(Application.StartupPath, "imgs");

            for (int i = 0; i <= GameSettings.MaxWrongGuesses; i++)
            {
                string fname = Path.Combine(folder, $"{theme}{i+1}.png");
                if (File.Exists(fname))
                    hangmanImages.Add(new Bitmap(fname));
                else
                    hangmanImages.Add(null);
            }
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            var txt = textBoxGuess.Text.Trim().ToUpper();
            textBoxGuess.Clear();
            if (txt.Length != 1 || !char.IsLetter(txt[0]))
            {
                MessageBox.Show("Please enter a single letter.");
                return;
            }

            char guess = txt[0];
            if (wordDisplayState.Contains(guess) || wrongGuesses.Contains(guess))
            {
                MessageBox.Show($"You already guessed '{guess}'.");
                return;
            }

            bool correct = false;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (currentWord[i] == guess)
                {
                    wordDisplayState[i] = guess;
                    correct = true;
                }
            }

            if (!correct)
            {
                wrongGuesses.Add(guess);
                wrongGuessesNum++;
                score = Math.Max(0, score - 10);
                if (wrongGuessesNum >= maxWrongGuessesNum)
                {
                    updateScreen();
                    endGame(false);
                    return;
                }
            }
            else if (wordDisplayState.All(c => c != '_'))
            {
                updateScreen();
                endGame(true);
                return;
            }

            updateScreen();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft >= 0)
            {
                labelTime.Text = $"TIME: {TimeSpan.FromSeconds(timeLeft):mm\\:ss}";
            }
            else
            {
                timerGame.Stop();
                MessageBox.Show("TIMES UP!");
                endGame(false);
            }
        }
    }

    public class WordList
    {
        public string Word { get; }
        public string Clue { get; }
        public DifficultySetting Difficulty { get; }

        public WordList(string w, string c, DifficultySetting d)
        {
            Word = w;
            Clue = c;
            Difficulty = d;
        }
    }
}
