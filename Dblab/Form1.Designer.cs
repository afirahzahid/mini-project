namespace Dblab
{
	partial class Evaluation
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Back = new System.Windows.Forms.Button();
			this.Show_Data = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.TotalMarks = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.TotalWeightage = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lala = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(46, 208);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(710, 223);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Back
			// 
			this.Back.BackColor = System.Drawing.Color.Yellow;
			this.Back.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.Location = new System.Drawing.Point(3, 3);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(62, 40);
			this.Back.TabIndex = 13;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Show_Data
			// 
			this.Show_Data.BackColor = System.Drawing.Color.Yellow;
			this.Show_Data.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Show_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Show_Data.Location = new System.Drawing.Point(177, 3);
			this.Show_Data.Name = "Show_Data";
			this.Show_Data.Size = new System.Drawing.Size(169, 34);
			this.Show_Data.TabIndex = 12;
			this.Show_Data.Text = "Show Data";
			this.Show_Data.UseVisualStyleBackColor = false;
			this.Show_Data.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Yellow;
			this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(3, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(168, 34);
			this.button3.TabIndex = 3;
			this.button3.Text = "Insert";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point(145, 57);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(180, 20);
			this.textBox3.TabIndex = 10;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// TotalMarks
			// 
			this.TotalMarks.AutoSize = true;
			this.TotalMarks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalMarks.Location = new System.Drawing.Point(3, 54);
			this.TotalMarks.Name = "TotalMarks";
			this.TotalMarks.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.TotalMarks.Size = new System.Drawing.Size(136, 54);
			this.TotalMarks.TabIndex = 6;
			this.TotalMarks.Text = "Total Marks";
			this.TotalMarks.Click += new System.EventHandler(this.TotalMarks_Click);
			// 
			// textBox4
			// 
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Location = new System.Drawing.Point(529, 3);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(178, 20);
			this.textBox4.TabIndex = 11;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// TotalWeightage
			// 
			this.TotalWeightage.AutoSize = true;
			this.TotalWeightage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TotalWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotalWeightage.Location = new System.Drawing.Point(342, 0);
			this.TotalWeightage.Name = "TotalWeightage";
			this.TotalWeightage.Padding = new System.Windows.Forms.Padding(20, 5, 5, 0);
			this.TotalWeightage.Size = new System.Drawing.Size(181, 54);
			this.TotalWeightage.TabIndex = 7;
			this.TotalWeightage.Text = "Total Weightage";
			this.TotalWeightage.Click += new System.EventHandler(this.TotalWeightage_Click);
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(145, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(180, 20);
			this.textBox2.TabIndex = 9;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// lala
			// 
			this.lala.AutoSize = true;
			this.lala.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lala.Location = new System.Drawing.Point(3, 0);
			this.lala.Name = "lala";
			this.lala.Padding = new System.Windows.Forms.Padding(0, 5, 25, 0);
			this.lala.Size = new System.Drawing.Size(136, 54);
			this.lala.TabIndex = 5;
			this.lala.Text = "Name";
			this.lala.Click += new System.EventHandler(this.Name_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.Show_Data, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.button3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(358, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(349, 40);
			this.tableLayoutPanel2.TabIndex = 18;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tableLayoutPanel3.ColumnCount = 5;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.20968F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.612903F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.41129F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60484F));
			this.tableLayoutPanel3.Controls.Add(this.TotalMarks, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.textBox4, 4, 0);
			this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.TotalWeightage, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.lala, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(46, 42);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(710, 108);
			this.tableLayoutPanel3.TabIndex = 19;
			this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Back, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 156);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 46);
			this.tableLayoutPanel1.TabIndex = 20;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.GrayText;
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.375F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.5F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.125F));
			this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.MinimumSize = new System.Drawing.Size(400, 300);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 5;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.888889F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.55556F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.77778F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.44404F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.068592F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel4.TabIndex = 21;
			this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(710, 39);
			this.label1.TabIndex = 21;
			this.label1.Text = "Evaluation Form";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Evaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Name = "Evaluation";
			this.Text = "Evaluation";
			this.Load += new System.EventHandler(this.Evaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lala;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label TotalWeightage;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label TotalMarks;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button Show_Data;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label1;
	}
}

