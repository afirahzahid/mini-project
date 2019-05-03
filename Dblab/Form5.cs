﻿using System;
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
	public partial class AddStudent : Form
	{
		public int Flag = 0;
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con1 = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;
		public AddStudent()
		{
			InitializeComponent();
			Flag = 0;
		}

		public AddStudent(int f)
		{
			InitializeComponent();
			Flag = f;
		}

		private void DisplayStudent()
		{
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Gender_Click(object sender, EventArgs e)
		{

		}

		private void DOB_Click(object sender, EventArgs e)
		{

		}

		private void Email_Click(object sender, EventArgs e)
		{

		}

		private void Contact_Click(object sender, EventArgs e)
		{

		}

		private void LastName_Click(object sender, EventArgs e)
		{

		}

		private void FirstName_Click(object sender, EventArgs e)
		{

		}

		private void RegNo_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void ShowData_Click(object sender, EventArgs e)
		{
			this.Hide();
			Student f2 = new Student();
			f2.ShowDialog();
		}

		private void Delete_Click(object sender, EventArgs e)
		{

		}
		bool Email_exists(string Email_Id)
		{
			con1.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from Person", con1);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (row["Email"].ToString() == Email_Id)
				{
					con1.Close();
					return true;
				}
			}
			con1.Close();
			return a;
		}

		bool UpdateEmail_exists(string Email_Id)
		{
			con1.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from Person", con1);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (row["Email"].ToString() == Email_Id  && (Convert.ToInt32(row["Id"]) != Flag))
				{
					con1.Close();
					return true;
				}
			}
			con1.Close();
			return a;
		}

		bool Reg_exists(string RegNO)
		{
			con1.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from Student", con1);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (row["RegistrationNo"].ToString() == RegNO)
				{
					con1.Close();
					return true;
				}
			}
			con1.Close();
			return a;
		}
		bool UpdateReg_exists(string RegNO)
		{
			con1.Open();
			bool a = false;
			SqlDataAdapter sda = new SqlDataAdapter("Select * from Student", con1);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				if (row["RegistrationNo"].ToString() == RegNO && (Convert.ToInt32(row["Id"]) != Flag))
				{
					con1.Close();
					return true;
				}
			}
			con1.Close();
			return a;
		}

		private void Save_Click(object sender, EventArgs e)
		{
			string pa = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

			if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" )
			{
				if (Regex.IsMatch(textBox5.Text, pa) && Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$") && Regex.IsMatch(textBox1.Text, @"^\d{4}(-[a-zA-Z][a-zA-Z])(-\d{2,3})"))
				{
					if ((Regex.IsMatch(textBox3.Text, @"^[a-zA-Z\s]+$") && Regex.IsMatch(textBox4.Text, @"^9[0-9]{9}")) || (textBox3.Text == "" && Regex.IsMatch(textBox4.Text, @"^9[0-9]{9}")) || (!Regex.IsMatch(textBox3.Text, @"^[a-zA-Z0-9_\-]+$") && Regex.IsMatch(textBox4.Text, @"^9[0-9]{9}")) || (Regex.IsMatch(textBox3.Text, @"^[a-zA-Z\s]+$") && textBox4.Text == "") || (textBox3.Text == "" && textBox4.Text == ""))
					{
						if (comboBox1.Text != "")
						{
							if (Flag == 0)
							{
								bool reg = Reg_exists(textBox1.Text);
								if (reg == false)
								{
									bool  email = Email_exists(textBox5.Text);
									if (email == false)
									{
										con1.Open();
										cmd2 = new SqlCommand("insert into Student(Student.Id, Student.RegistrationNo) values ((SELECT MAX(Person.Id) From Person), '" + textBox1.Text + "')", con1);
										string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
										SqlCommand cmd3 = new SqlCommand(gId, con1);
										int g = (Int32)cmd3.ExecuteScalar();
										cmd1 = new SqlCommand("insert into [Person] (FirstName, LastName, Contact, Email, DateOfBirth, gender) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "','" + g + "')", con1);
										cmd1.ExecuteNonQuery();
										cmd2.ExecuteNonQuery();
										cmd3.ExecuteNonQuery();
										con1.Close();
										MessageBox.Show("Inserted Successfully");

										textBox2.Clear();
										textBox3.Clear();
										textBox4.Clear();
										textBox1.Clear();
										textBox5.Clear();
										this.Hide();
										AddStudent f4 = new AddStudent();
										f4.ShowDialog();
										this.Close();
									}
									else
									{
										MessageBox.Show("Email Exists");
									}
								}
								else
								{
									MessageBox.Show("Registration no Exists");
								}
							}
							if (Flag > 0)
							{
								bool Upemail = UpdateEmail_exists(textBox5.Text);
								bool Upreg = UpdateReg_exists(textBox1.Text);
								bool email = Email_exists(textBox5.Text);
								bool reg = Reg_exists(textBox1.Text);
								if (Upreg == false)
								{
									if (Upemail == false)
									{
										con1.Open();
										Student f = new Student();
										cmd1 = new SqlCommand("UPDATE Person set FirstName = @FirstName, LastName = @LastName ,Contact = @Contact, Email = @Email, DateOfBirth =@DateOfBirth, Gender = @Gender WHERE ID = @dd", con1);
										cmd1.Parameters.AddWithValue("@dd", Flag);
										cmd1.Parameters.AddWithValue("@FirstName", textBox2.Text);
										cmd1.Parameters.AddWithValue("@LastName", textBox3.Text);
										cmd1.Parameters.AddWithValue("@Contact", textBox4.Text);
										cmd1.Parameters.AddWithValue("@Email", textBox5.Text);
										cmd1.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
										string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
										SqlCommand cmd3 = new SqlCommand(gId, con1);
										int g = (Int32)cmd3.ExecuteScalar();
										cmd1.Parameters.AddWithValue("@Gender", g);
										cmd2 = new SqlCommand("UPDATE Student set RegistrationNo = @RegistrationNo WHERE ID = @Id", con1);
										cmd2.Parameters.AddWithValue("RegistrationNo", textBox1.Text);
										cmd2.Parameters.AddWithValue("@Id", Flag);
										cmd1.ExecuteNonQuery();
										cmd2.ExecuteNonQuery();
										con1.Close();
										MessageBox.Show("Updated successfully");
										textBox2.Clear();
										textBox3.Clear();
										textBox4.Clear();
										textBox1.Clear();
										textBox5.Clear();
										this.Hide();
										AddStudent f4 = new AddStudent();
										f4.ShowDialog();
										this.Close();
										Flag = 0;
									}
									else
									{
										MessageBox.Show("Email Exits");
									}
								}
								else
								{
									MessageBox.Show("Registration No Exits");
								}
							}
						}
						else
						{
							if (Flag == 0)
							{
								bool email = Email_exists(textBox5.Text);
								bool reg = Reg_exists(textBox1.Text);
								if (reg == false)
								{
									if (email == false)
									{
										con1.Open();
										cmd2 = new SqlCommand("insert into Student(Student.Id, Student.RegistrationNo) values ((SELECT MAX(Person.Id) From Person), '" + textBox1.Text + "')", con1);
										cmd1 = new SqlCommand("insert into Person(FirstName, LastName, Contact, Email, DateOfBirth) values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value + "')", con1);
										cmd1.ExecuteNonQuery();
										cmd2.ExecuteNonQuery();
										con1.Close();
										MessageBox.Show("Inserted Successfully");
										textBox2.Clear();
										textBox3.Clear();
										textBox4.Clear();
										textBox1.Clear();
										textBox5.Clear();
										this.Hide();
										AddStudent f4 = new AddStudent();
										f4.ShowDialog();
										this.Close();
									}
									else
									{
										MessageBox.Show("Email Exists");
									}
								}
								else
								{
									MessageBox.Show("Reg No Exists");
								}
							}
							if (Flag > 0)
							{
								bool Upemail = UpdateEmail_exists(textBox5.Text);
								bool Upreg = UpdateReg_exists(textBox1.Text);
								bool email = Email_exists(textBox5.Text);
								bool reg = Reg_exists(textBox1.Text);
								if (Upreg == false)
								{
									if (Upemail == false )
									{
										con1.Open();
										Student f = new Student();
										cmd1 = new SqlCommand("UPDATE Person set FirstName = @FirstName, LastName = @LastName ,Contact = @Contact, Email = @Email, DateOfBirth =@DateOfBirth WHERE ID = @dd", con1);
										cmd1.Parameters.AddWithValue("@dd", Flag);
										cmd1.Parameters.AddWithValue("@FirstName", textBox2.Text);
										cmd1.Parameters.AddWithValue("@LastName", textBox3.Text);
										cmd1.Parameters.AddWithValue("@Contact", textBox4.Text);
										cmd1.Parameters.AddWithValue("@Email", textBox5.Text);
										cmd1.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
										string gId = string.Format("SELECT Lookup.Id From Lookup WHERE Value = '{0}'", comboBox1.Text);
										cmd2 = new SqlCommand("UPDATE Student set RegistrationNo = @RegistrationNo WHERE ID = @Id", con1);
										cmd2.Parameters.AddWithValue("RegistrationNo", textBox1.Text);
										cmd2.Parameters.AddWithValue("@Id", Flag);
										cmd1.ExecuteNonQuery();
										cmd2.ExecuteNonQuery();
										con1.Close();
										MessageBox.Show("Updated successfully");
										textBox2.Clear();
										textBox3.Clear();
										textBox4.Clear();
										textBox1.Clear();
										textBox5.Clear();
										this.Hide();
										AddStudent f4 = new AddStudent();
										f4.ShowDialog();
										this.Close();
										Flag = 0;
									}
									else
									{
										MessageBox.Show("Reg no Exists");
									}
								}
								else
								{
									MessageBox.Show("Email Exists");
								}
							}
						}
					}
					else
					{
						MessageBox.Show("Please enter valid Last Name and Phone No or dont enter anything");
					}
				}
				else
				{
					MessageBox.Show("Please check Email(Full Email Id), Registration No(2016-CE/CSE-057) and first name");
				}
			}
			else
			{
				MessageBox.Show("Please Enter Entries");
			}
			con1.Close();
		}

		private void AddStudent_Load(object sender, EventArgs e)
		{

		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Form f4 = new Main_Form();
			f4.ShowDialog();
			this.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void Student_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}