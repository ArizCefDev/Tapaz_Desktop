using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Admin : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.conString);
        public Admin()
        {
            InitializeComponent();
        }
        public void GetAll()
        {
            try
            {
                connection.Open();
                string script = "SELECT * FROM NewProduct";
                SqlCommand command = new SqlCommand(script, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = "SELECT * FROM NewProduct WHERE Name=@name";
                SqlCommand command = new SqlCommand(script, connection);
                command.Parameters.AddWithValue("@name", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

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

        public void Delete(int id)
        {

            try
            {
                connection.Open();
                string script = "DELETE FROM NewProduct WHERE ID=@id";
                SqlCommand command = new SqlCommand(script, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Melumat ugurla silindi");

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
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                Delete(id);
                GetAll();
            }
        }

        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string script = @"UPDATE NewProduct SET Name=@name";

                //string script = @"UPDATE NewProduct SET 
                //                   Category=@category, City=@city, Price=@price, Subject=@subject, 
                //                   Name=@name, Email=@email, Contact=@contact, Phone=@phone";

                SqlCommand command = new SqlCommand(script, connection);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                //command.Parameters.AddWithValue("@city", comboBox2.Text);
                //command.Parameters.AddWithValue("@price", textBox1.Text);
                //command.Parameters.AddWithValue("@subject", richTextBox1.Text);
                //command.Parameters.AddWithValue("@name", textBox2.Text);
                //command.Parameters.AddWithValue("@email", textBox3.Text);
                //command.Parameters.AddWithValue("@contact", comboBox3.Text);
                //command.Parameters.AddWithValue("@phone", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Elan Redakte edildi");
                GetAll();

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox2.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
