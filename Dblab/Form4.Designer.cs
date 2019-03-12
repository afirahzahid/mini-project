namespace Dblab
{
	partial class Main_Form
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
			this.Manage_Students = new System.Windows.Forms.Button();
			this.Manage_Advisors = new System.Windows.Forms.Button();
			this.Manage_Projects = new System.Windows.Forms.Button();
			this.Manage_Evaluation = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Manage_Students
			// 
			this.Manage_Students.Location = new System.Drawing.Point(304, 85);
			this.Manage_Students.Name = "Manage_Students";
			this.Manage_Students.Size = new System.Drawing.Size(152, 39);
			this.Manage_Students.TabIndex = 0;
			this.Manage_Students.Text = "Manage Students";
			this.Manage_Students.UseVisualStyleBackColor = true;
			this.Manage_Students.Click += new System.EventHandler(this.button1_Click);
			// 
			// Manage_Advisors
			// 
			this.Manage_Advisors.Location = new System.Drawing.Point(304, 139);
			this.Manage_Advisors.Name = "Manage_Advisors";
			this.Manage_Advisors.Size = new System.Drawing.Size(152, 38);
			this.Manage_Advisors.TabIndex = 1;
			this.Manage_Advisors.Text = "Manage Advisors";
			this.Manage_Advisors.UseVisualStyleBackColor = true;
			// 
			// Manage_Projects
			// 
			this.Manage_Projects.Location = new System.Drawing.Point(304, 195);
			this.Manage_Projects.Name = "Manage_Projects";
			this.Manage_Projects.Size = new System.Drawing.Size(152, 36);
			this.Manage_Projects.TabIndex = 2;
			this.Manage_Projects.Text = "Manage Projects";
			this.Manage_Projects.UseVisualStyleBackColor = true;
			this.Manage_Projects.Click += new System.EventHandler(this.Manage_Projects_Click);
			// 
			// Manage_Evaluation
			// 
			this.Manage_Evaluation.Location = new System.Drawing.Point(304, 251);
			this.Manage_Evaluation.Name = "Manage_Evaluation";
			this.Manage_Evaluation.Size = new System.Drawing.Size(152, 35);
			this.Manage_Evaluation.TabIndex = 3;
			this.Manage_Evaluation.Text = "Manage Evaluation";
			this.Manage_Evaluation.UseVisualStyleBackColor = true;
			this.Manage_Evaluation.Click += new System.EventHandler(this.button4_Click);
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Manage_Evaluation);
			this.Controls.Add(this.Manage_Projects);
			this.Controls.Add(this.Manage_Advisors);
			this.Controls.Add(this.Manage_Students);
			this.Name = "Main_Form";
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.Main_Form_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Manage_Students;
		private System.Windows.Forms.Button Manage_Advisors;
		private System.Windows.Forms.Button Manage_Projects;
		private System.Windows.Forms.Button Manage_Evaluation;
	}
}