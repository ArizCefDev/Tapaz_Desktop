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
    public partial class Group1117 : Form
    {
        public Group1117()
        {
            InitializeComponent();
        }

        int[] code = { 101, 102, 103 };
        string[] name = { "Kurassan", "Lays", "Fanta" };
        decimal[] price = { 0.60M, 2.99M, 2.10M };
        decimal total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"
                           Kod: {code[0]} | Ad: {name[0]} | Qiymet: {price[0]} azn
                           Kod: {code[1]} | Ad: {name[1]} | Qiymet: {price[1]} azn
                           Kod: {code[2]} | Ad: {name[2]} | Qiymet: {price[2]} azn
                           ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == code[0].ToString())
            {
                listBox1.Items.Add($"Kod: {code[0]} | Ad: {name[0]} | Qiymet: {price[0]} azn");
                total = total + price[0];
            }
            else if (textBox1.Text == code[1].ToString())
            {
                listBox1.Items.Add($"Kod: {code[1]} | Ad: {name[1]} | Qiymet: {price[1]} azn");
                total = total + price[1];
            }
            else if (textBox1.Text == code[2].ToString())
            {
                listBox1.Items.Add($"Kod: {code[2]} | Ad: {name[2]} | Qiymet: {price[2]} azn");
                total = total + price[2];
            }
            else
            {
                listBox1.Items.Add($"Tapilmadi");
            }
            label7.Text = $"{total.ToString()} azn";

            decimal edv = total / 100;
            decimal per = edv * 18;

            QRCodeEncoder enc = new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(per.ToString());
        }

        private void Group1117_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void duyme1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duymex_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void duyme4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duymenoqte_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void duyme0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            decimal pay = Convert.ToDecimal(textBox2.Text);


            if (total > pay)
            {
                label8.Visible = true;
            }
            else
            {
                label6.Text = $"{pay} azn";
                decimal returned = pay - total;
                label5.Text = $"{returned} azn";
                label8.Visible = false;
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
