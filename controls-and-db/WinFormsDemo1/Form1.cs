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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Text = "Class 01";
            //label1.Text = "Name:";
            label2.Text = txtName.Text;
            // MessageBox.Show(txtName.Text + " esta " + comboBox1.Text);
            // this.Controls
            var music = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            MessageBox.Show($"{txtName.Text} esta {comboBox1.Text} y le gusta el {music}");
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    // MessageBox.Show("El input ahora esta habilitado");
            //    txtName.Enabled = true;
            //}
            //else
            //{
            //    // MessageBox.Show("El input ahora esta deshabilitado");
            //    txtName.Enabled = false;
            //}

            //if (checkBox1.Checked)
            //{
            //    // MessageBox.Show("El input ahora esta habilitado");
            //    txtName.Enabled = true;
            //}
            //else
            //{
            //    // MessageBox.Show("El input ahora esta deshabilitado");
            //    txtName.Enabled = false;
            //}

            txtName.Enabled = checkBox1.Checked;
        }
        
        private bool IsPrime(int n)
        {
            // bool prime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 5; i < 20; i++)
            {
                if (IsPrime(i))
                {
                    listBox1.Items.Add(i);
                }
            }
            // MessageBox.Show("El numero 10 " + IsPrime(10));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LayoutDemo2 form2 = new LayoutDemo2();
            form2.Show();
        }
    }
}
