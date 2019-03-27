namespace Dblab
{
	partial class ManageGroupProject
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Back = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ProjectId = new System.Windows.Forms.Label();
			this.Group_Id = new System.Windows.Forms.Label();
			this.Insert = new System.Windows.Forms.Button();
			this.Add_Group = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(287, 86);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 29;
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(100, 153);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(54, 31);
			this.Back.TabIndex = 28;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(93, 190);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(615, 208);
			this.dataGridView1.TabIndex = 27;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(287, 54);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 25;
			// 
			// ProjectId
			// 
			this.ProjectId.AutoSize = true;
			this.ProjectId.Location = new System.Drawing.Point(106, 93);
			this.ProjectId.Name = "ProjectId";
			this.ProjectId.Size = new System.Drawing.Size(52, 13);
			this.ProjectId.TabIndex = 23;
			this.ProjectId.Text = "Project Id";
			// 
			// Group_Id
			// 
			this.Group_Id.AutoSize = true;
			this.Group_Id.Location = new System.Drawing.Point(106, 61);
			this.Group_Id.Name = "Group_Id";
			this.Group_Id.Size = new System.Drawing.Size(48, 13);
			this.Group_Id.TabIndex = 22;
			this.Group_Id.Text = "Group Id";
			// 
			// Insert
			// 
			this.Insert.Location = new System.Drawing.Point(531, 122);
			this.Insert.Name = "Insert";
			this.Insert.Size = new System.Drawing.Size(75, 23);
			this.Insert.TabIndex = 21;
			this.Insert.Text = "Insert";
			this.Insert.UseVisualStyleBackColor = true;
			this.Insert.Click += new System.EventHandler(this.Insert_Click);
			// 
			// Add_Group
			// 
			this.Add_Group.Location = new System.Drawing.Point(531, 52);
			this.Add_Group.Name = "Add_Group";
			this.Add_Group.Size = new System.Drawing.Size(75, 23);
			this.Add_Group.TabIndex = 20;
			this.Add_Group.Text = "Add Group";
			this.Add_Group.UseVisualStyleBackColor = true;
			this.Add_Group.Click += new System.EventHandler(this.Add_Group_Click);
			// 
			// ManageGroupProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ProjectId);
			this.Controls.Add(this.Group_Id);
			this.Controls.Add(this.Insert);
			this.Controls.Add(this.Add_Group);
			this.Name = "ManageGroupProject";
			this.Text = "ManageGroupProject";
			this.Load += new System.EventHandler(this.ManageGroupProject_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label ProjectId;
		private System.Windows.Forms.Label Group_Id;
		private System.Windows.Forms.Button Insert;
		private System.Windows.Forms.Button Add_Group;
	}
}