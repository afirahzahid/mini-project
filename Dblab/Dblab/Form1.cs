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
		SqlDataAdapter sda;
		SqlCommandBuilder scb;
		DataTable dt;
		public Evaluation()
		{
			InitializeComponent();
		}

		private void Evaluation_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection("Data Source=DESKTOP-KSK1C2C\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");

		}
	}
}
