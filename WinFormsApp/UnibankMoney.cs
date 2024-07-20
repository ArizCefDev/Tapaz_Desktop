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
    public partial class UnibankMoney : Form
    {
        public UnibankMoney()
        {
            InitializeComponent();
        }

        private void UnibankMoney_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm");
            label6.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Unibank u = new Unibank();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double balance = 100;
            double cixarilan = 50;
            UnibankEnd ue = new UnibankEnd();
            if (balance > cixarilan)
            {
                ue.label12.Text = "Lütfən pulunuzu götürün.";
            }
            else
            {
                ue.label12.Text = "Balans kifayət qədər deyil.";
            }
            ue.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
