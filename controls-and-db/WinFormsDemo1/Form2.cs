using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo1
{
    public partial class LayoutDemo2 : Form
    {
        public LayoutDemo2()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo archivo..");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CreateLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Left = x;
            label.Top = y;
            label.AutoSize = true;
            label.Text = text;
            this.Controls.Add(label);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {
            //        CreateLabel("1", 50, 100);
            //    }
            //}
            CreateLabel("1", 50, 100);
            CreateLabel("2", 50 + 20, 100);
            Label lbl2 = new Label();
            lbl2.Top = 100;
            lbl2.Left = 50 + 20 + 20;
            lbl2.AutoSize = true;
            lbl2.Text = "3";
            this.Controls.Add(lbl2);

            Label lbl3 = new Label();
            lbl3.Top = 100+20;
            lbl3.Left = 50;
            lbl3.AutoSize = true;
            lbl3.Text = "4";
            this.Controls.Add(lbl3);

            //lbl.SendToBack();
            //int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }; //4x2
            //int[,] tictactoe = new int[3, 3];
            //tictactoe[0, 0] = 1;
            //tictactoe[0, 1] = 2;
            // Convert.ToInt32("100");
            // int.Parse("5");
        }
    }
}
