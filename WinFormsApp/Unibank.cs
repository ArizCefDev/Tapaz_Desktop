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
    public partial class Unibank : Form
    {
        public Unibank()
        {
            InitializeComponent();
        }

        double balance = 0;
        private void Unibank_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm");
            label6.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string psw = textBox1.Text;
            if (psw == "1122")
            {
                UnibankHome uh = new UnibankHome();
                balance = 70;
                uh.label10.Text = $"{balance} azn";
                uh.label12.Text = "6363 4664 3736 3773";
                uh.Show();
            }
            else if (psw == "2233")
            {
                UnibankHome uh = new UnibankHome();
                balance = 100;
                uh.label10.Text = $"{balance} azn";
                uh.label12.Text = "5353 9292 1726 1726";
                uh.Show();
            }
            else
            {
                label8.Visible = true;
            }
        }
    }
}
