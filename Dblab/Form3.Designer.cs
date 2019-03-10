namespace Dblab
{
	partial class PersonInformation
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
			this.Delete = new System.Windows.Forms.Button();
			this.Show = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(109, 110);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(554, 150);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(468, 66);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 1;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Show
			// 
			this.Show.Location = new System.Drawing.Point(227, 66);
			this.Show.Name = "Show";
			this.Show.Size = new System.Drawing.Size(75, 23);
			this.Show.TabIndex = 2;
			this.Show.Text = "Show Data";
			this.Show.UseVisualStyleBackColor = true;
			this.Show.Click += new System.EventHandler(this.Show_Click);
			// 
			// Update
			// 
			this.Update.Location = new System.Drawing.Point(340, 66);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(75, 23);
			this.Update.TabIndex = 3;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// PersonInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.Show);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.dataGridView1);
			this.Name = "PersonInformation";
			this.Text = "PersonInformation";
			this.Load += new System.EventHandler(this.PersonInformation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button Show;
		private System.Windows.Forms.Button Update;
	}
}