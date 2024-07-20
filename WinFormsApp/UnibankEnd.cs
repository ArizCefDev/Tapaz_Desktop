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
    public partial class UnibankEnd : Form
    {
        public UnibankEnd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unibank u = new Unibank();
            u.Show();
        }

        private void UnibankEnd_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm");
            label6.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
