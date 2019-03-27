namespace Dblab
{
	partial class ManageEvaluation
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
			this.Add_Group = new System.Windows.Forms.Button();
			this.Insert = new System.Windows.Forms.Button();
			this.Group_Id = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Obtained_Marks = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Back = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Add_Group
			// 
			this.Add_Group.Location = new System.Drawing.Point(530, 75);
			this.Add_Group.Name = "Add_Group";
			this.Add_Group.Size = new System.Drawing.Size(75, 23);
			this.Add_Group.TabIndex = 0;
			this.Add_Group.Text = "Add Group";
			this.Add_Group.UseVisualStyleBackColor = true;
			this.Add_Group.Click += new System.EventHandler(this.Add_Group_Click);
			// 
			// Insert
			// 
			this.Insert.Location = new System.Drawing.Point(530, 145);
			this.Insert.Name = "Insert";
			this.Insert.Size = new System.Drawing.Size(75, 23);
			this.Insert.TabIndex = 2;
			this.Insert.Text = "Insert";
			this.Insert.UseVisualStyleBackColor = true;
			this.Insert.Click += new System.EventHandler(this.Insert_Click);
			// 
			// Group_Id
			// 
			this.Group_Id.AutoSize = true;
			this.Group_Id.Location = new System.Drawing.Point(105, 84);
			this.Group_Id.Name = "Group_Id";
			this.Group_Id.Size = new System.Drawing.Size(48, 13);
			this.Group_Id.TabIndex = 7;
			this.Group_Id.Text = "Group Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Evaluation Id";
			// 
			// Obtained_Marks
			// 
			this.Obtained_Marks.AutoSize = true;
			this.Obtained_Marks.Location = new System.Drawing.Point(105, 145);
			this.Obtained_Marks.Name = "Obtained_Marks";
			this.Obtained_Marks.Size = new System.Drawing.Size(82, 13);
			this.Obtained_Marks.TabIndex = 9;
			this.Obtained_Marks.Text = "Obtained Marks";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(286, 77);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(286, 145);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 12;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(92, 213);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(615, 208);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(99, 176);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(54, 31);
			this.Back.TabIndex = 18;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(286, 109);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 19;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// ManageEvaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Obtained_Marks);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Group_Id);
			this.Controls.Add(this.Insert);
			this.Controls.Add(this.Add_Group);
			this.Name = "ManageEvaluation";
			this.Text = "ManageEvaluation";
			this.Load += new System.EventHandler(this.ManageEvaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Add_Group;
		private System.Windows.Forms.Button Insert;
		private System.Windows.Forms.Label Group_Id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Obtained_Marks;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}