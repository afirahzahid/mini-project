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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// CreateGroup
			// 
			this.CreateGroup.BackColor = System.Drawing.Color.Yellow;
			this.CreateGroup.Dock = System.Windows.Forms.DockStyle.Right;
			this.CreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateGroup.Location = new System.Drawing.Point(135, 3);
			this.CreateGroup.Name = "CreateGroup";
			this.CreateGroup.Size = new System.Drawing.Size(139, 38);
			this.CreateGroup.TabIndex = 0;
			this.CreateGroup.Text = "Create Group Id";
			this.CreateGroup.UseVisualStyleBackColor = false;
			this.CreateGroup.Click += new System.EventHandler(this.CreateGroup_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(707, 192);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(217, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(208, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Group_Id
			// 
			this.Group_Id.AutoSize = true;
			this.Group_Id.Dock = System.Windows.Forms.DockStyle.Left;
			this.Group_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Group_Id.Location = new System.Drawing.Point(3, 66);
			this.Group_Id.Name = "Group_Id";
			this.Group_Id.Size = new System.Drawing.Size(136, 66);
			this.Group_Id.TabIndex = 7;
			this.Group_Id.Text = "Select Group Id";
			// 
			// Student_Id
			// 
			this.Student_Id.AutoSize = true;
			this.Student_Id.Dock = System.Windows.Forms.DockStyle.Left;
			this.Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Student_Id.Location = new System.Drawing.Point(3, 0);
			this.Student_Id.Name = "Student_Id";
			this.Student_Id.Size = new System.Drawing.Size(94, 66);
			this.Student_Id.TabIndex = 8;
			this.Student_Id.Text = "Student Id";
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(217, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(208, 21);
			this.comboBox1.TabIndex = 11;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Create
			// 
			this.Create.BackColor = System.Drawing.Color.Yellow;
			this.Create.Dock = System.Windows.Forms.DockStyle.Right;
			this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Create.Location = new System.Drawing.Point(135, 91);
			this.Create.Name = "Create";
			this.Create.Size = new System.Drawing.Size(139, 38);
			this.Create.TabIndex = 13;
			this.Create.Text = "Save";
			this.Create.UseVisualStyleBackColor = false;
			this.Create.Click += new System.EventHandler(this.Create_Click);
			// 
			// Add_Students
			// 
			this.Add_Students.BackColor = System.Drawing.Color.Yellow;
			this.Add_Students.Dock = System.Windows.Forms.DockStyle.Right;
			this.Add_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add_Students.Location = new System.Drawing.Point(135, 47);
			this.Add_Students.Name = "Add_Students";
			this.Add_Students.Size = new System.Drawing.Size(139, 38);
			this.Add_Students.TabIndex = 15;
			this.Add_Students.Text = "Add Students";
			this.Add_Students.UseVisualStyleBackColor = false;
			this.Add_Students.Click += new System.EventHandler(this.Add_Students_Click);
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.Yellow;
			this.Back.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.Location = new System.Drawing.Point(3, 3);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(58, 28);
			this.Back.TabIndex = 16;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.Student_Id, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Group_Id, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 132);
			this.tableLayoutPanel1.TabIndex = 17;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.CreateGroup, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.Add_Students, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.Create, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(434, 2);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(277, 132);
			this.tableLayoutPanel2.TabIndex = 18;
			this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GrayText;
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.779757F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.597F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.529522F));
			this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.71841F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.22744F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.52708F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.34657F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel3.TabIndex = 19;
			this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(41, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(711, 55);
			this.button1.TabIndex = 21;
			this.button1.Text = "Manage Student Groups";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.Back, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(40, 203);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.73684F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.26316F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(713, 232);
			this.tableLayoutPanel5.TabIndex = 20;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.63158F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.36842F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(40, 63);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(713, 136);
			this.tableLayoutPanel4.TabIndex = 19;
			// 
			// AddGroupStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Name = "AddGroupStudent";
			this.Text = "AddGroupStudent";
			this.Load += new System.EventHandler(this.AddGroupStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}