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
		SqlCommand cmd3;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;
		public Student()
		{
			InitializeComponent();
		}

		private void DisplayStudent()
		{
			con1.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Student JOIN Person ON Student.Id = Person.Id ", con1);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;
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
			if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
			{
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
				cmd1.Parameters.AddWithValue("@Gender", g);
				cmd2.Parameters.AddWithValue("@Id", ID);
				cmd2.Parameters.AddWithValue("@RegistrationNo", textBox1.Text);
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				con1.Close();
				MessageBox.Show("Updated successfully");
				DisplayStudent();


			}
			else
			{
				MessageBox.Show("Select data");
			}




			/* if (ID != 0)
			{
				con1.Open();
				cmd1 = new SqlCommand("DELETE FROM Student where ID = @Id", con1);
				cmd2 = new SqlCommand("DELETE FROM Person where ID = @Id", con1);

				cmd1.Parameters.AddWithValue("@Id", ID);
				cmd1.ExecuteNonQuery();
				cmd2.Parameters.AddWithValue("@Id", ID);
				cmd2.ExecuteNonQuery();
				con1.Close();
				MessageBox.Show("Delete successfully");
				DisplayStudent();
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox1.Clear();
				textBox5.Clear();
				textBox6.Clear();

			}
			else
			{
				MessageBox.Show("Select Row to delete");
			} */

		}
		private void Student_Load(object sender, EventArgs e)
		{
			DisplayStudent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

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
			this.Hide();
			PersonInformation f3 = new PersonInformation();
			f3.ShowDialog();
			f3.Close();
			this.Hide();
		}
	}
}
