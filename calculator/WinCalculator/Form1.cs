using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    enum ActiveValue {v1, v2 };
    // enum Genero { Masculino, Femenino};
    // enum EstadoCivil { Soltero, Casado, Viudo, Divorciado};
    public partial class Form1 : Form
    {
        string value1 = string.Empty;
        string value2 = string.Empty;
        string operation = string.Empty;
        // Genero myGender = Genero.Femenino;

        ActiveValue active = ActiveValue.v1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (active== ActiveValue.v1)
            //{
            //    value1 = value1 + "7";
            //    this.textBox1.Text = value1;
            //}
            //else
            //{
            //    value2 = value2 + "7";
            //    this.textBox1.Text = value2;
            //}
            if (!(sender is Button)) return;
            var button = (Button)sender;
            if (active == ActiveValue.v1)
            {
                value1 = value1 + button.Text;
                this.textBox1.Text = value1;
            }
            else
            {
                value2 = value2 + button.Text;
                this.textBox1.Text = value2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // operation = "*";
            if (!(sender is Button)) return;
            var button = (Button)sender;
            operation = button.Text;
            active = ActiveValue.v2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "X":
                        {
                            textBox1.Text = Convert.ToString(Convert.ToDouble(value1) * Convert.ToDouble(value2));
                            value1 = textBox1.Text;
                            value2 = string.Empty;
                            // active = ActiveValue.v2;
                            break;
                        }
                    case "-":
                        {
                            textBox1.Text = Convert.ToString(Convert.ToInt32(value1) - Convert.ToInt32(value2)); ;
                            value1 = textBox1.Text;
                            value2 = string.Empty;
                            // active = ActiveValue.v2;
                            break;
                        }
                    case "+":
                        {
                            textBox1.Text = Convert.ToString(Convert.ToInt32(value1) + Convert.ToInt32(value2)); ;
                            value1 = textBox1.Text;
                            value2 = string.Empty;
                            // active = ActiveValue.v2;
                            break;
                        }
                    case "/":
                        {
                            // bool error = false;
                            // try
                            //{
                            textBox1.Text = Convert.ToString(Convert.ToInt32(value1) / Convert.ToInt32(value2));

                            //}
                            //catch (Exception)
                            //{
                            //    textBox1.Text = "Cannot divide by zero";
                            // error = true;
                            // throw;
                            //}

                            // JAMAS, NEVER IN THE LIFE!
                            //if (error) { //...
                            //}
                            value1 = textBox1.Text;
                            value2 = string.Empty;
                            // active = ActiveValue.v2;
                            break;
                        }
                    default:

                        break;
                }
            }
            catch (DivideByZeroException)
            {
                textBox1.Text = "Cannot divide by zero";
            }
            catch (ArithmeticException)
            {
                textBox1.Text = "Arithmetic error";
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
                // throw;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
