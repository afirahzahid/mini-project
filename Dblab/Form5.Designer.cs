namespace Dblab
{
	partial class AddStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Student = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.LastName = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.Gender = new System.Windows.Forms.Label();
			this.Contact = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.DOB = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.FirstName = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.RegNo = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Back = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.ShowData = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// Student
			// 
			this.Student.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Student.Location = new System.Drawing.Point(105, 3);
			this.Student.Name = "Student";
			this.Student.Size = new System.Drawing.Size(541, 55);
			this.Student.TabIndex = 80;
			this.Student.Text = "Add Student";
			this.Student.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5183F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4817F));
			this.tableLayoutPanel1.Controls.Add(this.RegNo, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.FirstName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.DOB, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.Email, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.Contact, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.Gender, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.LastName, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(105, 64);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35563F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27406F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27406F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27406F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27406F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27406F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.27406F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 263);
			this.tableLayoutPanel1.TabIndex = 78;
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point(270, 77);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(268, 20);
			this.textBox3.TabIndex = 24;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// LastName
			// 
			this.LastName.AutoSize = true;
			this.LastName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LastName.Location = new System.Drawing.Point(3, 74);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(261, 37);
			this.LastName.TabIndex = 30;
			this.LastName.Text = "Last Name";
			this.LastName.Click += new System.EventHandler(this.LastName_Click);
			// 
			// textBox4
			// 
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Location = new System.Drawing.Point(270, 151);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(268, 20);
			this.textBox4.TabIndex = 25;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// Gender
			// 
			this.Gender.AutoSize = true;
			this.Gender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Gender.Location = new System.Drawing.Point(3, 111);
			this.Gender.Name = "Gender";
			this.Gender.Size = new System.Drawing.Size(261, 37);
			this.Gender.TabIndex = 34;
			this.Gender.Text = "Gender";
			this.Gender.Click += new System.EventHandler(this.Gender_Click);
			// 
			// Contact
			// 
			this.Contact.AutoSize = true;
			this.Contact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Contact.Location = new System.Drawing.Point(3, 148);
			this.Contact.Name = "Contact";
			this.Contact.Size = new System.Drawing.Size(261, 37);
			this.Contact.TabIndex = 31;
			this.Contact.Text = "Contact";
			this.Contact.Click += new System.EventHandler(this.Contact_Click);
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(270, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(268, 20);
			this.textBox2.TabIndex = 23;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox5.Location = new System.Drawing.Point(270, 188);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(268, 20);
			this.textBox5.TabIndex = 26;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Email.Location = new System.Drawing.Point(3, 185);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(261, 37);
			this.Email.TabIndex = 32;
			this.Email.Text = "Email";
			this.Email.Click += new System.EventHandler(this.Email_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.comboBox1.Location = new System.Drawing.Point(270, 114);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(268, 21);
			this.comboBox1.TabIndex = 35;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// DOB
			// 
			this.DOB.AutoSize = true;
			this.DOB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DOB.Location = new System.Drawing.Point(3, 222);
			this.DOB.Name = "DOB";
			this.DOB.Size = new System.Drawing.Size(261, 41);
			this.DOB.TabIndex = 33;
			this.DOB.Text = "DOB";
			this.DOB.Click += new System.EventHandler(this.DOB_Click);
			// 
			// textBox6
			// 
			this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox6.Location = new System.Drawing.Point(270, 225);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(268, 20);
			this.textBox6.TabIndex = 27;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// FirstName
			// 
			this.FirstName.AutoSize = true;
			this.FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstName.Location = new System.Drawing.Point(3, 37);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(261, 37);
			this.FirstName.TabIndex = 29;
			this.FirstName.Text = "First Name";
			this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(270, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(268, 20);
			this.textBox1.TabIndex = 22;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// RegNo
			// 
			this.RegNo.AutoSize = true;
			this.RegNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegNo.Location = new System.Drawing.Point(3, 0);
			this.RegNo.Name = "RegNo";
			this.RegNo.Size = new System.Drawing.Size(261, 37);
			this.RegNo.TabIndex = 28;
			this.RegNo.Text = "RegNo";
			this.RegNo.Click += new System.EventHandler(this.RegNo_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.ShowData, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.Save, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.Back, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(105, 333);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 63);
			this.tableLayoutPanel2.TabIndex = 79;
			// 
			// Back
			// 
			this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.Location = new System.Drawing.Point(3, 3);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(174, 57);
			this.Back.TabIndex = 37;
			this.Back.Text = "<- Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Save
			// 
			this.Save.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Location = new System.Drawing.Point(183, 3);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(174, 57);
			this.Save.TabIndex = 20;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// ShowData
			// 
			this.ShowData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShowData.Location = new System.Drawing.Point(363, 3);
			this.ShowData.Name = "ShowData";
			this.ShowData.Size = new System.Drawing.Size(175, 57);
			this.ShowData.TabIndex = 36;
			this.ShowData.Text = "ShowData";
			this.ShowData.UseVisualStyleBackColor = true;
			this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.71649F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.28352F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.Student, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.48485F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.51515F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel3.TabIndex = 80;
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel3);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "AddStudent";
			this.Text = "Add Student";
			this.Load += new System.EventHandler(this.AddStudent_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Student;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.Label RegNo;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Label FirstName;
		public System.Windows.Forms.TextBox textBox6;
		public System.Windows.Forms.Label DOB;
		public System.Windows.Forms.ComboBox comboBox1;
		public System.Windows.Forms.Label Email;
		public System.Windows.Forms.TextBox textBox5;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.Label Contact;
		public System.Windows.Forms.Label Gender;
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.Label LastName;
		public System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		public System.Windows.Forms.Button ShowData;
		public System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	}
}