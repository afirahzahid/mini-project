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
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		public Student()
		{
			InitializeComponent();
		}

		private void DisplayStudent()
		{
			/* Student.Id, Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender
			*/
			con1.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Student JOIN Person ON Student.Id = Person.Id ", con1);
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
			con1.Close();
		}
		private void Save_Click(object sender, EventArgs e)
		{
			string pa = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

			if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
			{
				if (Regex.IsMatch(textBox5.Text, pa))
				{
					if (Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox3.Text, @"^[a-zA-Z]+$"))
					{
						if (Regex.IsMatch(textBox4.Text, @"^9[0-9]{9}"))
						{
							con1.Open();
							cmd2 = new SqlCommand("insert into Student(Student.Id, Student.RegistrationNo) values ((SELECT MAX(Person.Id) From Person), '" + textBox1.Text + "')", con1);
							string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
							SqlCommand cmd3 = new SqlCommand(gId, con1);
							int g = (Int32)cmd3.ExecuteScalar();
							cmd1 = new SqlCommand("insert into [Person] (FirstName, LastName, Contact, Email, DateOfBirth, gender) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" +g+  "')", con1);
							cmd1.ExecuteNonQuery();
							cmd2.ExecuteNonQuery();
							cmd3.ExecuteNonQuery();
							con1.Close();
							MessageBox.Show("Inserted Successfully");
							DisplayStudent();
							textBox2.Clear();
							textBox3.Clear();
							textBox4.Clear();
							textBox1.Clear();
							textBox5.Clear();
							textBox6.Clear();
							comboBox1.Items.Clear();
						}
						else
						{
							MessageBox.Show("Please enter valid Contact number");
						}

					}
					else
					{
						MessageBox.Show("Please enter valid First and Last Name");
					}
				}
				else
				{
					MessageBox.Show("Please enter valid Email");
				}

			}
			else
			{
				MessageBox.Show("Please enter record");
			}
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			con1.Open();
			string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
			SqlCommand cmd3 = new SqlCommand(gId, con1);
			int g = (Int32)cmd3.ExecuteScalar();
			cmd1 = new SqlCommand("UPDATE Person set FirstName = '" + textBox2.Text + "', LastName = '" + textBox3.Text + "', Contact = '" + textBox4.Text + "', Email = '" + textBox5.Text + "' , DateOfBirth = '" + textBox6.Text + "', Gender = '" + g + "'  where Id = " +int.Parse("Select Id From Person")+"" , con1);
			int i = cmd1.ExecuteNonQuery();
			if (i != 0)
			{
				MessageBox.Show("Updated succesfully");
			}
			else
			{
				MessageBox.Show("Error");
			}



			/*
			con1.Open();
			string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
			SqlCommand cmd3 = new SqlCommand(gId, con1);
			int g = (Int32)cmd3.ExecuteScalar();
			string query1 = "UPDATE Person set FirstName = '" +textBox2.Text+ "', LastName = '" +textBox3.Text+ "', Contact = '" +textBox4.Text + "', Email = '" +textBox5.Text + "' , DateOfBirth = '" +textBox6.Text + "', Gender = '" +g+ "'  where ID = @id";
			string query2 = "UPDATE Student set RegistrationNo = '" + textBox1.Text + "' where ID = @id";
			SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con1);
			SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con1);
			SDA1.SelectCommand.ExecuteNonQuery();
			SDA2.SelectCommand.ExecuteNonQuery();
			con1.Close();
			MessageBox.Show("Updated succesfully");
			*/
			/*
				con1.Open();
				cmd1 = new SqlCommand("UPDATE Person set FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email , DateOfBirth = @DateOfBirth, Gender = @Gender  where ID = @id", con1);
				string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
				SqlCommand cmd3 = new SqlCommand(gId, con1);
				int g = (Int32)cmd3.ExecuteScalar();
				cmd2 = new SqlCommand("UPDATE Student set RegistrationNo = @RegistrationNo ", con1);
				cmd1.Parameters.AddWithValue("@id", ID);
				cmd1.Parameters.AddWithValue("@FirstName", textBox2.Text);
				cmd1.Parameters.AddWithValue("@LastName", textBox3.Text);
				cmd1.Parameters.AddWithValue("@Contact", textBox4.Text);
				cmd1.Parameters.AddWithValue("@Email", textBox5.Text);
				cmd1.Parameters.AddWithValue("@DateOfBirth", textBox6.Text);
				cmd1.Parameters.AddWithValue("@Gender", comboBox1.Text);
				cmd2.Parameters.AddWithValue("@Id", ID);
				cmd2.Parameters.AddWithValue("@RegistrationNo", textBox1.Text);
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				con1.Close();
				MessageBox.Show("Updated successfully");
				DisplayStudent();
			
			*/
		}
		private void Student_Load(object sender, EventArgs e)
		{
		
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

			con1.Open();
			int URow = int.Parse(e.RowIndex.ToString());
			int URowIndex = int.Parse(e.ColumnIndex.ToString());
			ID = Convert.ToInt32(dataGridView1.Rows[URow].Cells[0].Value.ToString());
			if (URowIndex == 0)
			{
				MessageBox.Show("lala");
			}
			if (URowIndex != 0)
			{
				var askfirst = MessageBox.Show("Are you sure you want to delete this?",	"Delete", MessageBoxButtons.YesNo);
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
			}
			
			/*textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			textBox2.Text = grv.Cells[3].Value.ToString();
			textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
			textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

			comboBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
			*/
		}
		/*
		private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellEventArgs e)
		{
			ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
		}
		*/
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

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
			this.Hide();
			Student f2 = new Student();
			f2.ShowDialog();
			this.Close();
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
	}
}
