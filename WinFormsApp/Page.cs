using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }

        PageProduct p = new PageProduct();
        decimal total = 0;
        private void Page_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                    101. Kurassan - 0.60 azn
                    102. Fanta - 2.60 azn
                    103. Lays - 2.90 azn
");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "101")
            {
                object[] list = { p.Name = "Kurassan", p.Price = 0.60M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }

                total = total + p.Price;
            }
            else if (textBox1.Text == "102")
            {
                object[] list = { p.Name = "Fanta", p.Price = 2.60M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                total = total + p.Price;
            }
            else if (textBox1.Text == "103")
            {
                object[] list = { p.Name = "Lays", p.Price = 2.90M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                total = total + p.Price;
            }
            else
            {
                MessageBox.Show("Kod yalnışdır");
            }
            label3.Text = $"{total} azn";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(textBox2.Text);
            decimal result = money - total;

            label4.Text = $"{money} azn";
            label6.Text = $"{result} azn";
        }
    }
}
