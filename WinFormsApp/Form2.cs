using MessagingToolkit.QRCode.Codec;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        decimal tot = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                               Kod: 101 | Kurassan
                               Kod: 102 | Coca-Cola
                               Kod: 103 | Çörək
                             ");
        }

        private void button2_Click(object sender, EventArgs e)
        {                     //0     //1   //2
            string[] code = { "101", "102", "103" };
            string[] name = { "Kurassan", "Coca-Cola", "Çörək" };
            decimal[] price = { 0.75M, 2.40M, 0.70M };


            if (textBox1.Text == code[0])
            {
                listBox1.Items.Add($"Kod:{code[0]} | Ad: {name[0]} | Qiymət: {price[0]} azn");
                tot = tot + price[0];
            }
            else if (textBox1.Text == code[1])
            {
                listBox1.Items.Add($"Kod:{code[1]} | Ad: {name[1]} | Qiymət: {price[1]} azn");
                tot = tot + price[1];
            }
            else if (textBox1.Text == code[2])
            {
                listBox1.Items.Add($"Kod:{code[2]} | Ad: {name[2]} | Qiymət: {price[2]} azn");
                tot = tot + price[2];
            }

            total.Text = tot.ToString() + " " + "azn";

            decimal edv = tot / 100;
            decimal per = edv * 18;

            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(per.ToString());
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            decimal py = Convert.ToDecimal(textBox2.Text);

            if (py < tot)
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
                decimal ret = py - tot;
                pay.Text = py.ToString() + " " + "azn";
                returned.Text = ret.ToString() + " " + "azn";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
