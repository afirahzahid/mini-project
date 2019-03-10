namespace Dblab
{
	partial class Student
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
			this.Save = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.RegNo = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.Label();
			this.LastName = new System.Windows.Forms.Label();
			this.Contact = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.DOB = new System.Windows.Forms.Label();
			this.Gender = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.ShowData = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(31, 360);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 0;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(237, 360);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 2;
			this.Delete.Text = "Update";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(152, 70);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(116, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(152, 112);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(116, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(152, 147);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(116, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(152, 189);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(116, 20);
			this.textBox4.TabIndex = 6;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(152, 227);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(116, 20);
			this.textBox5.TabIndex = 7;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(152, 271);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(116, 20);
			this.textBox6.TabIndex = 8;
			// 
			// RegNo
			// 
			this.RegNo.AutoSize = true;
			this.RegNo.Location = new System.Drawing.Point(36, 77);
			this.RegNo.Name = "RegNo";
			this.RegNo.Size = new System.Drawing.Size(41, 13);
			this.RegNo.TabIndex = 10;
			this.RegNo.Text = "RegNo";
			// 
			// FirstName
			// 
			this.FirstName.AutoSize = true;
			this.FirstName.Location = new System.Drawing.Point(36, 119);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(57, 13);
			this.FirstName.TabIndex = 11;
			this.FirstName.Text = "First Name";
			// 
			// LastName
			// 
			this.LastName.AutoSize = true;
			this.LastName.Location = new System.Drawing.Point(36, 154);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(58, 13);
			this.LastName.TabIndex = 12;
			this.LastName.Text = "Last Name";
			// 
			// Contact
			// 
			this.Contact.AutoSize = true;
			this.Contact.Location = new System.Drawing.Point(36, 196);
			this.Contact.Name = "Contact";
			this.Contact.Size = new System.Drawing.Size(44, 13);
			this.Contact.TabIndex = 13;
			this.Contact.Text = "Contact";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(36, 234);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(32, 13);
			this.Email.TabIndex = 14;
			this.Email.Text = "Email";
			// 
			// DOB
			// 
			this.DOB.AutoSize = true;
			this.DOB.Location = new System.Drawing.Point(36, 278);
			this.DOB.Name = "DOB";
			this.DOB.Size = new System.Drawing.Size(30, 13);
			this.DOB.TabIndex = 15;
			this.DOB.Text = "DOB";
			// 
			// Gender
			// 
			this.Gender.AutoSize = true;
			this.Gender.Location = new System.Drawing.Point(36, 316);
			this.Gender.Name = "Gender";
			this.Gender.Size = new System.Drawing.Size(42, 13);
			this.Gender.TabIndex = 16;
			this.Gender.Text = "Gender";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(335, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(429, 313);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.comboBox1.Location = new System.Drawing.Point(152, 308);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 18;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// ShowData
			// 
			this.ShowData.Location = new System.Drawing.Point(135, 360);
			this.ShowData.Name = "ShowData";
			this.ShowData.Size = new System.Drawing.Size(75, 23);
			this.ShowData.TabIndex = 19;
			this.ShowData.Text = "ShowData";
			this.ShowData.UseVisualStyleBackColor = true;
			this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
			// 
			// Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ShowData);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Gender);
			this.Controls.Add(this.DOB);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Contact);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.FirstName);
			this.Controls.Add(this.RegNo);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Save);
			this.Name = "Student";
			this.Text = "Student";
			this.Load += new System.EventHandler(this.Student_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label RegNo;
		private System.Windows.Forms.Label FirstName;
		private System.Windows.Forms.Label LastName;
		private System.Windows.Forms.Label Contact;
		private System.Windows.Forms.Label Email;
		private System.Windows.Forms.Label DOB;
		private System.Windows.Forms.Label Gender;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button ShowData;
	}
}