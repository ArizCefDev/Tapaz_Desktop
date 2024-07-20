using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class ICost : Form
    {
        public ICost()
        {
            InitializeComponent();
        }

        private void ICost_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //textBox1.Text += btn.Text;

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            textBox1.Text += btn.Text;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button15.Text = "Soyuq içkilər";
            button13.Text = "Alkoqollu";
            button14.Text = "Alkoqolsuz";
            button16.Text = "Kofe";
            button20.Text = "Şərab";
            button19.Text = "->";
            button18.Visible = false;
            button17.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button15.Text = "Sil";
            button13.Text = "Axtar";
            button14.Text = "Servis";
            button16.Text = "Endirim";
            button20.Text = "Bar";
            button19.Text = "Mətbəx";
            button18.Visible = true;
            button17.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "Sular";
            button13.Text = "Soft drink";
            button14.Text = "Koktail";
            button16.Text = "->";
            button20.Visible = false;
            button19.Visible = false;
            button18.Visible = false;
            button17.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Text = "Soyuq içkilər";
            button13.Text = "Alkoqollu";
            button14.Text = "Alkoqolsuz";
            button16.Text = "Kofe";
            button20.Visible = true;
            button19.Visible = true;
            button20.Text = "Şərab";
            button19.Text = "->";
            button18.Visible = false;
            button17.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button15.Text = "Fanta";
            button13.Text = "Kola";
            button14.Text = "Sprite";
            button16.Text = "Tonik";
            button20.Text = "->";
            button19.Visible = false;
            button18.Visible = false;
            button17.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sprite | 8.00azn");
            listBox1.Items.Add("Comment: Limon");
        }
    }
}
