using ExaminationSystem.Panels.Instructor;

namespace ExaminationSystem
{
	partial class InstructorDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorDashboard));
			LeftSideBar = new Panel();
			LogOut = new Button();
			button4 = new Button();
			GenerateExam = new Button();
			EditQuestionButton = new Button();
			AddQuestionButton = new Button();
			InstructorNameLabel = new Label();
			StudentImage = new PictureBox();
			Header = new Panel();
			ImagePanel = new Panel();
			MainPanel = new Panel();
			generateExam1 = new GenerateExam();
			addQuestion1 = new AddQuestion();
			editQuestion1 = new EditQuestion();
			LeftSideBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)StudentImage).BeginInit();
			Header.SuspendLayout();
			SuspendLayout();
			// 
			// LeftSideBar
			// 
			LeftSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			LeftSideBar.BackColor = Color.FromArgb(174, 37, 43);
			LeftSideBar.Controls.Add(LogOut);
			LeftSideBar.Controls.Add(button4);
			LeftSideBar.Controls.Add(GenerateExam);
			LeftSideBar.Controls.Add(EditQuestionButton);
			LeftSideBar.Controls.Add(AddQuestionButton);
			LeftSideBar.Controls.Add(InstructorNameLabel);
			LeftSideBar.Controls.Add(StudentImage);
			LeftSideBar.Location = new Point(0, 0);
			LeftSideBar.Name = "LeftSideBar";
			LeftSideBar.Size = new Size(350, 855);
			LeftSideBar.TabIndex = 0;
			// 
			// LogOut
			// 
			LogOut.Anchor = AnchorStyles.Bottom;
			LogOut.BackColor = Color.White;
			LogOut.FlatAppearance.BorderSize = 0;
			LogOut.FlatStyle = FlatStyle.Flat;
			LogOut.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LogOut.ForeColor = Color.Black;
			LogOut.Location = new Point(0, 776);
			LogOut.Name = "LogOut";
			LogOut.Size = new Size(350, 49);
			LogOut.TabIndex = 6;
			LogOut.Text = "Log Out";
			LogOut.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			button4.BackColor = Color.White;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.Black;
			button4.Location = new Point(0, 590);
			button4.Name = "button4";
			button4.Size = new Size(350, 49);
			button4.TabIndex = 5;
			button4.Text = "button4";
			button4.UseVisualStyleBackColor = false;
			// 
			// GenerateExam
			// 
			GenerateExam.BackColor = Color.White;
			GenerateExam.FlatAppearance.BorderSize = 0;
			GenerateExam.FlatStyle = FlatStyle.Flat;
			GenerateExam.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			GenerateExam.ForeColor = Color.Black;
			GenerateExam.Location = new Point(0, 535);
			GenerateExam.Name = "GenerateExam";
			GenerateExam.Size = new Size(350, 49);
			GenerateExam.TabIndex = 4;
			GenerateExam.Text = "Generate Exam";
			GenerateExam.UseVisualStyleBackColor = false;
			GenerateExam.Click += GenerateExam_Click;
			// 
			// EditQuestionButton
			// 
			EditQuestionButton.BackColor = Color.White;
			EditQuestionButton.FlatAppearance.BorderSize = 0;
			EditQuestionButton.FlatStyle = FlatStyle.Flat;
			EditQuestionButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			EditQuestionButton.ForeColor = Color.Black;
			EditQuestionButton.Location = new Point(0, 480);
			EditQuestionButton.Name = "EditQuestionButton";
			EditQuestionButton.Size = new Size(350, 49);
			EditQuestionButton.TabIndex = 3;
			EditQuestionButton.Text = "Edit Question";
			EditQuestionButton.UseVisualStyleBackColor = false;
			EditQuestionButton.Click += EditQuestionButton_Click;
			// 
			// AddQuestionButton
			// 
			AddQuestionButton.BackColor = Color.White;
			AddQuestionButton.FlatAppearance.BorderSize = 0;
			AddQuestionButton.FlatStyle = FlatStyle.Flat;
			AddQuestionButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			AddQuestionButton.ForeColor = Color.Black;
			AddQuestionButton.Location = new Point(0, 425);
			AddQuestionButton.Name = "AddQuestionButton";
			AddQuestionButton.Size = new Size(350, 49);
			AddQuestionButton.TabIndex = 2;
			AddQuestionButton.Text = "Add Question";
			AddQuestionButton.UseVisualStyleBackColor = false;
			AddQuestionButton.Click += AddQuestionBtn_Click;
			// 
			// InstructorNameLabel
			// 
			InstructorNameLabel.AutoSize = true;
			InstructorNameLabel.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			InstructorNameLabel.ForeColor = Color.White;
			InstructorNameLabel.Location = new Point(47, 303);
			InstructorNameLabel.MaximumSize = new Size(250, 80);
			InstructorNameLabel.MinimumSize = new Size(250, 35);
			InstructorNameLabel.Name = "InstructorNameLabel";
			InstructorNameLabel.RightToLeft = RightToLeft.No;
			InstructorNameLabel.Size = new Size(250, 35);
			InstructorNameLabel.TabIndex = 1;
			InstructorNameLabel.Text = "Instructor Name";
			InstructorNameLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// StudentImage
			// 
			StudentImage.BackgroundImage = (Image)resources.GetObject("StudentImage.BackgroundImage");
			StudentImage.BackgroundImageLayout = ImageLayout.Stretch;
			StudentImage.Location = new Point(47, 25);
			StudentImage.Name = "StudentImage";
			StudentImage.Size = new Size(250, 250);
			StudentImage.TabIndex = 0;
			StudentImage.TabStop = false;
			// 
			// Header
			// 
			Header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			Header.BackColor = Color.White;
			Header.BackgroundImageLayout = ImageLayout.Center;
			Header.Controls.Add(ImagePanel);
			Header.Location = new Point(350, 0);
			Header.Name = "Header";
			Header.Size = new Size(930, 125);
			Header.TabIndex = 0;
			// 
			// ImagePanel
			// 
			ImagePanel.Anchor = AnchorStyles.Top;
			ImagePanel.BackColor = Color.White;
			ImagePanel.BackgroundImage = (Image)resources.GetObject("ImagePanel.BackgroundImage");
			ImagePanel.BackgroundImageLayout = ImageLayout.Stretch;
			ImagePanel.Location = new Point(315, 0);
			ImagePanel.Name = "ImagePanel";
			ImagePanel.Size = new Size(300, 113);
			ImagePanel.TabIndex = 1;
			// 
			// MainPanel
			// 
			MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			MainPanel.BackColor = Color.FromArgb(242, 242, 242);
			MainPanel.Controls.Add(generateExam1);
			MainPanel.Controls.Add(addQuestion1);
			MainPanel.Controls.Add(editQuestion1);
			MainPanel.Location = new Point(350, 125);
			MainPanel.Name = "MainPanel";
			MainPanel.Size = new Size(930, 728);
			MainPanel.TabIndex = 2;
			// 
			// InstructorDashboard
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1282, 853);
			Controls.Add(MainPanel);
			Controls.Add(Header);
			Controls.Add(LeftSideBar);
			MinimumSize = new Size(1300, 900);
			Name = "InstructorDashboard";
			Text = "StudentDashboard";
			LeftSideBar.ResumeLayout(false);
			LeftSideBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)StudentImage).EndInit();
			Header.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel LeftSideBar;
		private Panel Header;
		private Panel ImagePanel;
		private Panel MainPanel;
		private PictureBox StudentImage;
		private Label InstructorNameLabel;
		private Button AddQuestionButton;
		private Button button4;
		private Button GenerateExam;
		private Button EditQuestionButton;
		private Button LogOut;
		private Panels.Instructor.AddQuestion addQuestion1;
		private Panels.Instructor.GenerateExam generateExam1;
		private Panels.Instructor.EditQuestion editQuestion1;
	}
}