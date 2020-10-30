using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // textBox2.Text = "3\r\n4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var lbl = new Label();
            lbl.Top = 50;
            lbl.Left = 150;
            lbl.Text = "DEMOOOOO";
            this.Controls.Add(lbl);
        }
    }
}
