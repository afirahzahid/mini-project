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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(225, 50);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(217, 21);
			this.comboBox1.TabIndex = 29;
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.Yellow;
			this.Back.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.Location = new System.Drawing.Point(3, 3);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(62, 35);
			this.Back.TabIndex = 28;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(709, 219);
			this.dataGridView1.TabIndex = 27;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(225, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(217, 20);
			this.textBox1.TabIndex = 25;
			// 
			// ProjectId
			// 
			this.ProjectId.AutoSize = true;
			this.ProjectId.Dock = System.Windows.Forms.DockStyle.Left;
			this.ProjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProjectId.Location = new System.Drawing.Point(3, 47);
			this.ProjectId.Name = "ProjectId";
			this.ProjectId.Size = new System.Drawing.Size(86, 48);
			this.ProjectId.TabIndex = 23;
			this.ProjectId.Text = "Project Id";
			// 
			// Group_Id
			// 
			this.Group_Id.AutoSize = true;
			this.Group_Id.Dock = System.Windows.Forms.DockStyle.Left;
			this.Group_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Group_Id.Location = new System.Drawing.Point(3, 0);
			this.Group_Id.Name = "Group_Id";
			this.Group_Id.Size = new System.Drawing.Size(80, 47);
			this.Group_Id.TabIndex = 22;
			this.Group_Id.Text = "Group Id";
			// 
			// Insert
			// 
			this.Insert.BackColor = System.Drawing.Color.Yellow;
			this.Insert.Dock = System.Windows.Forms.DockStyle.Right;
			this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insert.Location = new System.Drawing.Point(161, 50);
			this.Insert.Name = "Insert";
			this.Insert.Size = new System.Drawing.Size(98, 42);
			this.Insert.TabIndex = 21;
			this.Insert.Text = "Insert";
			this.Insert.UseVisualStyleBackColor = false;
			this.Insert.Click += new System.EventHandler(this.Insert_Click);
			// 
			// Add_Group
			// 
			this.Add_Group.BackColor = System.Drawing.Color.Yellow;
			this.Add_Group.Dock = System.Windows.Forms.DockStyle.Right;
			this.Add_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add_Group.Location = new System.Drawing.Point(161, 3);
			this.Add_Group.Name = "Add_Group";
			this.Add_Group.Size = new System.Drawing.Size(98, 41);
			this.Add_Group.TabIndex = 20;
			this.Add_Group.Text = "Add Group";
			this.Add_Group.UseVisualStyleBackColor = false;
			this.Add_Group.Click += new System.EventHandler(this.Add_Group_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.Group_Id, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ProjectId, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 95);
			this.tableLayoutPanel1.TabIndex = 30;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.91533F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.08467F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(42, 62);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(715, 99);
			this.tableLayoutPanel2.TabIndex = 32;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.Add_Group, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.Insert, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(451, 2);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(262, 95);
			this.tableLayoutPanel3.TabIndex = 33;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.Back, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(42, 165);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5679F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(715, 266);
			this.tableLayoutPanel4.TabIndex = 32;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(43, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(713, 54);
			this.button1.TabIndex = 34;
			this.button1.Text = "Manage Group Projects";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.GrayText;
			this.tableLayoutPanel5.ColumnCount = 3;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.060918F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.06561F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.967198F));
			this.tableLayoutPanel5.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 2);
			this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 4;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.3574F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.92419F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.9278F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.429603F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel5.TabIndex = 35;
			this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
			// 
			// ManageGroupProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel5);
			this.Name = "ManageGroupProject";
			this.Text = "ManageGroupProject";
			this.Load += new System.EventHandler(this.ManageGroupProject_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}