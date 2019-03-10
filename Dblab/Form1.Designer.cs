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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.lala = new System.Windows.Forms.Label();
			this.TotalMarks = new System.Windows.Forms.Label();
			this.TotalWeightage = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(75, 194);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(615, 204);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(491, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(345, 154);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(188, 154);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Insert";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// lala
			// 
			this.lala.AutoSize = true;
			this.lala.Location = new System.Drawing.Point(152, 52);
			this.lala.Name = "lala";
			this.lala.Size = new System.Drawing.Size(23, 13);
			this.lala.TabIndex = 5;
			this.lala.Text = "lala";
			this.lala.Click += new System.EventHandler(this.Name_Click);
			// 
			// TotalMarks
			// 
			this.TotalMarks.AutoSize = true;
			this.TotalMarks.Location = new System.Drawing.Point(152, 85);
			this.TotalMarks.Name = "TotalMarks";
			this.TotalMarks.Size = new System.Drawing.Size(60, 13);
			this.TotalMarks.TabIndex = 6;
			this.TotalMarks.Text = "TotalMarks";
			this.TotalMarks.Click += new System.EventHandler(this.TotalMarks_Click);
			// 
			// TotalWeightage
			// 
			this.TotalWeightage.AutoSize = true;
			this.TotalWeightage.Location = new System.Drawing.Point(152, 116);
			this.TotalWeightage.Name = "TotalWeightage";
			this.TotalWeightage.Size = new System.Drawing.Size(83, 13);
			this.TotalWeightage.TabIndex = 7;
			this.TotalWeightage.Text = "TotalWeightage";
			this.TotalWeightage.Click += new System.EventHandler(this.TotalWeightage_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(360, 45);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 9;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(360, 78);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(360, 109);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 11;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(649, 78);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 12;
			this.button4.Text = "Student";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Evaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.TotalWeightage);
			this.Controls.Add(this.TotalMarks);
			this.Controls.Add(this.lala);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Evaluation";
			this.Text = "Evaluation";
			this.Load += new System.EventHandler(this.Evaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label lala;
		private System.Windows.Forms.Label TotalMarks;
		private System.Windows.Forms.Label TotalWeightage;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button4;
	}
}

