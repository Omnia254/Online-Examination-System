namespace ExaminationSystem.Reports
{
    partial class TakeFromUserCourseId
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
            getReportBtn = new Button();
            CourseIdTxt = new TextBox();
            CourseIdLabel = new Label();
            SuspendLayout();
            // 
            // getReportBtn
            // 
            getReportBtn.Location = new Point(227, 70);
            getReportBtn.Name = "getReportBtn";
            getReportBtn.Size = new Size(99, 28);
            getReportBtn.TabIndex = 0;
            getReportBtn.Text = "Search";
            getReportBtn.UseVisualStyleBackColor = true;
            getReportBtn.Click += getReportBtn_Click;
            // 
            // CourseIdTxt
            // 
            CourseIdTxt.Location = new Point(99, 32);
            CourseIdTxt.Name = "CourseIdTxt";
            CourseIdTxt.Size = new Size(227, 23);
            CourseIdTxt.TabIndex = 1;
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Location = new Point(23, 35);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(58, 15);
            CourseIdLabel.TabIndex = 2;
            CourseIdLabel.Text = "Course ID";
            // 
            // TakeFromUserCourseId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 120);
            Controls.Add(CourseIdLabel);
            Controls.Add(CourseIdTxt);
            Controls.Add(getReportBtn);
            Name = "TakeFromUserCourseId";
            Text = "TakeFromUserCourseId";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getReportBtn;
        private TextBox CourseIdTxt;
        private Label CourseIdLabel;
    }
}