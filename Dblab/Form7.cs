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
	public partial class Advisor : Form
	{
		public Advisor()
		{
			InitializeComponent();
		}
		public int Flag1 = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;

		public Advisor(int f)
		{
			InitializeComponent();
			Flag1 = f;
		}

		private void DisplayAdvisor()
		{
			/* Student.Id, Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender
			*/
			con1.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT Person.Id, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation, Advisor.Salary  FROM Person JOIN Advisor ON Person.Id =  Advisor.Id ", con1);
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

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();

		}

		private void addStudt_Click(object sender, EventArgs e)
		{
			this.Hide();
			Add_Advisor f4 = new Add_Advisor();
			f4.ShowDialog();
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con1.Open();

			int UP_Row = int.Parse(e.RowIndex.ToString());
			int UP_RowIndex = int.Parse(e.ColumnIndex.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[UP_Row].Cells[0].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;

			if (UP_RowIndex == 10)
			{
				if (UP_RowIndex == 1)

					if (UP_RowIndex == 0)
					{
						MessageBox.Show("lala");
					}
				if (UP_RowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to Update this?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						Add_Advisor s = new Add_Advisor(dd);
						ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
						s.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						s.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
						s.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
						s.textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
						s.dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
						s.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
						if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "")
						{
							s.comboBox1.Text = "";
						}
						else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value) == 1)
						{
							s.comboBox1.Text = "Male";
						}
						else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value) == 2)
						{
							s.comboBox1.Text = "Female";

						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 6)
						{
							s.comboBox2.Text = "Professor";
						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 7)
						{
							s.comboBox2.Text = "Associate Professor";
						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 8)
						{
							s.comboBox2.Text = "Assisstant Professor";
						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 9)
						{
							s.comboBox2.Text = "Lecturer";
						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value) == 10)
						{
							s.comboBox2.Text = "Industry Professional";
						}
						s.ShowDialog();
						con1.Close();
					}
					else
					{
						con1.Close();
						this.Hide();
						Advisor f2 = new Advisor();
						f2.ShowDialog();
						DisplayAdvisor();
					}
				}
			}
			else if (UP_RowIndex == 9)
			{
				int URow = int.Parse(e.RowIndex.ToString());
				int URowIndex = int.Parse(e.ColumnIndex.ToString());
				ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());

				if (URowIndex == 0)
				{
					MessageBox.Show("Click on Delete Again");
				}
				if (URowIndex != 0)
				{
					var askfirst = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);
					if (askfirst == DialogResult.Yes)
					{
						cmd1 = new SqlCommand("DELETE FROM Person where ID = @Id", con1);
						cmd2 = new SqlCommand("DELETE FROM Advisor where ID = @Id", con1);
						cmd2.Parameters.AddWithValue("@Id", ID);
						cmd1.Parameters.AddWithValue("@Id", ID);
						cmd2.ExecuteNonQuery();
						cmd1.ExecuteNonQuery();

						con1.Close();
						MessageBox.Show("Deleted Succesfully");

						this.Hide();
						Advisor f2 = new Advisor();
						f2.ShowDialog();
						this.Close();
					}
					else
					{
						con1.Close();
						this.Hide();
						Advisor f2 = new Advisor();
						f2.ShowDialog();
						DisplayAdvisor();

					}
				}
			}
			else
			{
				con1.Close();
			}
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Advisor_Load(object sender, EventArgs e)
		{
			DisplayAdvisor();
		}
	}
}
