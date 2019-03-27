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
	public partial class AddGroupStudent : Form
	{
		public int Flagg = 0;
		public int Flagg2 = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		int ID = 0;
		int ID1 = 0;

		public AddGroupStudent()
		{
			InitializeComponent();
			Flagg = 0;
		}

		public AddGroupStudent(int f)
		{
			InitializeComponent();
			Flagg2 = f;
			Flagg = f;
		
		}
		
		public void fillcombo()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Id from [dbo].[Group]", con);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);

			comboBox1.DisplayMember = "Id";
			comboBox1.DataSource = dt;

			con.Close();
		}

		private void DisplayGroup()
		{
			SqlDataAdapter adp;
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT GroupId, Created_On, StudentId, Status, AssignmentDate FROM [dbo].[Group] JOIN GroupStudent ON [Group].Id = GroupStudent.GroupId", con);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;

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
			con.Close();
		}

		private void CreateGroup_Click(object sender, EventArgs e)
		{
			con.Open();
			DateTime t = DateTime.Now;
			cmd1 = new SqlCommand("insert into [Group](Created_On) values (@tt)", con);
			cmd1.Parameters.AddWithValue("@tt", t);
			cmd1.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Created");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[URow].Cells[2].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;

			if (URowIndex == 5)
			{
				int d1 = (int)dataGridView1.CurrentRow.Cells[0].Value;
				if (URowIndex == 0)
				{
					MessageBox.Show("Click again");
					con.Close();
				}
				if (URowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to Update this?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						Flagg2 = ID;

						comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
						con.Close();

					}
					else
					{
						Flagg2 = 0;
						con.Close();
						this.Hide();
						AddGroupStudent f2 = new AddGroupStudent();
						f2.ShowDialog();

			 		}
				}
			}
			else
			{
				Flagg2 = 0;
				con.Close();
			}
		}

		private void Show_Click(object sender, EventArgs e)
		{
			DisplayGroup();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		bool StId_Exists(int St_Id, int G_Id)
		{
			con.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from GroupStudent", con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (Convert.ToInt32(row["StudentId"]) == St_Id && Convert.ToInt32(row["GroupId"]) == G_Id)
				{
					con.Close();
					return true;
				}
			}
			con.Close();
			return a;
		}

		bool Empty_St()
		{
			bool a = false;
			if (textBox2.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}

		private void Create_Click(object sender, EventArgs e)
		{
			bool b = Empty_St();
			if (b == false)
			{
				bool std = StId_Exists(Convert.ToInt32(textBox2.Text), Convert.ToInt32(comboBox1.Text));
				if (std == false)
				{
					if (Flagg2 == 0)
					{
						con.Open();
						string StatusId = string.Format("SELECT Id From Lookup WHERE Value = '{0}'", "Active");
						SqlCommand cmd3 = new SqlCommand(StatusId, con);
						int s = (Int32)cmd3.ExecuteScalar();
						DateTime time = DateTime.Now;
						cmd2 = new SqlCommand("insert into GroupStudent(GroupId, StudentId, Status, AssignmentDate) values ('" + comboBox1.Text + "','" + textBox2.Text + "','" + s + "' , @time)", con);
						cmd2.Parameters.AddWithValue("@time", time);
						int gI = Convert.ToInt32(comboBox1.Text);
						cmd2.ExecuteNonQuery();
						MessageBox.Show("Inserted Successfully");
						con.Close();
						this.Hide();
						AddGroupStudent f4 = new AddGroupStudent();
						f4.ShowDialog();
						this.Close();
					}
					if (Flagg2 > 0)
					{
						con.Open();
						string StatusId = string.Format("SELECT Id From Lookup WHERE Value = '{0}'", "Active");
						SqlCommand cmd3 = new SqlCommand(StatusId, con);
						int s = (Int32)cmd3.ExecuteScalar();
						DateTime time = DateTime.Now;
						cmd1 = new SqlCommand("UPDATE [GroupStudent] set GroupStudent.GroupId=@GroupId, GroupStudent.StudentId=@StudentId  WHERE GroupId = @dd AND StudentId = @d1 ", con);

						cmd1.Parameters.AddWithValue("@dd", Flagg2);
						cmd1.Parameters.AddWithValue("@d1", ID1);
						cmd1.Parameters.AddWithValue("@GroupId", Convert.ToInt32(comboBox1.Text));
						cmd1.Parameters.AddWithValue("@StudentId", Convert.ToInt32(textBox2.Text));
						cmd1.ExecuteNonQuery();

						string store_value = comboBox1.Text;

						string StatusNId = string.Format("SELECT Id From Lookup WHERE Value = '{0}'", "InActive");
						SqlCommand cmdN3 = new SqlCommand(StatusNId, con);
						int sN = (Int32)cmdN3.ExecuteScalar();
						cmd2 = new SqlCommand("UPDATE [GroupStudent] set GroupStudent.Status = @Status WHERE GroupId != @d2 AND StudentId = @d3", con);
						cmd2.Parameters.AddWithValue("@d3", ID1);
						cmd2.Parameters.AddWithValue("@d2", store_value);
						cmd2.Parameters.AddWithValue("@Status", 4);
						cmd2.ExecuteNonQuery();
						MessageBox.Show("Updated Successfully");
						con.Close();
						this.Hide();
						AddGroupStudent f4 = new AddGroupStudent();
						f4.ShowDialog();
						this.Close();

					}
				}
				else
				{
					MessageBox.Show("This students exists in this group already");
				}
			}
			else
			{
				MessageBox.Show("Select Student From Add Student");
			}
			
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		

		private void AddGroupStudent_Load(object sender, EventArgs e)
		{
			fillcombo();
			DisplayGroup();
		}

		private void Add_Students_Click(object sender, EventArgs e)
		{
			this.Hide();
			FromStudents f4 = new FromStudents();
			f4.ShowDialog();
			this.Close();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}
	}
}
