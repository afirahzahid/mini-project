namespace Dblab
{
	partial class AddGroupStudent
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
			this.CreateGroup = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Group_Id = new System.Windows.Forms.Label();
			this.Student_Id = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Create = new System.Windows.Forms.Button();
			this.Add_Students = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// CreateGroup
			// 
			this.CreateGroup.Location = new System.Drawing.Point(602, 57);
			this.CreateGroup.Name = "CreateGroup";
			this.CreateGroup.Size = new System.Drawing.Size(125, 23);
			this.CreateGroup.TabIndex = 0;
			this.CreateGroup.Text = "+";
			this.CreateGroup.UseVisualStyleBackColor = true;
			this.CreateGroup.Click += new System.EventHandler(this.CreateGroup_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(49, 196);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(688, 204);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(300, 60);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Group_Id
			// 
			this.Group_Id.AutoSize = true;
			this.Group_Id.Location = new System.Drawing.Point(159, 123);
			this.Group_Id.Name = "Group_Id";
			this.Group_Id.Size = new System.Drawing.Size(81, 13);
			this.Group_Id.TabIndex = 7;
			this.Group_Id.Text = "Select Group Id";
			// 
			// Student_Id
			// 
			this.Student_Id.AutoSize = true;
			this.Student_Id.Location = new System.Drawing.Point(172, 67);
			this.Student_Id.Name = "Student_Id";
			this.Student_Id.Size = new System.Drawing.Size(56, 13);
			this.Student_Id.TabIndex = 8;
			this.Student_Id.Text = "Student Id";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(300, 115);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 11;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Create
			// 
			this.Create.Location = new System.Drawing.Point(602, 121);
			this.Create.Name = "Create";
			this.Create.Size = new System.Drawing.Size(125, 23);
			this.Create.TabIndex = 13;
			this.Create.Text = "Create";
			this.Create.UseVisualStyleBackColor = true;
			this.Create.Click += new System.EventHandler(this.Create_Click);
			// 
			// Add_Students
			// 
			this.Add_Students.Location = new System.Drawing.Point(602, 91);
			this.Add_Students.Name = "Add_Students";
			this.Add_Students.Size = new System.Drawing.Size(125, 24);
			this.Add_Students.TabIndex = 15;
			this.Add_Students.Text = "Add Students";
			this.Add_Students.UseVisualStyleBackColor = true;
			this.Add_Students.Click += new System.EventHandler(this.Add_Students_Click);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(111, 162);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(75, 23);
			this.Back.TabIndex = 16;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// AddGroupStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.Add_Students);
			this.Controls.Add(this.Create);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Student_Id);
			this.Controls.Add(this.Group_Id);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.CreateGroup);
			this.Name = "AddGroupStudent";
			this.Text = "AddGroupStudent";
			this.Load += new System.EventHandler(this.AddGroupStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateGroup;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label Group_Id;
		private System.Windows.Forms.Label Student_Id;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button Create;
		private System.Windows.Forms.Button Add_Students;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button Back;
	}
}