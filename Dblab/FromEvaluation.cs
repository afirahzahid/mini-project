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
	public partial class FromEvaluation : Form
	{
		public int Flags = 0;
	
		SqlCommand cmd1;
		SqlCommand cmd2;
		SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M9PBVHQ;Initial Catalog=ProjectA;Integrated Security=True");
		int ID = 0;
		int ID1 = 0;
		public FromEvaluation()
		{
			InitializeComponent();
		}

		public FromEvaluation(int f)
		{
			InitializeComponent();
			Flags = f;
		}

		private void DisplayEval()
		{
			SqlDataAdapter adp;
			con.Open();
			DataTable dt = new DataTable();
			adp = new SqlDataAdapter("SELECT * FROM Evaluation", con);
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

			con.Close();
		}
		private void Go_back_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddGroupStudent f4 = new AddGroupStudent();
			f4.ShowDialog();
			this.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			con.Open();
			int UP_Row = int.Parse(e.RowIndex.ToString());
			int UP_RowIndex = int.Parse(e.ColumnIndex.ToString());
			ID1 = Convert.ToInt32(dataGridView1.Rows[UP_Row].Cells[0].Value.ToString());
			int dd = (int)dataGridView1.CurrentRow.Cells[0].Value;
			if (UP_RowIndex == 4)
			{
				if (UP_RowIndex == 1)

					if (UP_RowIndex == 0)
					{
						MessageBox.Show("Click Again");
					}
				if (UP_RowIndex != 0)
				{
					var askfirst1 = MessageBox.Show("Are you sure you want to add this Evaluation Id?", "Add", MessageBoxButtons.YesNo);
					if (askfirst1 == DialogResult.Yes)
					{
						FromGroupStudent t = new FromGroupStudent();
						ManageEvaluation s = new ManageEvaluation(dd);
						ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
						//s.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						s.textBox1.Text = t.Flags.ToString();
						s.Flagg2 = 0;
						s.ShowDialog();
						con.Close();
						this.Close();

					}
					else
					{
						con.Close();
						this.Hide();
						FromEvaluation f2 = new FromEvaluation();
						f2.ShowDialog();
					}
				}
			}
			else
			{
				MessageBox.Show("Click on add button");
			}
		}

		private void FromEvaluation_Load(object sender, EventArgs e)
		{
			DisplayEval();
		}
	}
}
