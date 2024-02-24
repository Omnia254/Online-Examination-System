namespace ExaminationSystem.Panels.Student
{
	partial class Grades
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			GradesPanel = new Panel();
			Title = new Label();
			GradesPanel.SuspendLayout();
			SuspendLayout();
			// 
			// GradesPanel
			// 
			GradesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			GradesPanel.Controls.Add(Title);
			GradesPanel.Location = new Point(0, 0);
			GradesPanel.Name = "GradesPanel";
			GradesPanel.Size = new Size(930, 728);
			GradesPanel.TabIndex = 0;
			// 
			// Title
			// 
			Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Title.AutoSize = true;
			Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Title.ForeColor = Color.FromArgb(174, 37, 43);
			Title.Location = new Point(390, 24);
			Title.MaximumSize = new Size(0, 50);
			Title.MinimumSize = new Size(0, 50);
			Title.Name = "Title";
			Title.Size = new Size(151, 50);
			Title.TabIndex = 35;
			Title.Text = "GRADES";
			// 
			// Grades
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(GradesPanel);
			Name = "Grades";
			Size = new Size(930, 728);
			GradesPanel.ResumeLayout(false);
			GradesPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel GradesPanel;
		private Label Title;
	}
}
