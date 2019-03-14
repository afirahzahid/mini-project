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
	public partial class Project : Form
	{
		public int Flag2 = 0;
		SqlCommand cmd;
		DataTable dt;
		int ID = 0;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		public Project()
		{
			InitializeComponent();
			Flag2 = 0;
		}

		public Project(int f)
		{
			InitializeComponent();
			Flag2 = f;
		}

		private void DisplayProject()
		{
			SqlDataAdapter adp;
			con1.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Project", con1);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;

			DataGridViewButtonColumn deleteB;
			deleteB = new DataGridViewButtonColumn();
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

		private void PersonInformation_Load(object sender, EventArgs e)
		{
			DisplayProject();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con1.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			if (URowIndex == 3)
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
						cmd = new SqlCommand("DELETE FROM Project where ID = @Id", con1);
						cmd.Parameters.AddWithValue("@Id", ID);
						cmd.ExecuteNonQuery();
						con1.Close();
						MessageBox.Show("Deleted Succesfully");
						this.Hide();
						Project f1 = new Project();
						f1.ShowDialog();
						this.Close();
					}

				}
			}
			else if (URowIndex == 4)
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
						Flag2 = d1;

						richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
						textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
						con1.Close();
						
					}
					else
					{
						con1.Close();
						this.Hide();
						Project f2 = new Project();
						f2.ShowDialog();
						
					}
				}
			}
			else
			{
				con1.Close();
			}
		}
	
		private void Delete_Click(object sender, EventArgs e)
		{
			

		}

		private void Show_Click(object sender, EventArgs e)
		{
			
				
		}

		private void Update_Click(object sender, EventArgs e)
		{
		
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Insert_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "" )
			{
				if (Regex.IsMatch(textBox2.Text, @"^[a-zA-Z0-9]+$"))
				{
					if (Flag2 == 0)
					{
						con1.Open();
						cmd = new SqlCommand("insert into Project (Description, Title) values ('" + richTextBox1.Text + "','" + textBox2.Text + "') ", con1);
						cmd.ExecuteNonQuery();
						con1.Close();
						MessageBox.Show("Inserted Successfully");
						DisplayProject();
						this.Hide();
						Project f1 = new Project();
						f1.ShowDialog();
						this.Close();
						Clear();
					}
					else if (Flag2 > 0)
					{
						con1.Open();
						cmd = new SqlCommand("UPDATE Project set Description = @Description, Title = @Title  WHERE ID = @Id", con1);
						cmd.Parameters.AddWithValue("@Id", Flag2);
						cmd.Parameters.AddWithValue("@Title", textBox2.Text);
						cmd.Parameters.AddWithValue("@Description", richTextBox1.Text);
						cmd.ExecuteNonQuery();
						con1.Close();
						MessageBox.Show("Updated successfully");
						this.Hide();
						Project f1 = new Project();
						f1.ShowDialog();
						this.Close();
						Clear();
						Flag2 = 0;
					}
					
				}
				else
				{
					MessageBox.Show("Please enter valid title and discription");
				}
			}
			else
			{
				MessageBox.Show("Please enter record");
			}
			con1.Close();
		}
		private void Clear()
		{
			richTextBox1.Clear();
			textBox2.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

		private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}

}
