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
    public partial class Login : Form
    {
        char simbol;
        bool cleanDisplay;
        decimal oneNumber;
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            cleanDisplay = true;
        }


        private void c_btn_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            cleanDisplay = true;
        }

        private void btn_sifir_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }
        private void btn_noqte_Click(object sender, EventArgs e)
        {
            if (cleanDisplay)
            {
                label1.Text = "";
                cleanDisplay = false;
            }
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void bolme_btn_Click(object sender, EventArgs e)
        {
            simbol = '/';
            cleanDisplay = true;
            oneNumber = Convert.ToDecimal(label1.Text);

            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void vurma_btn_Click(object sender, EventArgs e)
        {
            simbol = '*';
            cleanDisplay = true;
            oneNumber = Convert.ToDecimal(label1.Text);

            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void cixma_btn_Click(object sender, EventArgs e)
        {
            simbol = '-';
            cleanDisplay = true;
            oneNumber = Convert.ToDecimal(label1.Text);

            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void toplama_btn_Click(object sender, EventArgs e)
        {
            simbol = '+';
            cleanDisplay = true;
            oneNumber = Convert.ToDecimal(label1.Text);

            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void beraber_btn_Click(object sender, EventArgs e)
        {
            decimal twoNumber = Convert.ToDecimal(label1.Text);
            decimal total;

            switch (simbol)
            {
                case '+':
                    total = oneNumber + twoNumber;
                    break;
                case '-':
                    total = oneNumber - twoNumber;
                    break;
                case '/':
                    total = oneNumber / twoNumber;
                    break;
                case '*':
                    total = oneNumber * twoNumber;
                    break;
                default:
                    total = 0;
                    break;
            }
            label1.Text = total.ToString();
        }


    }
}
