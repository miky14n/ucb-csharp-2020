using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTicTacToe
{
    public partial class MainForm : Form
    {
        TicTacToe game;

        // void XXXXXXXX (string)
        public delegate void MessagesDelegate(string message);
        // int XXXXX (int, string)
        public delegate int ConvertDelegate(int number, string str);

        public MainForm()
        {
            InitializeComponent();
            game = new TicTacToe();
            game.WinnerFound += Game_WinnerFound;
            game.LoadedGame += Game_LoadedGame;
            // game.WinnerFound-= Game_WinnerFound;
        }

        private void Game_LoadedGame(string[,] data)
        {
            // Console.WriteLine("Game loaded");
            btn1_1.Text = data[0, 0];
            btn1_2.Text = data[0, 1];
            btn1_3.Text = data[0, 2];
            btn2_1.Text = data[1, 0];
            btn2_2.Text = data[1, 1];
            btn2_3.Text = data[1, 2];
            btn3_1.Text = data[2, 0];
            btn3_2.Text = data[2, 1];
            btn3_3.Text = data[2, 2];
        }

        private void Game_WinnerFound(string winner)
        {
            MessageBox.Show(winner + " ha ganado el juego");
            // game.CurrentGamer = "z";
            //throw new Exception("Error");
        }

        //string current_gamer = "X";

        public void ShowMessage (MessagesDelegate messenger)
        {
            messenger("hola");
        }

        // string winner;

        private void btn1_1_Click(object sender, EventArgs e)
        {
            if (!(sender is Button)) return;
            var btn = (Button)sender;
            // Mapper(btn);
            int row = 0;
            int col = 0;
            string[] rowcol = btn.Tag.ToString().Split(',');
            row = Convert.ToInt32(rowcol[0]);
            col = Convert.ToInt32(rowcol[1]);
            btn.Text = game.CurrentGamer; // this.current_gamer;
            #region unused
            //winner = game.GetWinner(current_gamer);
            //if (!string.IsNullOrEmpty(winner)) MessageBox.Show(winner + " ha ganado el juego");

            //if (current_gamer == "X")
            //{ current_gamer = "O"; }
            //else
            //{
            //    current_gamer = "X";
            //}
            #endregion
            // game.Play(game.CurrentGamer, row, col);
            game.Play(row, col);
        }

        private void Mapper(Button btn)
        {
            int row = 0;
            int col = 0;
            #region Unused
            //if (btn.Name.Contains("1_1"))
            //{
            //    row = 0; col = 0;
            //}
            //if (btn.Name.Contains("1_2"))
            //{
            //    row = 0; col = 1;
            //}
            //if (btn.Name.Contains("1_3"))
            //{
            //    row = 0; col = 2;
            //}
            //if (btn.Name.Contains("2_1"))
            //{
            //    row = 1; col = 0;
            //}
            //if (btn.Name.Contains("2_2"))
            //{
            //    row = 1; col = 1;
            //}
            //if (btn.Name.Contains("2_3"))
            //{
            //    row = 1; col = 2;
            //}
            //if (btn.Name.Contains("3_1"))
            //{
            //    row = 2; col = 0;
            //}
            //if (btn.Name.Contains("3_2"))
            //{
            //    row = 2; col = 1;
            //}
            //if (btn.Name.Contains("3_3"))
            //{
            //    row = 2; col = 2;
            //}
            #endregion
            string[] rowcol = btn.Tag.ToString().Split(',');
            row = Convert.ToInt32(rowcol[0]);
            col = Convert.ToInt32(rowcol[1]);
            // model[row, col] = current_gamer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ShowMessage(MyWindowsMessenger);
            //ShowMessage(MyConsoleMessenger);
            //var folder = @"C:\";
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // C:\Users\enrique\AppData\Roaming
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //saveFileDialog1.InitialDirectory
                game.Save(saveFileDialog1.FileName);
            }

            // Data Source=ENRIQUE2ECD;Initial Catalog=TicTacToe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            //game.Save(folder +@"\"+ "Game.txt");

        }

        void MyWindowsMessenger (string msg)
        {
            MessageBox.Show(msg);
        }

        void MyConsoleMessenger(string msg)
        {
            Console.WriteLine(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            game.Open(folder + @"\" + "Game.txt");
            //game.model[]
        }
    }
}
