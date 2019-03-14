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

namespace Dblab
{
	public partial class Main_Form : Form
	{
		SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		public Main_Form()
		{
			InitializeComponent();
		}

		private void Main_Form_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddStudent f2 = new AddStudent();
			f2.ShowDialog();
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			Evaluation f1 = new Evaluation();
			f1.ShowDialog();
			this.Close();
		}

		private void Manage_Projects_Click(object sender, EventArgs e)
		{
			this.Hide();
			Project f1 = new Project();
			f1.ShowDialog();
			this.Close();
		}

		private void Manage_Advisors_Click(object sender, EventArgs e)
		{
			this.Hide();
			Add_Advisor f1 = new Add_Advisor();
			f1.ShowDialog();
			this.Close();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
