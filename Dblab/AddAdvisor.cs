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
	public partial class AddAdvisor : Form
	{
		public int Flags = 0;
		SqlConnection con1 = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		int ID = 0;
		int ID1 = 0;
		public AddAdvisor()
		{
			InitializeComponent();
		}

		public AddAdvisor(int f)
		{
			InitializeComponent();
			Flags = f;
		}

		private void DisplayAdvisor()
		{
			con1.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT Person.Id, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender, Advisor.Designation, Advisor.Salary  FROM Person JOIN Advisor ON Person.Id =  Advisor.Id ", con1);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;

			DataGridViewButtonColumn deleteB;
			deleteB = new DataGridViewButtonColumn();
			deleteB.HeaderText = "Add";
			deleteB.Text = "Add";
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

			private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con1.Open();

			int UP_Row = int.Parse(e.RowIndex.ToString());
			int UP_RowIndex = int.Parse(e.ColumnIndex.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[UP_Row].Cells[0].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;
			if (UP_RowIndex == 9)
			{
				if (UP_RowIndex == 1)

					if (UP_RowIndex == 0)
					{
						MessageBox.Show("Click Again");
					}
				if (UP_RowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to add this Advisor?", "Add", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						ProjectAdvisor s = new ProjectAdvisor(dd);
						ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
						s.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						s.Flagg2 = 0;
						s.ShowDialog();
						con1.Close();
						this.Close();

					}
					else
					{
						con1.Close();
						this.Hide();
						FromStudents f2 = new FromStudents();
						f2.ShowDialog();
					}
				}
			}
			else
			{
				MessageBox.Show("Click on add button");
			}

		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProjectAdvisor f4 = new ProjectAdvisor();
			f4.ShowDialog();
			this.Close();
		}

		private void AddAdvisor_Load(object sender, EventArgs e)
		{
			DisplayAdvisor();
		}

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
