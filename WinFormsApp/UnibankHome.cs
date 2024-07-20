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
    public partial class UnibankHome : Form
    {
        public UnibankHome()
        {
            InitializeComponent();
        }

        private void UnibankHome_Load(object sender, EventArgs e)
        {

            label5.Text = DateTime.Now.ToString("HH:mm");
            label6.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Unibank u = new Unibank();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnibankMoney um = new UnibankMoney();
            um.Show();
        }
    }
}
