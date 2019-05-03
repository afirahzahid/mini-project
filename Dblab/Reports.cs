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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Dblab
{
	public partial class Reports : Form
	{
		public int Flags = 0;
		SqlConnection con1 = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
		SqlDataAdapter adp;
		SqlDataAdapter sda = new SqlDataAdapter();
		int ID = 0;
		int ID1 = 0;

		public Reports()
		{
			InitializeComponent();
		}

		public void Reports_Generation(DataTable dataTable, string destinationpath, string header1, string h2)
		{
			Document document = new Document();
			PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationpath, FileMode.Create));
			document.AddTitle("Report");
			document.Open();

			BaseFont bfntheader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
			Paragraph prg = new Paragraph();
			prg.Alignment = Element.ALIGN_CENTER;
			prg.Add(new Chunk(header1.ToUpper()));
			document.Add(prg);

			BaseFont bfn = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
			Paragraph pr = new Paragraph();
			pr.Alignment = Element.ALIGN_CENTER;
			pr.Add(new Chunk(h2.ToUpper()));
			document.Add(pr);

			PdfPTable table = new PdfPTable(dataTable.Columns.Count);
			table.WidthPercentage = 100;

			for (int k = 0; k < dataTable.Columns.Count; k++)
			{
				PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

				cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
				cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
				cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);
				table.AddCell(cell);
			}

			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				for (int j = 0; j < dataTable.Columns.Count; j++)
				{
					PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));
					cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
					cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
					table.AddCell(cell);
				}
			}
			document.Add(table);
			document.Close();
		}

		private void Report1_Click(object sender, EventArgs e)
		{
			string select = "SELECT [Group].Id AS [Group Id], Evaluation.Name,Evaluation.TotalMarks AS [Total Marks], GroupEvaluation.ObtainedMarks AS [Obtained Marks], student.RegistrationNo AS [Registration No]  FROM  (((GroupEvaluation JOIN Evaluation ON  GroupEvaluation.EvaluationId = Evaluation.Id) JOIN [Group] ON [Group].Id = GroupEvaluation.GroupId) JOIN GroupStudent ON GroupStudent.GroupId = [Group].Id) JOIN Student ON Student.Id = GroupStudent.StudentId ";
			SqlCommand cmd = new SqlCommand(select, con1);
			sda.SelectCommand = cmd;
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Reports_Generation(dt, "Report#1.pdf", "Group Report", " ");
			MessageBox.Show("Groups Report generated");
		}

		private void Report2_Click(object sender, EventArgs e)
		{
			string select = "SELECT Project.Id AS [Project Id], Project.Title AS [Project Title],  ProjectAdvisor.AdvisorId AS [AdvisorId], Student.RegistrationNo FROM ((((Project JOIN ProjectAdvisor ON Project.Id = ProjectAdvisor.ProjectId) JOIN GroupProject ON Project.Id = GroupProject.ProjectId) JOIN [Group] ON [Group].Id = GroupProject.GroupId) JOIN GroupStudent ON [Group].Id = GroupStudent.GroupId) JOIN Student ON Student.Id = GroupStudent.StudentId ORDER BY Project.Id";
			SqlCommand cmd1 = new SqlCommand(select, con1);
			sda.SelectCommand = cmd1;
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Reports_Generation(dt, "Report#2.pdf", "Projects Advisors Report", " ");
			MessageBox.Show("Project Report generated");
		}

		private void Report3_Click(object sender, EventArgs e)
		{
			string select = "SELECT Student.Id AS [Student Id], Student.RegistrationNo AS [Registration No], Person.FirstName, Person.LastName FROM (Student JOIN Person ON Student.Id = Person.Id)  ORDER BY Student.Id";
			SqlCommand cmd1 = new SqlCommand(select, con1);
			sda.SelectCommand = cmd1;
			DataTable dt = new DataTable();
			sda.Fill(dt);
			Reports_Generation(dt, "Report#3.pdf", "Student Report", " ");
			MessageBox.Show("Students Report generated");
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
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
