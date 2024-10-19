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
    public partial class MCafecs : Form
    {
        decimal total = 0;
        decimal price = 0;
        public MCafecs()
        {
            InitializeComponent();
        }

        private void MCafecs_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("İçkilər");
            listBox1.Items.Add("Cola - 2.00 azn");
            listBox1.Items.Add("Fanta - 2.10 azn");

            listBox1.Items.Add(" ");

            listBox1.Items.Add("Şirniyyatlar");
            listBox1.Items.Add("Kurassan - 1.00 azn");
            listBox1.Items.Add("Tort - 5.10 azn");

            listBox1.Items.Add(" ");

            listBox1.Items.Add("Ana yeməklər");
            listBox1.Items.Add("Dönər(çörekde) - 2.60 azn");
            listBox1.Items.Add("Dönər(lavaşda) - 3.60 azn");
            listBox1.Items.Add("Basdırma(pors) - 4.60 azn");
            listBox1.Items.Add("Lahmacun - 4.20 azn");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MCafeCheck next = new MCafeCheck();
            next.label2.Text = comboBox1.Text;
            next.label4.Text = textBox1.Text;
            next.label6.Text = comboBox2.Text;
            next.label24.Text = textBox2.Text;
            next.label10.Text = comboBox4.Text;
            next.label22.Text = textBox3.Text;
            next.label14.Text = comboBox3.Text;
            next.label20.Text = textBox4.Text;


            if (comboBox2.Text == "Cola")
            {
                price = 2.00M;
                int number = Convert.ToInt16(textBox2.Text);
                total = total+ price * number;
            }
            if (comboBox2.Text == "Fanta")
            {
                price = 2.10M;
                int number = Convert.ToInt16(textBox2.Text);
                total = total + price * number;
            }

            if (comboBox4.Text == "Kurassan")
            {
                price = 1.00M;
                int number = Convert.ToInt16(textBox3.Text);
                total = total + price * number;
            }

            if (comboBox3.Text == "Dönər(çörekde)")
            {
                price = 2.60M;
                int number = Convert.ToInt16(textBox4.Text);
                total = total + price * number;
            }
            next.label18.Text = $"{total.ToString()} azn";
            next.Show();
        }
    }
}
