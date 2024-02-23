namespace ExaminationSystem.Panels.Instructor
{
	partial class GenerateExam
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
			GenerateExamPanel = new Panel();
			NoOfMCQQuestions = new ComboBox();
			NoOfMCQLabel = new Label();
			NoOfTFQuestion = new ComboBox();
			NoOfTFLabel = new Label();
			Complexity = new ComboBox();
			ComplexityLabel = new Label();
			GenerateBtn = new Button();
			Course = new ComboBox();
			CourseLabel = new Label();
			Title = new Label();
			GenerateExamPanel.SuspendLayout();
			SuspendLayout();
			// 
			// GenerateExamPanel
			// 
			GenerateExamPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			GenerateExamPanel.Controls.Add(NoOfMCQQuestions);
			GenerateExamPanel.Controls.Add(NoOfMCQLabel);
			GenerateExamPanel.Controls.Add(NoOfTFQuestion);
			GenerateExamPanel.Controls.Add(NoOfTFLabel);
			GenerateExamPanel.Controls.Add(Complexity);
			GenerateExamPanel.Controls.Add(ComplexityLabel);
			GenerateExamPanel.Controls.Add(GenerateBtn);
			GenerateExamPanel.Controls.Add(Course);
			GenerateExamPanel.Controls.Add(CourseLabel);
			GenerateExamPanel.Controls.Add(Title);
			GenerateExamPanel.Location = new Point(0, 0);
			GenerateExamPanel.Name = "GenerateExamPanel";
			GenerateExamPanel.Size = new Size(930, 728);
			GenerateExamPanel.TabIndex = 0;
			// 
			// NoOfMCQQuestions
			// 
			NoOfMCQQuestions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			NoOfMCQQuestions.FlatStyle = FlatStyle.Flat;
			NoOfMCQQuestions.Font = new Font("Candara", 10.8F);
			NoOfMCQQuestions.FormattingEnabled = true;
			NoOfMCQQuestions.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			NoOfMCQQuestions.Location = new Point(485, 437);
			NoOfMCQQuestions.MaximumSize = new Size(250, 0);
			NoOfMCQQuestions.MinimumSize = new Size(250, 0);
			NoOfMCQQuestions.Name = "NoOfMCQQuestions";
			NoOfMCQQuestions.Size = new Size(250, 30);
			NoOfMCQQuestions.TabIndex = 56;
			NoOfMCQQuestions.Text = "Choose Number";
			// 
			// NoOfMCQLabel
			// 
			NoOfMCQLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			NoOfMCQLabel.AutoSize = true;
			NoOfMCQLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			NoOfMCQLabel.Location = new Point(222, 434);
			NoOfMCQLabel.MaximumSize = new Size(0, 30);
			NoOfMCQLabel.MinimumSize = new Size(0, 30);
			NoOfMCQLabel.Name = "NoOfMCQLabel";
			NoOfMCQLabel.Size = new Size(234, 30);
			NoOfMCQLabel.TabIndex = 55;
			NoOfMCQLabel.Text = "No. Of MCQ Questions";
			// 
			// NoOfTFQuestion
			// 
			NoOfTFQuestion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			NoOfTFQuestion.FlatStyle = FlatStyle.Flat;
			NoOfTFQuestion.Font = new Font("Candara", 10.8F);
			NoOfTFQuestion.FormattingEnabled = true;
			NoOfTFQuestion.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
			NoOfTFQuestion.Location = new Point(485, 352);
			NoOfTFQuestion.MaximumSize = new Size(250, 0);
			NoOfTFQuestion.MinimumSize = new Size(250, 0);
			NoOfTFQuestion.Name = "NoOfTFQuestion";
			NoOfTFQuestion.Size = new Size(250, 30);
			NoOfTFQuestion.TabIndex = 54;
			NoOfTFQuestion.Text = "Choose Number";
			// 
			// NoOfTFLabel
			// 
			NoOfTFLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			NoOfTFLabel.AutoSize = true;
			NoOfTFLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			NoOfTFLabel.Location = new Point(222, 349);
			NoOfTFLabel.MaximumSize = new Size(0, 30);
			NoOfTFLabel.MinimumSize = new Size(0, 30);
			NoOfTFLabel.Name = "NoOfTFLabel";
			NoOfTFLabel.Size = new Size(214, 30);
			NoOfTFLabel.TabIndex = 53;
			NoOfTFLabel.Text = "No. Of T/F Questions";
			// 
			// Complexity
			// 
			Complexity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			Complexity.FlatStyle = FlatStyle.Flat;
			Complexity.Font = new Font("Candara", 10.8F);
			Complexity.FormattingEnabled = true;
			Complexity.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
			Complexity.Location = new Point(485, 268);
			Complexity.MaximumSize = new Size(250, 0);
			Complexity.MinimumSize = new Size(250, 0);
			Complexity.Name = "Complexity";
			Complexity.Size = new Size(250, 30);
			Complexity.TabIndex = 52;
			Complexity.Text = "Choose Exam Complexity";
			// 
			// ComplexityLabel
			// 
			ComplexityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			ComplexityLabel.AutoSize = true;
			ComplexityLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ComplexityLabel.Location = new Point(222, 265);
			ComplexityLabel.MaximumSize = new Size(0, 30);
			ComplexityLabel.MinimumSize = new Size(0, 30);
			ComplexityLabel.Name = "ComplexityLabel";
			ComplexityLabel.Size = new Size(125, 30);
			ComplexityLabel.TabIndex = 51;
			ComplexityLabel.Text = "Complexity";
			// 
			// GenerateBtn
			// 
			GenerateBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			GenerateBtn.BackColor = Color.FromArgb(174, 37, 43);
			GenerateBtn.FlatStyle = FlatStyle.Flat;
			GenerateBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			GenerateBtn.ForeColor = Color.White;
			GenerateBtn.Location = new Point(578, 525);
			GenerateBtn.Name = "GenerateBtn";
			GenerateBtn.Size = new Size(157, 49);
			GenerateBtn.TabIndex = 49;
			GenerateBtn.Text = "Generate";
			GenerateBtn.UseVisualStyleBackColor = false;
			GenerateBtn.Click += GenerateBtn_Click;
			// 
			// Course
			// 
			Course.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			Course.FlatStyle = FlatStyle.Flat;
			Course.Font = new Font("Candara", 10.8F);
			Course.FormattingEnabled = true;
			Course.Items.AddRange(new object[] { "T/F", "MCQ" });
			Course.Location = new Point(485, 183);
			Course.MaximumSize = new Size(250, 0);
			Course.MinimumSize = new Size(250, 0);
			Course.Name = "Course";
			Course.Size = new Size(250, 30);
			Course.TabIndex = 48;
			// 
			// CourseLabel
			// 
			CourseLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			CourseLabel.AutoSize = true;
			CourseLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			CourseLabel.Location = new Point(222, 180);
			CourseLabel.MaximumSize = new Size(0, 30);
			CourseLabel.MinimumSize = new Size(0, 30);
			CourseLabel.Name = "CourseLabel";
			CourseLabel.Size = new Size(81, 30);
			CourseLabel.TabIndex = 47;
			CourseLabel.Text = "Course";
			// 
			// Title
			// 
			Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			Title.AutoSize = true;
			Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Title.ForeColor = Color.FromArgb(174, 37, 43);
			Title.Location = new Point(317, 24);
			Title.MaximumSize = new Size(0, 50);
			Title.MinimumSize = new Size(0, 50);
			Title.Name = "Title";
			Title.Size = new Size(296, 50);
			Title.TabIndex = 34;
			Title.Text = "GENERATE EXAM";
			// 
			// GenerateExam
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(GenerateExamPanel);
			Name = "GenerateExam";
			Size = new Size(930, 728);
			GenerateExamPanel.ResumeLayout(false);
			GenerateExamPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel GenerateExamPanel;
		private Label Title;
		private ComboBox Complexity;
		private Label ComplexityLabel;
		private Button GenerateBtn;
		private ComboBox Course;
		private Label CourseLabel;
		private ComboBox NoOfTFQuestion;
		private Label NoOfTFLabel;
		private ComboBox NoOfMCQQuestions;
		private Label NoOfMCQLabel;
	}
}
