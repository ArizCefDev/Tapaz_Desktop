using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
            timer1.Start();
        }

        int san = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            san++;
            label1.Text = san.ToString();

            if (san > 0)
            {
                panel1.Visible = true;
                panel2.Visible = true;
            }
            if (san > 1)
            {
                panel1.Visible = false;
                panel2.Visible = false;
            }

            var text = textBox1.Text;

            switch (text.ToLower())
            {
                case "salam":
                    label2.Text = "Salam";
                    break;
                case "necesen":
                    label2.Text = "Sagol yaxsiyam";
                    break;

                case "pis robot":
                    panel1.Visible = true;
                    panel2.Visible = false;
                    break;

                case "yaxsi robot":
                    panel1.Visible = false;
                    panel2.Visible = true;
                    break;

                case "mod":
                    label2.Text = @"Modlar: k-kalkulyator
h-hefte
                                ";
                    break;

                case "k":
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    comboBox1.Visible = true;

                    decimal num1 = Convert.ToDecimal(textBox2.Text);
                    decimal num2 = Convert.ToDecimal(textBox3.Text);
                    decimal c = 0;
                    if (comboBox1.Text == "+")
                    {
                        c = num1 + num2;
                        label2.Text = c.ToString();
                    }
                    else if (comboBox1.Text == "-")
                    {
                        c = num1 - num2;
                        label2.Text = c.ToString();
                    }
                    else if (comboBox1.Text == "/")
                    {
                        c = num1 / num2;
                        label2.Text = c.ToString();
                    }
                    else if (comboBox1.Text == "*")
                    {
                        c = num1 * num2;
                        label2.Text = c.ToString();
                    }
                    else
                    {
                        label2.Text = "simvol sec";
                    }
                    break;
                case "h":
                    textBox2.Visible = false;
                    textBox3.Visible = true;
                    comboBox1.Visible = false;
                    string gun = textBox3.Text;

                    if (gun == "1")
                        label2.Text ="Pazartesi";

                    else if (gun == "2")
                        label2.Text ="Sali";

                    else if (gun == "3")
                        label2.Text ="Carsamba";

                    else if (gun == "4")
                        label2.Text ="Persembe";

                    else if (gun == "5")
                        label2.Text ="Cuma";

                    else if (gun == "6")
                        label2.Text ="Cumartesi";

                    else if (gun == "7")
                        label2.Text ="Pazar";

                    else
                        label2.Text ="yalnis gun";
                    break;
                case "":
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    comboBox1.Visible = false;
                    label2.Text = "--------";
                    break;
                default:
                    label2.Text = "Anlamadim";
                    break;
            }

        }
    }
}
