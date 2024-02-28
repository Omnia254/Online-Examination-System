namespace ExaminationSystem.Panels.Instructor
{
    partial class EnrollStudent
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
            EnrollStudentPanel = new Panel();
            CourseName = new Label();
            StudentLabel = new Label();
            Title = new Label();
            EnrollStudentBtn = new Button();
            StudentComboBox = new ComboBox();
            CName = new ComboBox();
            EnrollStudentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EnrollStudentPanel
            // 
            EnrollStudentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnrollStudentPanel.Controls.Add(CourseName);
            EnrollStudentPanel.Controls.Add(StudentLabel);
            EnrollStudentPanel.Controls.Add(Title);
            EnrollStudentPanel.Controls.Add(EnrollStudentBtn);
            EnrollStudentPanel.Controls.Add(StudentComboBox);
            EnrollStudentPanel.Controls.Add(CName);
            EnrollStudentPanel.Location = new Point(0, 0);
            EnrollStudentPanel.Name = "EnrollStudentPanel";
            EnrollStudentPanel.Size = new Size(930, 728);
            EnrollStudentPanel.TabIndex = 0;
            // 
            // CourseName
            // 
            CourseName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CourseName.AutoSize = true;
            CourseName.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseName.Location = new Point(281, 226);
            CourseName.MaximumSize = new Size(0, 30);
            CourseName.MinimumSize = new Size(0, 30);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(81, 30);
            CourseName.TabIndex = 56;
            CourseName.Text = "Course";
            // 
            // StudentLabel
            // 
            StudentLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentLabel.Location = new Point(281, 154);
            StudentLabel.MaximumSize = new Size(0, 30);
            StudentLabel.MinimumSize = new Size(0, 30);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(116, 30);
            StudentLabel.TabIndex = 55;
            StudentLabel.Text = "Student ID";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(312, 30);
            Title.MaximumSize = new Size(0, 38);
            Title.MinimumSize = new Size(0, 38);
            Title.Name = "Title";
            Title.Size = new Size(307, 38);
            Title.TabIndex = 54;
            Title.Text = "ENROLL STUDENT";
            // 
            // EnrollStudentBtn
            // 
            EnrollStudentBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EnrollStudentBtn.BackColor = Color.FromArgb(174, 37, 43);
            EnrollStudentBtn.FlatStyle = FlatStyle.Flat;
            EnrollStudentBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollStudentBtn.ForeColor = Color.White;
            EnrollStudentBtn.Location = new Point(492, 299);
            EnrollStudentBtn.Margin = new Padding(3, 2, 3, 2);
            EnrollStudentBtn.Name = "EnrollStudentBtn";
            EnrollStudentBtn.Size = new Size(157, 49);
            EnrollStudentBtn.TabIndex = 53;
            EnrollStudentBtn.Text = "Enroll Student";
            EnrollStudentBtn.UseVisualStyleBackColor = false;
            EnrollStudentBtn.Click += EnrollStudentBtn_Click;
            // 
            // StudentComboBox
            // 
            StudentComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentComboBox.FlatStyle = FlatStyle.Flat;
            StudentComboBox.Font = new Font("Candara", 10.8F);
            StudentComboBox.FormattingEnabled = true;
            StudentComboBox.Items.AddRange(new object[] { "T/F", "MCQ" });
            StudentComboBox.Location = new Point(430, 154);
            StudentComboBox.Margin = new Padding(3, 2, 3, 2);
            StudentComboBox.MaximumSize = new Size(219, 0);
            StudentComboBox.MinimumSize = new Size(219, 0);
            StudentComboBox.Name = "StudentComboBox";
            StudentComboBox.Size = new Size(219, 30);
            StudentComboBox.TabIndex = 52;
            StudentComboBox.Text = "Choose Student ID";
            // 
            // CName
            // 
            CName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CName.FlatStyle = FlatStyle.Flat;
            CName.Font = new Font("Candara", 10.8F);
            CName.FormattingEnabled = true;
            CName.Items.AddRange(new object[] { "T/F", "MCQ" });
            CName.Location = new Point(430, 226);
            CName.Margin = new Padding(3, 2, 3, 2);
            CName.MaximumSize = new Size(219, 0);
            CName.MinimumSize = new Size(219, 0);
            CName.Name = "CName";
            CName.Size = new Size(219, 30);
            CName.TabIndex = 49;
            CName.Text = "Choose Course";
            CName.SelectedIndexChanged += CName_SelectedIndexChanged;
            // 
            // EnrollStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnrollStudentPanel);
            Name = "EnrollStudent";
            Size = new Size(930, 728);
            EnrollStudentPanel.ResumeLayout(false);
            EnrollStudentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel EnrollStudentPanel;
        private ComboBox CName;
        private ComboBox StudentComboBox;
        private Button EnrollStudentBtn;
        private Label Title;
        private Label StudentLabel;
        private Label CourseName;
    }
}
