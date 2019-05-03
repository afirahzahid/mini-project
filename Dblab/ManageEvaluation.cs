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
	public partial class ManageEvaluation : Form
	{
		public int Flagg = 0;
		public int Flagg2 = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		int ID = 0;
		int ID1 = 0;
		public ManageEvaluation()
		{
			InitializeComponent();
			Flagg = 0;
		}

		public ManageEvaluation(int f)
		{
			InitializeComponent();
			Flagg = f;
			Flagg2 = f;
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

		private void DisplayEvaluation()
		{
			SqlDataAdapter adp;
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT [GroupId], EvaluationId, Name, ObtainedMarks, EvaluationDate FROM GroupEvaluation JOIN Evaluation ON [GroupEvaluation].EvaluationId = [Evaluation].Id", con);
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

		public void fillcombo()
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select Id from [dbo].[Evaluation]", con);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);

			comboBox1.DisplayMember = "Id";
			comboBox1.DataSource = dt;

			con.Close();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void ManageEvaluation_Load(object sender, EventArgs e)
		{
			fillcombo();
			DisplayEvaluation();

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
					var askfirst1 = MessageBox.Show("Are you sure you want to change marks or Evaluation Id of this project?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						Flagg2 = ID;
						textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
						con.Close();

					}
					else
					{
						Flagg2 = 0;
						con.Close();
						this.Hide();
						ManageEvaluation f2 = new ManageEvaluation();
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
						cmd1 = new SqlCommand("DELETE FROM [GroupEvaluation] WHERE GroupId = @d1 AND EvaluationId = @d2", con);
						cmd1.Parameters.AddWithValue("@d1", ID);
						cmd1.Parameters.AddWithValue("@d2", ID1);
						cmd1.ExecuteNonQuery();

						con.Close();
						MessageBox.Show("Deleted Succesfully");

						this.Hide();
						ManageEvaluation f2 = new ManageEvaluation();
						f2.ShowDialog();
						this.Close();
					}
					else
					{
						con.Close();
						this.Hide();
						ManageEvaluation f2 = new ManageEvaluation();
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

		bool GroupId()
		{
			bool a = false;
			if (textBox1.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}
		bool EvaId()
		{
			bool a = false;
			if (comboBox1.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}
		bool ObtainM()
		{
			bool a = false;
			if (textBox3.Text == "")
			{
				a = true;
				return a;
			}
			return a;
		}
		bool Group_Exists(int G_Id, int E_Id)
		{
			con.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from [GroupEvaluation]", con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (Convert.ToInt32(row["GroupId"]) == G_Id && Convert.ToInt32(row["EvaluationId"]) == E_Id)
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
			bool a = GroupId();
			if (a == false)
			{
				bool b = EvaId();
				if (b == false)
				{
					bool c = ObtainM();
					if (c == false && Regex.IsMatch(textBox3.Text, @"^[0-9]+$"))
					{
						bool d = Group_Exists(Convert.ToInt32(textBox1.Text), Convert.ToInt32(comboBox1.Text));
						if (d == false)
						{
							if (Flagg2 == 0)
							{
								con.Open();
								DateTime time = DateTime.Now;
								cmd2 = new SqlCommand("insert into GroupEvaluation([GroupId], EvaluationId, ObtainedMarks, EvaluationDate) values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "' , @time)", con);
								cmd2.Parameters.AddWithValue("@time", time);
								cmd2.ExecuteNonQuery();
								MessageBox.Show("Inserted Successfully");
								con.Close();
								this.Hide();
								ManageEvaluation f4 = new ManageEvaluation();
								f4.ShowDialog();
								this.Close();
							}

							if (Flagg2 > 0)
							{
								con.Open();
								DateTime time = DateTime.Now;
								cmd2 = new SqlCommand("UPDATE GroupEvaluation SET GroupId = @GroupId, EvaluationId = @EvaluationId, ObtainedMarks = @ObtainedMarks, EvaluationDate = @EvaluationDate WHERE GroupId = @d1 AND EvaluationId = @d2", con);
								cmd2.Parameters.AddWithValue("@d1", Flagg2);
								cmd2.Parameters.AddWithValue("@d2", ID1);
								cmd2.Parameters.AddWithValue("@GroupId", Convert.ToInt32(textBox1.Text));
								cmd2.Parameters.AddWithValue("@EvaluationId", Convert.ToInt32(comboBox1.Text));
								cmd2.Parameters.AddWithValue("@ObtainedMarks", textBox3.Text);
								cmd2.Parameters.AddWithValue("@EvaluationDate", time);
								cmd2.ExecuteNonQuery();
								MessageBox.Show("Updated successfully Successfully");
								con.Close();
								this.Hide();
								ManageEvaluation f4 = new ManageEvaluation();
								f4.ShowDialog();
								this.Close();
							}
						}
						else
						{
							MessageBox.Show("This Evaluation Id is already assigned to this group");
						}
						if (Flagg2 > 0)
						{
							con.Open();
							DateTime time = DateTime.Now;
							cmd2 = new SqlCommand("UPDATE GroupEvaluation SET GroupId = @GroupId, EvaluationId = @EvaluationId, ObtainedMarks = @ObtainedMarks, EvaluationDate = @EvaluationDate WHERE GroupId = @d1 AND EvaluationId = @d2", con);
							cmd2.Parameters.AddWithValue("@d1", Flagg2);
							cmd2.Parameters.AddWithValue("@d2", ID1);
							cmd2.Parameters.AddWithValue("@GroupId", Convert.ToInt32(textBox1.Text));
							cmd2.Parameters.AddWithValue("@EvaluationId", Convert.ToInt32(comboBox1.Text));
							cmd2.Parameters.AddWithValue("@ObtainedMarks", textBox3.Text);
							cmd2.Parameters.AddWithValue("@EvaluationDate", time);
							cmd2.ExecuteNonQuery();
							MessageBox.Show("Updated successfully Successfully");
							con.Close();
							this.Hide();
							ManageEvaluation f4 = new ManageEvaluation();
							f4.ShowDialog();
							this.Close();
						}
					}
					else
					{
						MessageBox.Show("Enter Valid Marks");
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

		private void Add_Group_Click(object sender, EventArgs e)
		{
			this.Hide();
			FromGroupStudent f4 = new FromGroupStudent();
			f4.ShowDialog();
			this.Close();
		}

		private void Add_Evaluation_Click(object sender, EventArgs e)
		{
			this.Hide();
			FromEvaluation f4 = new FromEvaluation();
			f4.ShowDialog();
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
