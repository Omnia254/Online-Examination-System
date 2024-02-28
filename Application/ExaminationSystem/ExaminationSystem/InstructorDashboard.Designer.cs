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
            AdvancedButton = new Button();
            HomeButton = new Button();
            LogOut = new Button();
            ProfileButton = new Button();
            GenerateExamButton = new Button();
            EditQuestionButton = new Button();
            AddQuestionButton = new Button();
            InstructorNameLabel = new Label();
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
            LeftSideBar.Controls.Add(AdvancedButton);
            LeftSideBar.Controls.Add(HomeButton);
            LeftSideBar.Controls.Add(LogOut);
            LeftSideBar.Controls.Add(ProfileButton);
            LeftSideBar.Controls.Add(GenerateExamButton);
            LeftSideBar.Controls.Add(EditQuestionButton);
            LeftSideBar.Controls.Add(AddQuestionButton);
            LeftSideBar.Controls.Add(InstructorNameLabel);
            LeftSideBar.Controls.Add(StudentImage);
            LeftSideBar.Location = new Point(0, 0);
            LeftSideBar.Name = "LeftSideBar";
            LeftSideBar.Size = new Size(350, 855);
            LeftSideBar.TabIndex = 0;
            // 
            // AdvancedButton
            // 
            AdvancedButton.BackColor = Color.White;
            AdvancedButton.FlatAppearance.BorderSize = 0;
            AdvancedButton.FlatStyle = FlatStyle.Flat;
            AdvancedButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdvancedButton.ForeColor = Color.Black;
            AdvancedButton.Location = new Point(0, 685);
            AdvancedButton.Name = "AdvancedButton";
            AdvancedButton.Size = new Size(350, 49);
            AdvancedButton.TabIndex = 8;
            AdvancedButton.Text = "Advanced";
            AdvancedButton.UseVisualStyleBackColor = false;
            AdvancedButton.Click += AdvancedButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.White;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.Black;
            HomeButton.Location = new Point(0, 410);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(350, 49);
            HomeButton.TabIndex = 7;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
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
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.White;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            ProfileButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileButton.ForeColor = Color.Black;
            ProfileButton.Location = new Point(0, 465);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(350, 49);
            ProfileButton.TabIndex = 5;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // GenerateExamButton
            // 
            GenerateExamButton.BackColor = Color.White;
            GenerateExamButton.FlatAppearance.BorderSize = 0;
            GenerateExamButton.FlatStyle = FlatStyle.Flat;
            GenerateExamButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenerateExamButton.ForeColor = Color.Black;
            GenerateExamButton.Location = new Point(0, 630);
            GenerateExamButton.Name = "GenerateExamButton";
            GenerateExamButton.Size = new Size(350, 49);
            GenerateExamButton.TabIndex = 4;
            GenerateExamButton.Text = "Generate Exam";
            GenerateExamButton.UseVisualStyleBackColor = false;
            GenerateExamButton.Click += GenerateExam_Click;
            // 
            // EditQuestionButton
            // 
            EditQuestionButton.BackColor = Color.White;
            EditQuestionButton.FlatAppearance.BorderSize = 0;
            EditQuestionButton.FlatStyle = FlatStyle.Flat;
            EditQuestionButton.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditQuestionButton.ForeColor = Color.Black;
            EditQuestionButton.Location = new Point(0, 575);
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
            AddQuestionButton.Location = new Point(0, 520);
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
            MaximumSize = new Size(1300, 900);
            MinimumSize = new Size(1300, 900);
            Name = "InstructorDashboard";
            Text = "StudentDashboard";
            FormClosing += InstructorDashboard_FormClosing;
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
		public Panel MainPanel;
		private PictureBox StudentImage;
		private Label InstructorNameLabel;
		private Button AddQuestionButton;
		private Button ProfileButton;
		private Button GenerateExamButton;
		private Button EditQuestionButton;
		private Button LogOut;
		private Panels.Instructor.AddQuestion addQuestion1;
		private Panels.Instructor.GenerateExam generateExam1;
		private Panels.Instructor.EditQuestion editQuestion1;
		private InstructorProfile instructorProfile1;
        private Advanced advanced1;
		private InstructorHome instructorHome1;
		private Button HomeButton;
        private Button AdvancedButton;
    }
}