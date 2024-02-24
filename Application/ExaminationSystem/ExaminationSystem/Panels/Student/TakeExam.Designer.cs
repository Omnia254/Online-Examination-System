namespace ExaminationSystem.Panels.Student
{
	partial class TakeExam
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
			TakeExamPanel = new Panel();
			Title = new Label();
			TakeExamPanel.SuspendLayout();
			SuspendLayout();
			// 
			// TakeExamPanel
			// 
			TakeExamPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			TakeExamPanel.Controls.Add(Title);
			TakeExamPanel.Location = new Point(0, 0);
			TakeExamPanel.Name = "TakeExamPanel";
			TakeExamPanel.Size = new Size(930, 728);
			TakeExamPanel.TabIndex = 0;
			// 
			// Title
			// 
			Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Title.AutoSize = true;
			Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Title.ForeColor = Color.FromArgb(174, 37, 43);
			Title.Location = new Point(361, 24);
			Title.MaximumSize = new Size(0, 50);
			Title.MinimumSize = new Size(0, 50);
			Title.Name = "Title";
			Title.Size = new Size(208, 50);
			Title.TabIndex = 34;
			Title.Text = "TAKE EXAM";
			// 
			// TakeExam
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(TakeExamPanel);
			Name = "TakeExam";
			Size = new Size(930, 728);
			TakeExamPanel.ResumeLayout(false);
			TakeExamPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel TakeExamPanel;
		private Label Title;
	}
}
