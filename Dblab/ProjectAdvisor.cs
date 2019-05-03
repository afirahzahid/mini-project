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
	public partial class ProjectAdvisor : Form
	{
		public int Flagg = 0;
		public int Flagg2 = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		int ID = 0;
		int ID1 = 0;
		public ProjectAdvisor()
		{
			InitializeComponent();
			Flagg = 0;
		}

		public ProjectAdvisor(int f)
		{
			InitializeComponent();
			Flagg = f;
			Flagg2 = f;
		}

		private void DisplayGroup()
		{
			SqlDataAdapter adp;
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT AdvisorId, ProjectId, Title, AdvisorRole, AssignmentDate FROM ProjectAdvisor JOIN Project ON ProjectAdvisor.ProjectId = Project.Id", con);
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

		private void ProjectAdvisor_Load(object sender, EventArgs e)
		{
			fillcombo();
			DisplayGroup();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		public void fillcombo()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Title from [dbo].[Project]", con);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);

			comboBox1.DisplayMember = "Title";
			comboBox1.DataSource = dt;

			con.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void AddAdvisor_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddAdvisor f4 = new AddAdvisor();
			f4.ShowDialog();
			this.Close();
		}
		bool projectId()
		{
			bool a = false;
			if (comboBox1.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}
		bool adRole()
		{
			bool b = false;
			if (comboBox2.Text == "")
			{
				b = true;
				return b;
			}
			return b;
		}

		bool adId()
		{
			bool b = false;
			if (textBox1.Text == "")
			{
				b = true;
				return b;
			}
			return b;
		}
		bool StId_Exists(int A_Id, string P_Id)
		{
			con.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from ProjectAdvisor Join Project ON ProjectAdvisor.ProjectId = Project.Id", con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (Convert.ToInt32(row["AdvisorId"]) == A_Id && (row["Title"].ToString()) == P_Id)
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
			bool x = adId();
			if (x == false)
			{
				bool a = projectId();
				if (a == false)
				{
					bool t = adRole();
					if (t == false)
					{
						bool c = StId_Exists(Convert.ToInt32(textBox1.Text), comboBox1.Text);
						if (c == false)
						{
							if (Flagg2 == 0)
							{
								con.Open();
								string ProjectId = string.Format("SELECT Id From Project WHERE Title = '{0}'", comboBox1.Text);
								SqlCommand cmd = new SqlCommand(ProjectId, con);
								int p = (Int32)cmd.ExecuteScalar();

								string RoleId = string.Format("SELECT Id From Lookup WHERE Value = '{0}'", comboBox2.Text);
								SqlCommand cmd2 = new SqlCommand(RoleId, con);
								int s = (Int32)cmd2.ExecuteScalar();
								DateTime time = DateTime.Now;
								cmd2 = new SqlCommand("insert into ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) values ('" + textBox1.Text + "','" + p + "','" + s + "' , @time)", con);
								cmd2.Parameters.AddWithValue("@time", time);
								//int gI = Convert.ToInt32(comboBox1.Text);
								cmd2.ExecuteNonQuery();
								MessageBox.Show("Inserted Successfully");
								con.Close();
								this.Hide();
								ProjectAdvisor f4 = new ProjectAdvisor();
								f4.ShowDialog();
								this.Close();
							}
							if (Flagg2 > 0)
							{
								con.Open();
								string ProjectId = string.Format("SELECT Id From Project WHERE Title = '{0}'", comboBox1.Text);
								SqlCommand cmd = new SqlCommand(ProjectId, con);
								int p = (Int32)cmd.ExecuteScalar();

								string RoleId = string.Format("SELECT Id From Lookup WHERE Value = '{0}'", comboBox2.Text);
								SqlCommand cmd2 = new SqlCommand(RoleId, con);
								int s = (Int32)cmd2.ExecuteScalar();
								DateTime time = DateTime.Now;
								cmd2 = new SqlCommand("UPDATE ProjectAdvisor set AdvisorId = @AdvisorId , ProjectId = @ProjectId, AdvisorRole = @AdvisorRole, AssignmentDate = @AssignmentDate WHERE AdvisorId = @d1 AND ProjectId = @d2", con);
								cmd2.Parameters.AddWithValue("@d1", Flagg2);
								cmd2.Parameters.AddWithValue("@d2", ID1);
								cmd2.Parameters.AddWithValue("@AdvisorId", Convert.ToInt32(textBox1.Text));
								cmd2.Parameters.AddWithValue("@ProjectId", Convert.ToInt32(p));
								cmd2.Parameters.AddWithValue("@AdvisorRole", s);
								cmd2.Parameters.AddWithValue("@AssignmentDate", time);
								cmd2.ExecuteNonQuery();
								MessageBox.Show("Updated successfully Successfully");
								con.Close();
								this.Hide();
								ProjectAdvisor f4 = new ProjectAdvisor();
								f4.ShowDialog();
								this.Close();
							}
						}
						else
						{
							MessageBox.Show("This project is already assigned to this Advisor");
						}

					}
					else
					{
						MessageBox.Show("Select Advisor role");
					}
				}
				else
				{
					MessageBox.Show("First add projects");
				}
			}
			else
			{
				MessageBox.Show("Select Addvisor");
			}
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[URow].Cells[1].Value.ToString());
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
					var askfirst1 = MessageBox.Show("Are you sure you want to chnage project of this advisor?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						Flagg2 = ID;

                        SqlDataAdapter sd = new SqlDataAdapter("Select * From project", con);
                        DataTable　ds = new DataTable();
                        sd.Fill(ds);
                        foreach(DataRow row in ds.Rows)
                        {
                            if(row["Id"].ToString() == dataGridView1.Rows[e.RowIndex].Cells["ProjectId"].FormattedValue.ToString())
                            {
                                comboBox1.Text = row["Title"].ToString();
                            }
                        }
						
						textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) == 11)
						{
							comboBox2.Text = "Main Advisor";
						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) == 12)
						{
							comboBox2.Text = "Co-Advisror";
						}
						if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) == 14)
						{
							comboBox2.Text = "Industry Advisor";
						}
						con.Close();

					}
					else
					{
						Flagg2 = 0;
						con.Close();
						this.Hide();
						ProjectAdvisor f2 = new ProjectAdvisor();
						f2.ShowDialog();

					}
				}
			}
			else if (URowIndex == 6)
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
						cmd1 = new SqlCommand("DELETE FROM ProjectAdvisor where AdvisorId = @Id AND ProjectId = @Id1", con);
						cmd1.Parameters.AddWithValue("@Id", ID);
						cmd1.Parameters.AddWithValue("@Id1", ID1);
						cmd1.ExecuteNonQuery();

						con.Close();
						MessageBox.Show("Deleted Succesfully");

						this.Hide();
						ProjectAdvisor f2 = new ProjectAdvisor();
						f2.ShowDialog();
						this.Close();
					}
					else
					{
						con.Close();
						this.Hide();
						ProjectAdvisor f2 = new ProjectAdvisor();
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

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
