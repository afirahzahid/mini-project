using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Dblab
{
	public partial class PersonInformation : Form
	{
		SqlCommand cmd3;
		SqlDataAdapter sda;
		SqlCommandBuilder scb;
		DataTable dt;
		int ID = 0;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		public PersonInformation()
		{
			InitializeComponent();
		}

		private void PersonInformation_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*
			con1.Open();
			DataTable dt = new DataTable();
			sda = new SqlDataAdapter("SELECT * FROM Student JOIN Person ON Student.Id = Person.Id ", con1);
			sda.Fill(dt);
			dataGridView1.DataSource = dt;

			/*ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			string RegNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			string PId = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			string FirstName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			string LastName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			string Contact = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			string Email = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			string DOB = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			string Gender = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			
			con1.Close();
			*/
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			

		}

		private void Show_Click(object sender, EventArgs e)
		{
			sda = new SqlDataAdapter("SELECT RegistrationNo, FirstName, LastName, Contact, Email, DateOfBirth, Gender From Person, Student", con1);
			dt = new DataTable();
			sda.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void Update_Click(object sender, EventArgs e)
		{
			scb = new SqlCommandBuilder(sda);
			sda.Update(dt);
		}
	}
}
