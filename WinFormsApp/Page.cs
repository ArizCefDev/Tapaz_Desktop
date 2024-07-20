using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
	public partial class Page : Form
	{
		public Page()
		{
			InitializeComponent();
		}

		static string conString = @"Server=WIN-VD08C7OPT8H\\SQLEXPRESS; 
                        Database=CourseDB; 
                 Trusted_Connection=true; Encrypt=false;";

		SqlConnection connect = new SqlConnection(conString); //sql ile C# baglamaq

		private void Page_Load(object sender, EventArgs e)
		{

		}



		private void button1_Click_1(object sender, EventArgs e)
		{
			connect.Open();
			string cmd = "SELECT * FROM Employee";
			SqlCommand sqlCommand = new SqlCommand(cmd, connect); //cmd ni emre cevirir
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand); //datanin gedis gelisi
			DataTable dt = new DataTable(); //Cedvel qurur
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			connect.Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			connect.Open();
			string cmd = "INSERT INTO Employee(E_name,E_salary,E_Age) VALUES(@name,@salary,@age)";
			SqlCommand sqlCommand = new SqlCommand(cmd, connect);
			sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
			sqlCommand.Parameters.AddWithValue("@salary", textBox2.Text);
			sqlCommand.Parameters.AddWithValue("@age", textBox3.Text);
			sqlCommand.ExecuteNonQuery();

			MessageBox.Show("Add Employee");
			connect.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//update
		}

		//public void Delete(int id)
		//{
		//	connect.Open();
		//	string cmd = "DELETE FROM Employee WHERE id=@id";
		//	SqlCommand sqlCommand = new SqlCommand(cmd, connect);
		//	sqlCommand.Parameters.AddWithValue("@id", id);
		//	sqlCommand.ExecuteNonQuery();
		//	connect.Close();

		//}
		private void button4_Click(object sender, EventArgs e)
		{
			//delete

		}
	}
}
