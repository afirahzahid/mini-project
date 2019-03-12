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
		SqlCommand cmd;
		DataTable dt;
		int ID = 0;
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		public Project()
		{
			InitializeComponent();
		}

		private void DisplayProject()
		{
			SqlDataAdapter adp;
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Project", con);
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
			con.Close();
		}

		private void PersonInformation_Load(object sender, EventArgs e)
		{
			DisplayProject();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			if (URowIndex == 0)
			{
				MessageBox.Show("Click on delete button");
			}
			if (URowIndex != 0)
			{
				var askfirst = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo);
				if (askfirst == DialogResult.Yes)
				{
					cmd = new SqlCommand("DELETE FROM Project where ID = @Id", con);
					cmd.Parameters.AddWithValue("@Id", ID);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Deleted Succesfully");

					this.Hide();
					Project f1 = new Project();
					f1.ShowDialog();
					this.Close();


				}
			}
			//MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

		}

		private void Delete_Click(object sender, EventArgs e)
		{
			

		}

		private void Show_Click(object sender, EventArgs e)
		{
			DisplayProject();
			this.Hide();
			Project f1 = new Project();
			f1.ShowDialog();
			this.Close();
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
			if (textBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "")
			{
				if (Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox1.Text, @"^^[a-zA-Z\s]+$"))
				{
					cmd = new SqlCommand("insert into Project (Description, Title) values ('" + textBox1.Text + "','" + textBox2.Text + "') ", con);
					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Inserted Successfully");
					DisplayProject();
					this.Hide();
					Project f1 = new Project();
					f1.ShowDialog();
					this.Close();
					Clear();

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
		}
		private void Clear()
		{
			textBox1.Clear();
			textBox2.Clear();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}
	}

}
