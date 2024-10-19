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
    public partial class Form5 : Form
    {

        decimal price = 0;
        decimal result = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] markas = { "HP", "Asus", "Samsung", "Apple" };
            string[] prosessors = { "i3", "i5", "i7", "i8", "i9" };
            string[] rams = { "4", "8", "16", "32", "64" };
            string[] os = { "Windows", "Linux", "MacOS", "Unix" };
            string[] disks = { "SSD", "HDD" };
            string[] colors = { "Qara", "Ağ", "Boz" };

            decimal memories = Convert.ToDecimal(textBox1.Text);
            decimal monitors = Convert.ToDecimal(textBox2.Text);

            //Marka
            if (comboBox1.Text == markas[0])
            {
                price = 200.00M;
                result = result + price;
                label11.Text = $"{price.ToString()}azn";
            }
            else if (comboBox1.Text == markas[1])
            {
                price = 100.00M;
                result = result + price;
                label11.Text = $"{price.ToString()}azn";
            }
            else if (comboBox1.Text == markas[2])
            {
                price = 300.00M;
                result = result + price;
                label11.Text = $"{price.ToString()}azn";
            }
            else if (comboBox1.Text == markas[3])
            {
                price = 400.00M;
                result = result + price;
                label11.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label11.Text = $"{price.ToString()}azn";
            }

            //Prosessors
            if (comboBox2.Text == prosessors[0])
            {
                price = 20.00M;
                result = result + price;
                label12.Text = $"{price.ToString()}azn";
            }
            else if (comboBox2.Text == prosessors[1])
            {
                price = 50.00M;
                result = result + price;
                label12.Text = $"{price.ToString()}azn";
            }
            else if (comboBox2.Text == prosessors[2])
            {
                price = 80.00M;
                result = result + price;
                label12.Text = $"{price.ToString()}azn";
            }
            else if (comboBox2.Text == prosessors[3])
            {
                price = 100.00M;
                result = result + price;
                label12.Text = $"{price.ToString()}azn";
            }
            else if (comboBox2.Text == prosessors[4])
            {
                price = 150.00M;
                result = result + price;
                label12.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label12.Text = $"{price.ToString()}azn";
            }

            //RAM
            if (comboBox3.Text == rams[0])
            {
                price = 40.00M;
                result = result + price;
                label14.Text = $"{price.ToString()}azn";
            }
            else if (comboBox3.Text == rams[1])
            {
                price = 60.00M;
                result = result + price;
                label14.Text = $"{price.ToString()}azn";
            }
            else if (comboBox3.Text == rams[2])
            {
                price = 90.00M;
                result = result + price;
                label14.Text = $"{price.ToString()}azn";
            }
            else if (comboBox3.Text == rams[3])
            {
                price = 130.00M;
                result = result + price;
                label14.Text = $"{price.ToString()}azn";
            }
            else if (comboBox3.Text == rams[4])
            {
                price = 160.00M;
                result = result + price;
                label14.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label14.Text = $"{price.ToString()}azn";
            }



            //OS
            if (comboBox8.Text == os[0])
            {
                price = 30.00M;
                result = result + price;
                label16.Text = $"{price.ToString()}azn";
            }
            else if (comboBox8.Text == os[1])
            {
                price = 50.00M;
                result = result + price;
                label16.Text = $"{price.ToString()}azn";
            }
            else if (comboBox8.Text == os[2])
            {
                price = 170.00M;
                result = result + price;
                label16.Text = $"{price.ToString()}azn";
            }
            else if (comboBox8.Text == os[3])
            {
                price = 190.00M;
                result = result + price;
                label16.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label16.Text = $"{price.ToString()}azn";
            }

            //disk
            if (comboBox4.Text == disks[0])
            {
                price = 160.00M;
                result = result + price;
                label18.Text = $"{price.ToString()}azn";
            }
            else if (comboBox4.Text == disks[1])
            {
                price = 220.00M;
                result = result + price;
                label18.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label18.Text = $"{price.ToString()}azn";
            }

            //Memory
            if (memories == 128M)
            {
                price = 120.00M;
                result = result + price;
                label20.Text = $"{price.ToString()}azn";
            }
            else if (memories == 256M)
            {
                price = 220.00M;
                result = result + price;
                label20.Text = $"{price.ToString()}azn";
            }
            else if (memories == 512M)
            {
                price = 300.00M;
                result = result + price;
                label20.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label20.Text = $"{price.ToString()}azn";
            }

            //Monitor
            if (monitors <= 1000)
            {
                price = 50.00M;
                result = result + price;
                label24.Text = $"{price.ToString()}azn";
            }
            else if (monitors >= 1000)
            {
                price = 80.00M;
                result = result + price;
                label24.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label24.Text = $"{price.ToString()}azn";
            }

            //Color
            if (comboBox7.Text == colors[0])
            {
                price = 10.00M;
                result = result + price;
                label22.Text = $"{price.ToString()}azn";
            }
            else if (comboBox7.Text == colors[1])
            {
                price = 20.00M;
                result = result + price;
                label22.Text = $"{price.ToString()}azn";
            }
            else if (comboBox7.Text == colors[2])
            {
                price = 30.00M;
                result = result + price;
                label22.Text = $"{price.ToString()}azn";
            }
            else
            {
                price = 0.00M;
                result = result + price;
                label22.Text = $"{price.ToString()}azn";
            }

            label28.Text = $"{result.ToString()}azn";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox7.ResetText();
            comboBox8.ResetText();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sifarişiniz qəbul edildi. Lütfən gözləyin.");
        }
    }
}
