using System;
using System.IO;
// using System.Windows.Forms;

namespace WinTicTacToe
{
    public class TicTacToe
    {
        private string[,] model = new string[3, 3]; //

        public TicTacToe()
        {
            CurrentGamer = "X";
        }
        public string CurrentGamer { get; private set; }

        public delegate void WinnerDelegate(string winner);
        public event WinnerDelegate WinnerFound;

        private void OnWinnerFound (string winner)
        {
            if (WinnerFound != null)
            {
                WinnerFound(winner);
            }
        }

        public delegate void LoadedGameDelegate(string[,] data);
        public event LoadedGameDelegate LoadedGame;

        private void OnLoadedGame(string[,] data)
        {
            if (LoadedGame != null)
            {
                LoadedGame(data);
            }
        }

        public void Save(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                
                var line = string.Empty;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        line = line + ":" + model[i, j];
                    }
                }
                line = line + "," + CurrentGamer;
                sw.WriteLine(line);
                // sw.WriteLine("Hello UCB!");

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }
        }

        public void Open(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            var line = lines[0];
            // return line;
            var components = line.Split(',');
            var vector = components[0].Split(':');
            CurrentGamer = components[1];
            var counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    model[i, j] = vector[counter];
                    counter++;
                }
            }
            OnLoadedGame(model);
        }

        public void Play( int row, int col)
        {
            //CurrentGamer = gamer;
            model[row, col] = CurrentGamer;
            var winner = GetWinner(CurrentGamer);
            if (!string.IsNullOrEmpty(winner))
            {
                // MessageBox.Show(winner + " ha ganado el juego");
                Console.WriteLine(winner + " ha ganado el juego");
                OnWinnerFound(winner);
            }

            if (CurrentGamer == "X")
            { CurrentGamer = "O"; }
            else
            {
                CurrentGamer = "X";
            }
        }

        public string GetWinner(string gamer)
        {
            if (model[0, 0] != null && model[0, 1] != null && model[0, 2] != null && model[0, 0] == model[0, 1] && model[0, 1] == model[0, 2])
            {
                return gamer;
            }
            return null;
        }

        
    }
}
