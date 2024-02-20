using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DB;

namespace WinFormsApp
{
    public partial class Base : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.conString);
        public Base()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login next = new Login();
            next.Show();
        }

        private void Base_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = @"INSERT INTO NewProduct(Category, City, Price, Subject, Name, Email, Contact, Phone)
                                             VALUES(@category, @city, @price, @subject, @name, @email, @contact, @phone)";

                SqlCommand command = new SqlCommand(script, connection);
                command.Parameters.AddWithValue("@category", comboBox1.Text);
                command.Parameters.AddWithValue("@city", comboBox2.Text);
                command.Parameters.AddWithValue("@price", textBox1.Text);
                command.Parameters.AddWithValue("@subject", richTextBox1.Text);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                command.Parameters.AddWithValue("@email", textBox3.Text);
                command.Parameters.AddWithValue("@contact", comboBox3.Text);
                command.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Elan əlavə edildi");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
            finally
            {
                connection.Close();
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
