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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        decimal bank = 4000;
        decimal balans = 100;

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label8.Text = "Balans: " + balans.ToString() + "  AZN";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(textBox1.Text);

           
            if (bank < balans)
            {
                label7.Text = "Bankda kifayət qədər məbləğ yoxdur";
            }
            else
            {
                if (money < balans)
                {
                    balans = balans - money;
                    label7.Text = "Əməliyyat uğurla həyata keçirildi";
                    label8.Text = "Balans: " + balans.ToString() + "  AZN";
                }
                else
                {
                    label7.Text = "Balansda kifayət qədər məbləğ yoxdur";
                }
            }
           

        }
    }
}
