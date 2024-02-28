namespace ExaminationSystem.Panels.Instructor
{
    partial class AddCourse
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
            AddCoursePanel = new Panel();
            TopicNameLabel = new Label();
            CourseNameLabel = new Label();
            Title = new Label();
            AddCourseBtn = new Button();
            TopicName = new ComboBox();
            CourseNametextBox = new TextBox();
            AddCoursePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddCoursePanel
            // 
            AddCoursePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddCoursePanel.Controls.Add(TopicNameLabel);
            AddCoursePanel.Controls.Add(CourseNameLabel);
            AddCoursePanel.Controls.Add(Title);
            AddCoursePanel.Controls.Add(AddCourseBtn);
            AddCoursePanel.Controls.Add(TopicName);
            AddCoursePanel.Controls.Add(CourseNametextBox);
            AddCoursePanel.Location = new Point(0, 0);
            AddCoursePanel.Name = "AddCoursePanel";
            AddCoursePanel.Size = new Size(930, 728);
            AddCoursePanel.TabIndex = 0;
            // 
            // TopicNameLabel
            // 
            TopicNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TopicNameLabel.AutoSize = true;
            TopicNameLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopicNameLabel.Location = new Point(252, 281);
            TopicNameLabel.MaximumSize = new Size(0, 30);
            TopicNameLabel.MinimumSize = new Size(0, 30);
            TopicNameLabel.Name = "TopicNameLabel";
            TopicNameLabel.Size = new Size(127, 30);
            TopicNameLabel.TabIndex = 53;
            TopicNameLabel.Text = "Topic Name";
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseNameLabel.Location = new Point(252, 203);
            CourseNameLabel.MaximumSize = new Size(0, 30);
            CourseNameLabel.MinimumSize = new Size(0, 30);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(143, 30);
            CourseNameLabel.TabIndex = 52;
            CourseNameLabel.Text = "Course Name";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(350, 24);
            Title.MaximumSize = new Size(0, 38);
            Title.MinimumSize = new Size(0, 38);
            Title.Name = "Title";
            Title.Size = new Size(230, 38);
            Title.TabIndex = 50;
            Title.Text = "ADD COURSE";
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddCourseBtn.BackColor = Color.FromArgb(174, 37, 43);
            AddCourseBtn.FlatStyle = FlatStyle.Flat;
            AddCourseBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCourseBtn.ForeColor = Color.White;
            AddCourseBtn.Location = new Point(521, 373);
            AddCourseBtn.Margin = new Padding(3, 2, 3, 2);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Size = new Size(157, 49);
            AddCourseBtn.TabIndex = 49;
            AddCourseBtn.Text = "Add Course";
            AddCourseBtn.UseVisualStyleBackColor = false;
            AddCourseBtn.Click += AddCourseBtn_Click;
            // 
            // TopicName
            // 
            TopicName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TopicName.FlatStyle = FlatStyle.Flat;
            TopicName.Font = new Font("Candara", 10.8F);
            TopicName.FormattingEnabled = true;
            TopicName.Items.AddRange(new object[] { "T/F", "MCQ" });
            TopicName.Location = new Point(459, 281);
            TopicName.Margin = new Padding(3, 2, 3, 2);
            TopicName.MaximumSize = new Size(219, 0);
            TopicName.MinimumSize = new Size(219, 0);
            TopicName.Name = "TopicName";
            TopicName.Size = new Size(219, 30);
            TopicName.TabIndex = 47;
            TopicName.Text = "Choose Topic";
            // 
            // CourseNametextBox
            // 
            CourseNametextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CourseNametextBox.BackColor = Color.White;
            CourseNametextBox.BorderStyle = BorderStyle.None;
            CourseNametextBox.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CourseNametextBox.Location = new Point(459, 203);
            CourseNametextBox.Margin = new Padding(3, 2, 3, 2);
            CourseNametextBox.MaximumSize = new Size(219, 30);
            CourseNametextBox.MinimumSize = new Size(219, 30);
            CourseNametextBox.Name = "CourseNametextBox";
            CourseNametextBox.Size = new Size(219, 30);
            CourseNametextBox.TabIndex = 46;
            // 
            // AddCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddCoursePanel);
            Name = "AddCourse";
            Size = new Size(930, 728);
            AddCoursePanel.ResumeLayout(false);
            AddCoursePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AddCoursePanel;
        private Label CourseNameLabel11;
        private TextBox CourseNametextBox;
        private ComboBox TopicName;
        private Button AddCourseBtn;
        private Label Title;
        private Label CourseNameLabel;
        private Label TopicNameLabel;
    }
}
