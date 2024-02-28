namespace ExaminationSystem.Panels.Instructor
{
    partial class Advanced
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
            AdvancedPanel = new Panel();
            EnrollStudentBtn = new Button();
            AddTopicBtn = new Button();
            AddCourseBtn = new Button();
            Title = new Label();
            AdvancedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdvancedPanel
            // 
            AdvancedPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdvancedPanel.Controls.Add(EnrollStudentBtn);
            AdvancedPanel.Controls.Add(AddTopicBtn);
            AdvancedPanel.Controls.Add(AddCourseBtn);
            AdvancedPanel.Controls.Add(Title);
            AdvancedPanel.Location = new Point(0, 0);
            AdvancedPanel.Name = "AdvancedPanel";
            AdvancedPanel.Size = new Size(930, 728);
            AdvancedPanel.TabIndex = 0;
            // 
            // EnrollStudentBtn
            // 
            EnrollStudentBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EnrollStudentBtn.BackColor = Color.FromArgb(174, 37, 43);
            EnrollStudentBtn.FlatStyle = FlatStyle.Flat;
            EnrollStudentBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollStudentBtn.ForeColor = Color.White;
            EnrollStudentBtn.Location = new Point(387, 426);
            EnrollStudentBtn.Name = "EnrollStudentBtn";
            EnrollStudentBtn.Size = new Size(157, 49);
            EnrollStudentBtn.TabIndex = 45;
            EnrollStudentBtn.Text = "Enroll Student";
            EnrollStudentBtn.UseVisualStyleBackColor = false;
            EnrollStudentBtn.Click += EnrollStudentBtn_Click;
            // 
            // AddTopicBtn
            // 
            AddTopicBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddTopicBtn.BackColor = Color.FromArgb(174, 37, 43);
            AddTopicBtn.FlatStyle = FlatStyle.Flat;
            AddTopicBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTopicBtn.ForeColor = Color.White;
            AddTopicBtn.Location = new Point(387, 328);
            AddTopicBtn.Name = "AddTopicBtn";
            AddTopicBtn.Size = new Size(157, 49);
            AddTopicBtn.TabIndex = 44;
            AddTopicBtn.Text = "Add Topic";
            AddTopicBtn.UseVisualStyleBackColor = false;
            AddTopicBtn.Click += AddTopicBtn_Click;
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddCourseBtn.BackColor = Color.FromArgb(174, 37, 43);
            AddCourseBtn.FlatStyle = FlatStyle.Flat;
            AddCourseBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCourseBtn.ForeColor = Color.White;
            AddCourseBtn.Location = new Point(387, 230);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Size = new Size(157, 49);
            AddCourseBtn.TabIndex = 43;
            AddCourseBtn.Text = "Add Course";
            AddCourseBtn.UseVisualStyleBackColor = false;
            AddCourseBtn.Click += AddCourseBtn_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(365, 24);
            Title.MaximumSize = new Size(0, 50);
            Title.MinimumSize = new Size(0, 50);
            Title.Name = "Title";
            Title.Size = new Size(199, 50);
            Title.TabIndex = 34;
            Title.Text = "ADVANCED";
            // 
            // Advanced
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AdvancedPanel);
            Name = "Advanced";
            Size = new Size(930, 728);
            AdvancedPanel.ResumeLayout(false);
            AdvancedPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AdvancedPanel;
        private Label Title;
        private Button EnrollStudentBtn;
        private Button AddTopicBtn;
        private Button AddCourseBtn;
    }
}
