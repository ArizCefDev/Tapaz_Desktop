using Microsoft.Data.SqlClient;
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
    public partial class Emp : Form
    {
        public Emp()
        {
            InitializeComponent();
        }

        private const string conString = @"Server=WIN-VD08C7OPT8H\SQLEXPRESS;Database=ITDB; Trusted_Connection=True; Encrypt=False;";

        //SQL ile Elaqeni temin edir
        SqlConnection con = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string cmd = @"INSERT INTO Employee(Name,Salary,Age)
                             VALUES(@name, @salary, @age);";

                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@salary", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@age", textBox3.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Isci elave edildi");
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                MessageBox.Show(x.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        private void Emp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string cmd = @"SELECT * FROM Employee";

            SqlCommand sqlCommand = new SqlCommand(cmd, con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            con.Close();
        }
    }
}
