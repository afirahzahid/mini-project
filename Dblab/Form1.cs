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

namespace Dblab
{
	public partial class Evaluation : Form
	{
		SqlCommand cmd;
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		public Evaluation()
		{
			InitializeComponent();
		}

		private void Evaluation_Load(object sender, EventArgs e)
		{
			Display();
		}
		private void Display()
		{
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Evaluation", con);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
			{
				cmd = new SqlCommand("UPDATE Evaluation set Name = @name, TotalMarks = @TotalMarks, Totalweightage = @Totalweightage where ID = @id", con);
				cmd.Parameters.AddWithValue("@id", ID);
				cmd.Parameters.AddWithValue("@name", textBox2.Text); 
				cmd.Parameters.AddWithValue("@Totalweightage", textBox3.Text);
				cmd.Parameters.AddWithValue("@TotalMarks", textBox4.Text);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Updated successfully");
				Display();
			}
			else
			{
				MessageBox.Show("Select data");
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				cmd = new SqlCommand("DELETE FROM Evaluation where ID = @Id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@Id", ID);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Delete successfully");
				Display();
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
			}
			else
			{
				MessageBox.Show("Select Row to delete");
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
			{
				cmd = new SqlCommand("insert into Evaluation (Evaluation.Name, TotalMarks, TotalWeightage) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", con);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Inserted Successfully");
				Display();
			}
			else
			{
				MessageBox.Show("Please enter record");
			}
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

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Student f2 = new Student();
			f2.ShowDialog();
			this.Close();
			f2.Close();
		}
	}
}
