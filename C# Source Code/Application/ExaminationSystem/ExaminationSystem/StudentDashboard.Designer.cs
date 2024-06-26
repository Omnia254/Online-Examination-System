﻿using ExaminationSystem.Panels.Student;

namespace ExaminationSystem
{
	partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            LeftSideBar = new Panel();
            EnrolledCoursesBtn = new Button();
            GrievanceButton = new Button();
            LogOut = new Button();
            HomeButton = new Button();
            GradesButton = new Button();
            TakeExamButton = new Button();
            ProfileButton = new Button();
            StudentNameLabel = new Label();
            StudentImage = new PictureBox();
            Header = new Panel();
            ImagePanel = new Panel();
            MainPanel = new Panel();
            LeftSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentImage).BeginInit();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // LeftSideBar
            // 
            LeftSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LeftSideBar.BackColor = Color.FromArgb(174, 37, 43);
            LeftSideBar.Controls.Add(EnrolledCoursesBtn);
            LeftSideBar.Controls.Add(GrievanceButton);
            LeftSideBar.Controls.Add(LogOut);
            LeftSideBar.Controls.Add(HomeButton);
            LeftSideBar.Controls.Add(GradesButton);
            LeftSideBar.Controls.Add(TakeExamButton);
            LeftSideBar.Controls.Add(ProfileButton);
            LeftSideBar.Controls.Add(StudentNameLabel);
            LeftSideBar.Controls.Add(StudentImage);
            LeftSideBar.Location = new Point(0, 0);
            LeftSideBar.Name = "LeftSideBar";
            LeftSideBar.Size = new Size(350, 855);
            LeftSideBar.TabIndex = 0;
            // 
            // EnrolledCoursesBtn
            // 
            EnrolledCoursesBtn.BackColor = Color.White;
            EnrolledCoursesBtn.FlatAppearance.BorderSize = 0;
            EnrolledCoursesBtn.FlatStyle = FlatStyle.Flat;
            EnrolledCoursesBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrolledCoursesBtn.ForeColor = Color.Black;
            EnrolledCoursesBtn.Location = new Point(0, 689);
            EnrolledCoursesBtn.Name = "EnrolledCoursesBtn";
            EnrolledCoursesBtn.Size = new Size(350, 49);
            EnrolledCoursesBtn.TabIndex = 8;
            EnrolledCoursesBtn.Text = "Enrolled Courses";
            EnrolledCoursesBtn.UseVisualStyleBackColor = false;
            EnrolledCoursesBtn.Click += EnrolledCoursesBtn_Click;
            // 
            // GrievanceButton
            // 
            GrievanceButton.BackColor = Color.White;
            GrievanceButton.FlatAppearance.BorderSize = 0;
            GrievanceButton.FlatStyle = FlatStyle.Flat;
            GrievanceButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrievanceButton.ForeColor = Color.Black;
            GrievanceButton.Location = new Point(0, 634);
            GrievanceButton.Name = "GrievanceButton";
            GrievanceButton.Size = new Size(350, 49);
            GrievanceButton.TabIndex = 7;
            GrievanceButton.Text = "Grievance";
            GrievanceButton.UseVisualStyleBackColor = false;
            GrievanceButton.Click += GrievanceButton_Click;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Bottom;
            LogOut.BackColor = Color.White;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Black;
            LogOut.Location = new Point(0, 792);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(350, 49);
            LogOut.TabIndex = 6;
            LogOut.Text = "Log Out";
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.White;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.Black;
            HomeButton.Location = new Point(0, 414);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(350, 49);
            HomeButton.TabIndex = 5;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // GradesButton
            // 
            GradesButton.BackColor = Color.White;
            GradesButton.FlatAppearance.BorderSize = 0;
            GradesButton.FlatStyle = FlatStyle.Flat;
            GradesButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradesButton.ForeColor = Color.Black;
            GradesButton.Location = new Point(0, 579);
            GradesButton.Name = "GradesButton";
            GradesButton.Size = new Size(350, 49);
            GradesButton.TabIndex = 4;
            GradesButton.Text = "Grades";
            GradesButton.UseVisualStyleBackColor = false;
            GradesButton.Click += GradesButton_Click;
            // 
            // TakeExamButton
            // 
            TakeExamButton.BackColor = Color.White;
            TakeExamButton.FlatAppearance.BorderSize = 0;
            TakeExamButton.FlatStyle = FlatStyle.Flat;
            TakeExamButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TakeExamButton.ForeColor = Color.Black;
            TakeExamButton.Location = new Point(0, 524);
            TakeExamButton.Name = "TakeExamButton";
            TakeExamButton.Size = new Size(350, 49);
            TakeExamButton.TabIndex = 3;
            TakeExamButton.Text = "Take Exam";
            TakeExamButton.UseVisualStyleBackColor = false;
            TakeExamButton.Click += TakeExamButton_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.White;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            ProfileButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileButton.ForeColor = Color.Black;
            ProfileButton.Location = new Point(0, 469);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(350, 49);
            ProfileButton.TabIndex = 2;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNameLabel.ForeColor = Color.White;
            StudentNameLabel.Location = new Point(47, 303);
            StudentNameLabel.MaximumSize = new Size(250, 80);
            StudentNameLabel.MinimumSize = new Size(250, 35);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.RightToLeft = RightToLeft.No;
            StudentNameLabel.Size = new Size(250, 35);
            StudentNameLabel.TabIndex = 1;
            StudentNameLabel.Text = "Student Name";
            StudentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = Color.FromArgb(242, 242, 242);
            MainPanel.Location = new Point(350, 125);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(930, 728);
            MainPanel.TabIndex = 2;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 853);
            Controls.Add(MainPanel);
            Controls.Add(Header);
            Controls.Add(LeftSideBar);
            MaximumSize = new Size(1300, 900);
            MinimumSize = new Size(1300, 900);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            FormClosing += StudentDashboard_FormClosing;
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
		private Label StudentNameLabel;
		private Button ProfileButton;
		private Button HomeButton;
		private Button GradesButton;
		private Button TakeExamButton;
		private Button LogOut;
		private StudentProfile studentProfile1;
		public Panels.Student.TakeExam takeExam1;
		private Grades grades1;
        private Grievance grievance1;
		private StudentHome studentHome1;
        private EnrolledCourses enrolledCourses1;
        public AssignExam assignExam1;
        private Button GrievanceButton;
        private Button EnrolledCoursesBtn;
    }
}