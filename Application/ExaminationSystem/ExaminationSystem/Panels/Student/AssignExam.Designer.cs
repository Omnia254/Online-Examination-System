namespace ExaminationSystem.Panels.Student
{
    partial class AssignExam
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
            AssignExamPanel = new Panel();
            TakeExamBtn = new Button();
            Title = new Label();
            CName = new ComboBox();
            CourseNameLabel = new Label();
            AssignExamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AssignExamPanel
            // 
            AssignExamPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AssignExamPanel.Controls.Add(CourseNameLabel);
            AssignExamPanel.Controls.Add(TakeExamBtn);
            AssignExamPanel.Controls.Add(Title);
            AssignExamPanel.Controls.Add(CName);
            AssignExamPanel.Location = new Point(0, 0);
            AssignExamPanel.Name = "AssignExamPanel";
            AssignExamPanel.Size = new Size(930, 728);
            AssignExamPanel.TabIndex = 0;
            // 
            // TakeExamBtn
            // 
            TakeExamBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TakeExamBtn.BackColor = Color.FromArgb(174, 37, 43);
            TakeExamBtn.FlatStyle = FlatStyle.Flat;
            TakeExamBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TakeExamBtn.ForeColor = Color.White;
            TakeExamBtn.Location = new Point(497, 271);
            TakeExamBtn.Margin = new Padding(3, 2, 3, 2);
            TakeExamBtn.Name = "TakeExamBtn";
            TakeExamBtn.Size = new Size(137, 49);
            TakeExamBtn.TabIndex = 52;
            TakeExamBtn.Text = "Take Exam";
            TakeExamBtn.UseVisualStyleBackColor = false;
            TakeExamBtn.Click += TakeExamBtn_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(361, 24);
            Title.MaximumSize = new Size(0, 38);
            Title.MinimumSize = new Size(0, 38);
            Title.Name = "Title";
            Title.Size = new Size(208, 38);
            Title.TabIndex = 51;
            Title.Text = "TAKE EXAM";
            // 
            // CName
            // 
            CName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CName.FlatStyle = FlatStyle.Flat;
            CName.Font = new Font("Candara", 10.8F);
            CName.FormattingEnabled = true;
            CName.Items.AddRange(new object[] { "T/F", "MCQ" });
            CName.Location = new Point(415, 187);
            CName.Margin = new Padding(3, 2, 3, 2);
            CName.MaximumSize = new Size(219, 0);
            CName.MinimumSize = new Size(219, 0);
            CName.Name = "CName";
            CName.Size = new Size(219, 30);
            CName.TabIndex = 48;
            CName.Text = "Choose Course";
            CName.SelectedIndexChanged += CName_SelectedIndexChanged;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseNameLabel.Location = new Point(296, 187);
            CourseNameLabel.MaximumSize = new Size(0, 30);
            CourseNameLabel.MinimumSize = new Size(0, 30);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(81, 30);
            CourseNameLabel.TabIndex = 76;
            CourseNameLabel.Text = "Course";
            // 
            // AssignExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AssignExamPanel);
            Name = "AssignExam";
            Size = new Size(930, 728);
            AssignExamPanel.ResumeLayout(false);
            AssignExamPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AssignExamPanel;
        private ComboBox CName;
        private Label Title;
        private Button TakeExamBtn;
        private Label CourseNameLabel;
    }
}
