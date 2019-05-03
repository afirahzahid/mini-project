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
	public partial class ManageGroupProject : Form
	{
		public int Flagg = 0;
		public int Flagg2 = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		int ID = 0;
		int ID1 = 0;
		public ManageGroupProject()
		{
			InitializeComponent();
			Flagg = 0;
		}

		
		public ManageGroupProject(int f)
		{
			InitializeComponent();
			Flagg = f;
			Flagg2 = f;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[URow].Cells[1].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;

			if (URowIndex == 4)
			{
				int d1 = (int)dataGridView1.CurrentRow.Cells[0].Value;
				if (URowIndex == 0)
				{
					MessageBox.Show("Click again");
					con.Close();
				}
				if (URowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to change the project of this group?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						Flagg2 = ID;
						textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						con.Close();

					}
					else
					{
						Flagg2 = 0;
						con.Close();
						this.Hide();
						ManageGroupProject f2 = new ManageGroupProject();
						f2.ShowDialog();

					}
				}
			}
			else if (URowIndex == 5)
			{
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
						cmd1 = new SqlCommand("DELETE FROM [GroupProject] WHERE GroupId = @d1 AND [ProjectId] = @d2", con);
						cmd1.Parameters.AddWithValue("@d1", ID);
						cmd1.Parameters.AddWithValue("@d2", ID1);
						cmd1.ExecuteNonQuery();

						con.Close();
						MessageBox.Show("Deleted Succesfully");

						this.Hide();
						ManageGroupProject f2 = new ManageGroupProject();
						f2.ShowDialog();
						this.Close();
					}
					else
					{
						con.Close();
						this.Hide();
						ManageGroupProject f2 = new ManageGroupProject();
						f2.ShowDialog();
					}
				}
				else
				{
					Flagg2 = 0;
					con.Close();
				}
			}
		}

		private void Add_Group_Click(object sender, EventArgs e)
		{
			this.Hide();
			FromProjectStudent f4 = new FromProjectStudent();
			f4.ShowDialog();
			this.Close();
		}

		bool G_Id()
		{
			bool a = false;
			if (textBox1.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}
		bool P_Id()
		{
			bool a = false;
			if (comboBox1.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}
		bool Group_Exists(int G_Id, int P_Id)
		{
			con.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from [GroupProject]", con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (Convert.ToInt32(row["GroupId"]) == G_Id && Convert.ToInt32(row["ProjectId"]) == P_Id)
				{
					con.Close();
					return true;
				}
			}
			con.Close();
			return a;
		}

		private void Insert_Click(object sender, EventArgs e)
		{
			bool a = G_Id();
			if (a == false)
			{
				bool b = P_Id();
				if (b == false)
				{
					bool d = Group_Exists(Convert.ToInt32(textBox1.Text), Convert.ToInt32(comboBox1.Text));
					if (d == false)
					{
						if (Flagg2 == 0)
						{
							con.Open();
							DateTime time = DateTime.Now;
							cmd2 = new SqlCommand("insert into [GroupProject]([GroupId], ProjectId, AssignmentDate) values ('" + textBox1.Text + "','" + comboBox1.Text + "', @time)", con);
							cmd2.Parameters.AddWithValue("@time", time);
							cmd2.ExecuteNonQuery();
							MessageBox.Show("Inserted Successfully");
							con.Close();
							this.Hide();
							ManageGroupProject f4 = new ManageGroupProject();
							f4.ShowDialog();
							this.Close();
						}

						if (Flagg2 > 0)
						{
							con.Open();
							DateTime time = DateTime.Now;
							cmd2 = new SqlCommand("UPDATE [GroupProject] set GroupId = @GroupId, ProjectId = @ProjectId, AssignmentDate = @AssignmentDate WHERE GroupId = @d1 AND [ProjectId] = @d2", con);
							cmd2.Parameters.AddWithValue("@d1", Flagg2);
							cmd2.Parameters.AddWithValue("@d2", ID1);
							cmd2.Parameters.AddWithValue("@GroupId", Convert.ToInt32(textBox1.Text));
							cmd2.Parameters.AddWithValue("@ProjectId", Convert.ToInt32(comboBox1.Text));
							cmd2.Parameters.AddWithValue("@AssignmentDate", time);
							cmd2.ExecuteNonQuery();
							MessageBox.Show("Updated Successfully");
							con.Close();
							this.Hide();
							ManageGroupProject f4 = new ManageGroupProject();
							f4.ShowDialog();
							this.Close();
						}
					}
					else
					{
						MessageBox.Show("This Project Id is already assigned to this group");
					}
				}
				else
				{
					MessageBox.Show("Select Evaluation Id");
				}
			}
			else
			{
				MessageBox.Show("Add Group");
			}
		}

		public void fillcombo()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Id from [dbo].[Project]", con);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);

			comboBox1.DisplayMember = "Id";
			comboBox1.DataSource = dt;

			con.Close();
		}

		private void DisplayGroupProject()
		{
			SqlDataAdapter adp;
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT [GroupId], [ProjectId], Title, AssignmentDate FROM [GroupProject] JOIN [Project] ON [GroupProject].ProjectId = [Project].Id", con);
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
			DataGridViewButtonColumn DeleteData;
			DeleteData = new DataGridViewButtonColumn();
			DeleteData.HeaderText = "Delete";
			DeleteData.Text = "Delete";
			DeleteData.UseColumnTextForButtonValue = true;
			DeleteData.Width = 60;
			dataGridView1.Columns.Add(DeleteData);
			int a = 0;
			while (a < dataGridView1.Rows.Count)
			{
				dataGridView1.Rows[a].Cells[0].ReadOnly = true;
				a++;
			}
			con.Close();
		}

		private void ManageGroupProject_Load(object sender, EventArgs e)
		{
			fillcombo();
			DisplayGroupProject();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
