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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pin = { 1122, 2211 };

            if (textBox1.Text == pin[0].ToString())
            {
                Home home = new Home();
                home.Show();
            }
            else
            {
                label8.Visible = true;
            }
        }
    }
}
