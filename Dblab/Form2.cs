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
	public partial class Student : Form
	{
		public int Flag = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con1 = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;
		public Student()
		{
			InitializeComponent();
		}

		public Student(int f)
		{
			InitializeComponent();
			Flag = f;
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
			deleteB.HeaderText = "Delete";
			deleteB.Text = "Delete";
			deleteB.UseColumnTextForButtonValue = true;
			deleteB.Width = 60;
			dataGridView1.Columns.Add(deleteB);
			int a = 0;
			while (a < dataGridView1.Rows.Count)
			{
				dataGridView1.Rows[a].Cells[0].ReadOnly = true;
				a++;
			}

			DataGridViewButtonColumn UpData;
			UpData = new DataGridViewButtonColumn();
			UpData.HeaderText = "Update";
			UpData.Text = "Update";
			UpData.UseColumnTextForButtonValue = true;
			UpData.Width = 60;
			dataGridView1.Columns.Add(UpData);
			int b = 0;
			while (b < dataGridView1.Rows.Count)
			{
				dataGridView1.Rows[b].Cells[0].ReadOnly = true;
				b++;
			}
			con1.Close();
		}
		private void Save_Click(object sender, EventArgs e)
		{
			
		}

		private void Delete_Click(object sender, EventArgs e)
		{

		}
		private void Student_Load(object sender, EventArgs e)
		{
			DisplayStudent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con1.Open();
			
			int UP_Row = int.Parse(e.RowIndex.ToString());
			int UP_RowIndex = int.Parse(e.ColumnIndex.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[UP_Row].Cells[0].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;
			if (UP_RowIndex == 9)
			{
				if (UP_RowIndex == 1)

					if (UP_RowIndex == 0)
					{
						MessageBox.Show("Click Again");
					}
				if (UP_RowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to Update this?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						AddStudent s = new AddStudent(dd);
						ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
						s.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						s.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
						s.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
						s.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
						s.textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
						s.dateTimePicker1.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
						if (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() == "")
						{
							s.comboBox1.Text = "";
						}

						else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 1)
						{
							s.comboBox1.Text = "Male";
						}
						else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 2)
						{
							s.comboBox1.Text = "Female";
						}
						s.ShowDialog();
						con1.Close();	
					}
					else
					{
						con1.Close();
						this.Hide();
						Student f2 = new Student();
						f2.ShowDialog();
						DisplayStudent();
					}
				}
			}
			else if (UP_RowIndex == 8)
			{
				int URow = int.Parse(e.RowIndex.ToString());
				int URowIndex = int.Parse(e.ColumnIndex.ToString());
				ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());

				if (URowIndex == 0)
				{
					MessageBox.Show("lala");
				}
				if (URowIndex != 0)
				{
					var askfirst = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);
					if (askfirst == DialogResult.Yes)
					{
						cmd1 = new SqlCommand("DELETE FROM Person where ID = @Id", con1);
						cmd2 = new SqlCommand("DELETE FROM Student where ID = @Id", con1);
						cmd2.Parameters.AddWithValue("@Id", ID);
						cmd1.Parameters.AddWithValue("@Id", ID);
						cmd2.ExecuteNonQuery();
						cmd1.ExecuteNonQuery();

						con1.Close();
						MessageBox.Show("Deleted Succesfully");

						this.Hide();
						Student f2 = new Student();
						f2.ShowDialog();
						this.Close();
					}
					else
					{
						con1.Close();
						this.Hide();
						Student f2 = new Student();
						f2.ShowDialog();
						DisplayStudent();
					}
				}
			}
			else
			{
				con1.Close();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ShowData_Click(object sender, EventArgs e)
		{
			DisplayStudent();
			
		}

		private void Delete1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Project f3 = new Project();
			f3.ShowDialog();
			f3.Close();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

		private void Gender_Click(object sender, EventArgs e)
		{

		}

		private void DOB_Click(object sender, EventArgs e)
		{

		}

		private void Email_Click(object sender, EventArgs e)
		{

		}

		private void Contact_Click(object sender, EventArgs e)
		{

		}

		private void LastName_Click(object sender, EventArgs e)
		{

		}

		private void FirstName_Click(object sender, EventArgs e)
		{

		}

		private void RegNo_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void addStudt_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddStudent f4 = new AddStudent();
			f4.ShowDialog();
			this.Close();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
