namespace ExaminationSystem.Panels.Student
{
    partial class EnrolledCourses
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
            EnrolledCoursesPanel = new Panel();
            enrolledCoursesDataGridView = new DataGridView();
            Title = new Label();
            EnrolledCoursesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enrolledCoursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // EnrolledCoursesPanel
            // 
            EnrolledCoursesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnrolledCoursesPanel.Controls.Add(Title);
            EnrolledCoursesPanel.Controls.Add(enrolledCoursesDataGridView);
            EnrolledCoursesPanel.Location = new Point(0, 0);
            EnrolledCoursesPanel.Name = "EnrolledCoursesPanel";
            EnrolledCoursesPanel.Size = new Size(930, 728);
            EnrolledCoursesPanel.TabIndex = 0;
            // 
            // enrolledCoursesDataGridView
            // 
            enrolledCoursesDataGridView.AllowUserToAddRows = false;
            enrolledCoursesDataGridView.AllowUserToDeleteRows = false;
            enrolledCoursesDataGridView.AllowUserToResizeColumns = false;
            enrolledCoursesDataGridView.AllowUserToResizeRows = false;
            enrolledCoursesDataGridView.Anchor = AnchorStyles.None;
            enrolledCoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            enrolledCoursesDataGridView.Cursor = Cursors.Cross;
            enrolledCoursesDataGridView.Location = new Point(290, 163);
            enrolledCoursesDataGridView.Name = "enrolledCoursesDataGridView";
            enrolledCoursesDataGridView.RowHeadersWidth = 51;
            enrolledCoursesDataGridView.Size = new Size(351, 188);
            enrolledCoursesDataGridView.TabIndex = 0;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(290, 24);
            Title.MaximumSize = new Size(0, 50);
            Title.MinimumSize = new Size(0, 50);
            Title.Name = "Title";
            Title.Size = new Size(351, 50);
            Load += EnrolledCourses_Load;
            ((System.ComponentModel.ISupportInitialize)enrolledCoursesDataGridView).EndInit();
            Title.TabIndex = 36;
            Title.Text = "ENROLLED COURSES";
            // 
            // EnrolledCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnrolledCoursesPanel);
            Name = "EnrolledCourses";
            Size = new Size(930, 728);
            EnrolledCoursesPanel.ResumeLayout(false);
            EnrolledCoursesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel EnrolledCoursesPanel;
        private DataGridView enrolledCoursesDataGridView;
        private Label Title;
    }
}
