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
	public partial class FromStudents : Form
	{
		public int Flags = 0;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;
		public FromStudents()
		{
			InitializeComponent();
		}

		public FromStudents(int f)
		{
			InitializeComponent();
			Flags = f;
		}

		private void DisplayStudent()
		{
			con1.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT Student.Id, RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender FROM Student JOIN Person ON Student.Id = Person.Id ", con1);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;

			DataGridViewButtonColumn deleteB;
			deleteB = new DataGridViewButtonColumn();
			deleteB.HeaderText = "Add";
			deleteB.Text = "Add";
			deleteB.UseColumnTextForButtonValue = true;
			deleteB.Width = 60;
			dataGridView1.Columns.Add(deleteB);
			int a = 0;
			while (a < dataGridView1.Rows.Count)
			{
				dataGridView1.Rows[a].Cells[0].ReadOnly = true;
				a++;
			}

			con1.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con1.Open();

			int UP_Row = int.Parse(e.RowIndex.ToString());
			int UP_RowIndex = int.Parse(e.ColumnIndex.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[UP_Row].Cells[0].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;
			if (UP_RowIndex == 8)
			{
				if (UP_RowIndex == 1)

					if (UP_RowIndex == 0)
					{
						MessageBox.Show("Click Again");
					}
				if (UP_RowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to add this student?", "Add", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						AddGroupStudent s = new AddGroupStudent(dd);
						ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
						s.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						s.Flagg2 = 0;
						s.ShowDialog();
						con1.Close();
						this.Close();
						
					}
					else
					{
						con1.Close();
						this.Hide();
						FromStudents f2 = new FromStudents();
						f2.ShowDialog();
					}
				}
			}
			else
			{
				MessageBox.Show("Click on add button");
			}
		}

		private void FromStudents_Load(object sender, EventArgs e)
		{
			DisplayStudent();
		}

		private void Go_back_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddGroupStudent f4 = new AddGroupStudent();
			f4.ShowDialog();
			this.Close();
		}
	}
}
