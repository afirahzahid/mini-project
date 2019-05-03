using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dblab
{
	public partial class Evaluation : Form
	{
		public int Flag3 = 0;
		SqlCommand cmd;
		SqlConnection con = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		public Evaluation()
		{
			InitializeComponent();
			Flag3 = 0;
		}

		public Evaluation(int f)
		{
			InitializeComponent();
			Flag3 = f;
		}

		private void Evaluation_Load(object sender, EventArgs e)
		{
			DisplayEval();
		}

		private void DisplayEval()
		{
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Evaluation", con);
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

			DataGridViewButtonColumn Up_Data;
			Up_Data = new DataGridViewButtonColumn();
			Up_Data.HeaderText = "Update";
			Up_Data.Text = "Update";
			Up_Data.UseColumnTextForButtonValue = true;
			Up_Data.Width = 60;
			dataGridView1.Columns.Add(Up_Data);
			int b = 0;
			while (b < dataGridView1.Rows.Count)
			{
				dataGridView1.Rows[b].Cells[0].ReadOnly = true;
				b++;
			}
	
			con.Close();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			if (URowIndex == 4)
			{
				if (URowIndex == 0)
				{
					MessageBox.Show("Click on delete button");
				}
				if (URowIndex != 0)
				{
					var askfirst = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);
					if (askfirst == DialogResult.Yes)
					{
						cmd = new SqlCommand("DELETE FROM Evaluation where ID = @Id", con);
						cmd.Parameters.AddWithValue("@Id", ID);
						cmd.ExecuteNonQuery();
						con.Close();
						MessageBox.Show("Deleted Succesfully");

						this.Hide();
						Evaluation f1 = new Evaluation();
						f1.ShowDialog();
						this.Close();
					}
                    else
                    {
                        this.Hide();
                        Evaluation f1 = new Evaluation();
                        f1.ShowDialog();
                        this.Close();
                    }
				}
			}
			else if (URowIndex == 5)
			{
				int d1 = (int)dataGridView1.CurrentRow.Cells[0].Value;
				if (URowIndex == 0)
				{
					MessageBox.Show("Click again");
				}
				if (URowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to Update this?", "Update", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						Flag3 = d1;
						textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
						textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
						con.Close();
					}
					else
					{
						con.Close();
						this.Hide();
						Evaluation f2 = new Evaluation();
						f2.ShowDialog();

					}
				}
			}
			else
			{
				con.Close();
			}
		
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
			{
				if (Regex.IsMatch(textBox2.Text, @"^[a-zA-Z\s]+$"))
				{
					if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[0-9]*$") && (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[0-9]*$")))
					{
						if (Flag3 == 0)
						{
							cmd = new SqlCommand("insert into Evaluation (Evaluation.Name, TotalMarks, TotalWeightage) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", con);
							con.Open();
							cmd.ExecuteNonQuery();
							con.Close();
							MessageBox.Show("Inserted Successfully");
							DisplayEval();
							this.Hide();
							Evaluation f1 = new Evaluation();
							f1.ShowDialog();
							this.Close();
							Clear();

						}
						else if (Flag3 > 0)
						{
							con.Open();
							cmd = new SqlCommand("UPDATE Evaluation set Name = @name, TotalMarks = @TotalMarks, Totalweightage = @Totalweightage where ID = @id", con);
							cmd.Parameters.AddWithValue("@id", Flag3);
							cmd.Parameters.AddWithValue("@name", textBox2.Text);
							cmd.Parameters.AddWithValue("@Totalweightage", textBox3.Text);
							cmd.Parameters.AddWithValue("@TotalMarks", textBox4.Text);
							cmd.ExecuteNonQuery();
							con.Close();
							MessageBox.Show("Updated successfully");
							this.Hide();
							Evaluation f1 = new Evaluation();
							f1.ShowDialog();
							this.Close();
							Clear();
							Flag3 = 0;
						}
					}
					else
					{
						MessageBox.Show("Please Enter Valid Marks and weightage");
					}
				}
				else
				{
					MessageBox.Show("Please enter valid name");
				}
			}
			
			else
			{
				MessageBox.Show("Please enter record");

			}
			con.Close();
		}

		private void ID_Click(object sender, EventArgs e)
		{

		}

		private void Name_Click(object sender, EventArgs e)
		{

		}

		private void TotalMarks_Click(object sender, EventArgs e)
		{

		}

		private void TotalWeightage_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		private void Clear()
		{
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
	
		}
		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			DisplayEval();
			this.Hide();
			Evaluation f1 = new Evaluation();
			f1.ShowDialog();
			this.Close();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

		private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
		{

		}

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
