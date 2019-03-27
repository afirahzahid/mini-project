namespace Dblab
{
	partial class ProjectAdvisor
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
			this.AddAdvisor = new System.Windows.Forms.Button();
			this.Insert = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.AdvisorId = new System.Windows.Forms.Label();
			this.ProjectTitle = new System.Windows.Forms.Label();
			this.AdvisorRole = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddAdvisor
			// 
			this.AddAdvisor.Location = new System.Drawing.Point(550, 73);
			this.AddAdvisor.Name = "AddAdvisor";
			this.AddAdvisor.Size = new System.Drawing.Size(75, 23);
			this.AddAdvisor.TabIndex = 0;
			this.AddAdvisor.Text = "Add Advisor";
			this.AddAdvisor.UseVisualStyleBackColor = true;
			this.AddAdvisor.Click += new System.EventHandler(this.AddAdvisor_Click);
			// 
			// Insert
			// 
			this.Insert.Location = new System.Drawing.Point(550, 117);
			this.Insert.Name = "Insert";
			this.Insert.Size = new System.Drawing.Size(75, 23);
			this.Insert.TabIndex = 1;
			this.Insert.Text = "Insert";
			this.Insert.UseVisualStyleBackColor = true;
			this.Insert.Click += new System.EventHandler(this.Insert_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(330, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(121, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(330, 103);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
			this.comboBox2.Location = new System.Drawing.Point(330, 130);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// AdvisorId
			// 
			this.AdvisorId.AutoSize = true;
			this.AdvisorId.Location = new System.Drawing.Point(187, 73);
			this.AdvisorId.Name = "AdvisorId";
			this.AdvisorId.Size = new System.Drawing.Size(51, 13);
			this.AdvisorId.TabIndex = 5;
			this.AdvisorId.Text = "AdvisorId";
			// 
			// ProjectTitle
			// 
			this.ProjectTitle.AutoSize = true;
			this.ProjectTitle.Location = new System.Drawing.Point(187, 106);
			this.ProjectTitle.Name = "ProjectTitle";
			this.ProjectTitle.Size = new System.Drawing.Size(63, 13);
			this.ProjectTitle.TabIndex = 6;
			this.ProjectTitle.Text = "Project Title";
			// 
			// AdvisorRole
			// 
			this.AdvisorRole.AutoSize = true;
			this.AdvisorRole.Location = new System.Drawing.Point(187, 138);
			this.AdvisorRole.Name = "AdvisorRole";
			this.AdvisorRole.Size = new System.Drawing.Size(67, 13);
			this.AdvisorRole.TabIndex = 7;
			this.AdvisorRole.Text = "Advisor Role";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(52, 186);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(689, 150);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(52, 149);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(75, 31);
			this.Back.TabIndex = 17;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// ProjectAdvisor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.AdvisorRole);
			this.Controls.Add(this.ProjectTitle);
			this.Controls.Add(this.AdvisorId);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Insert);
			this.Controls.Add(this.AddAdvisor);
			this.Name = "ProjectAdvisor";
			this.Text = "ProjectAdvisor";
			this.Load += new System.EventHandler(this.ProjectAdvisor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddAdvisor;
		private System.Windows.Forms.Button Insert;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label AdvisorId;
		private System.Windows.Forms.Label ProjectTitle;
		private System.Windows.Forms.Label AdvisorRole;
		private System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Back;
	}
}