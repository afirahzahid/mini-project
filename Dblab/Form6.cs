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
	public partial class Add_Advisor : Form
	{
		public int Flag = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;
		public Add_Advisor()
		{
			InitializeComponent();
			Flag = 0;
		}

		public Add_Advisor(int f)
		{
			InitializeComponent();
			Flag = f;
		}


		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			if (Flag == 0)
			{
				string pa = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

				if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" )
				{
					if (Regex.IsMatch(textBox5.Text, pa))
					{
						if (Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox3.Text, @"^[a-zA-Z\s]+$"))
						{
							if (Regex.IsMatch(textBox4.Text, @"^9[0-9]{9}"))
							{
								con1.Open();
								string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
								SqlCommand cmd3 = new SqlCommand(gId, con1);
								int g = (Int32)cmd3.ExecuteScalar();
								//decimal decimalVariable;
								//var conversionOK = Decimal.TryParse(textBox1.Text, out decimalVariable);
								int numVal = Int32.Parse(textBox1.Text);
								cmd1 = new SqlCommand("insert into [Person] (FirstName, LastName, Contact, Email, DateOfBirth, gender) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + g + "')", con1);
								string designation_Id = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox2.Text);
								SqlCommand cmd = new SqlCommand(designation_Id, con1);
								int d_Id = (Int32)cmd.ExecuteScalar();
								cmd2 = new SqlCommand("insert into Advisor( Designation, Salary) values ('" + d_Id + "','" + numVal + "')", con1);
								
								cmd1.ExecuteNonQuery();
								cmd2.ExecuteNonQuery();
								cmd3.ExecuteNonQuery();
								cmd.ExecuteNonQuery();
								con1.Close();
								MessageBox.Show("Inserted Successfully");
								//DisplayStudent();
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
			}
			if (Flag == 1)
			{
				con1.Open();
				string PId = string.Format("SELECT Id From Person ");
				SqlCommand cmd4 = new SqlCommand(PId, con1);
				int p = (Int32)cmd4.ExecuteScalar();

				string designation_Id = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox2.Text);
				SqlCommand cmd = new SqlCommand(designation_Id, con1);
				int d_Id = (Int32)cmd.ExecuteScalar();

				cmd1 = new SqlCommand("UPDATE Person set FirstName = @FirstName, LastName = @LastName ,Contact = @Contact, Email = @Email, DateOfBirth =@DateOfBirth, Gender = @Gender WHERE Id = @Id", con1);
				cmd1.Parameters.AddWithValue("@Id", ID);
				cmd1.Parameters.AddWithValue("@FirstName", textBox2.Text);
				cmd1.Parameters.AddWithValue("@LastName", textBox3.Text);
				cmd1.Parameters.AddWithValue("@Contact", textBox4.Text);
				cmd1.Parameters.AddWithValue("@Email", textBox5.Text);
				cmd1.Parameters.AddWithValue("@DateOfBirth", textBox6.Text);
				string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
				SqlCommand cmd3 = new SqlCommand(gId, con1);
				int g = (Int32)cmd3.ExecuteScalar();
				cmd1.Parameters.AddWithValue("@Gender", g);
				cmd2 = new SqlCommand("UPDATE Advisor SET Designation = @Designation, Salary = @Salary", con1);
				cmd2.Parameters.AddWithValue("@Salary", textBox1.Text);
				cmd2.Parameters.AddWithValue("@Designation", d_Id);
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				con1.Close();
				MessageBox.Show("Updated successfully");
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox1.Clear();
				textBox5.Clear();
				textBox6.Clear();
				comboBox1.Items.Clear();
			}

		}

		private void ShowData_Click(object sender, EventArgs e)
		{
			this.Hide();
			Advisor f4 = new Advisor();
			f4.ShowDialog();
			this.Close();
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
