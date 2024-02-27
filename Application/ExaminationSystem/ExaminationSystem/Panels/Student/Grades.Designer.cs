namespace ExaminationSystem.Panels.Student
{
    partial class Grades
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
            //
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            GradesPanel = new Panel();
            gradesView = new DataGridView();
            Course = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            showGradesBtn = new Button();
            Title = new Label();
            GradesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesView).BeginInit();
            SuspendLayout();
            // 
            // GradesPanel
            // 
            GradesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GradesPanel.Controls.Add(gradesView);
            GradesPanel.Controls.Add(showGradesBtn);
            GradesPanel.Controls.Add(Title);
            GradesPanel.Location = new Point(0, 0);
            GradesPanel.Name = "GradesPanel";
            GradesPanel.Size = new Size(930, 728);
            GradesPanel.TabIndex = 0;
            // 
            // gradesView
            // 
            gradesView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gradesView.BackgroundColor = SystemColors.Control;
            gradesView.BorderStyle = BorderStyle.None;
            gradesView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(174, 37, 43);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gradesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gradesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesView.Columns.AddRange(new DataGridViewColumn[] { Course, Grade });
            gradesView.Location = new Point(205, 235);
            gradesView.Name = "gradesView";
            gradesView.RowHeadersWidth = 51;
            gradesView.Size = new Size(514, 188);
            gradesView.TabIndex = 83;
            gradesView.CellContentClick += gradesView_CellContentClick;
            // 
            // Course
            // 
            Course.DataPropertyName = "CourseName";
            dataGridViewCellStyle2.BackColor = Color.White;
            Course.DefaultCellStyle = dataGridViewCellStyle2;
            Course.HeaderText = "Course";
            Course.MinimumWidth = 6;
            Course.Name = "Course";
            Course.Width = 250;
            // 
            // Grade
            // 
            Grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grade.DataPropertyName = "Score";
            dataGridViewCellStyle3.BackColor = Color.White;
            Grade.DefaultCellStyle = dataGridViewCellStyle3;
            Grade.HeaderText = "Grade";
            Grade.MinimumWidth = 6;
            Grade.Name = "Grade";
            // 
            // showGradesBtn
            // 
            showGradesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            showGradesBtn.BackColor = Color.FromArgb(174, 37, 43);
            showGradesBtn.FlatStyle = FlatStyle.Flat;
            showGradesBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showGradesBtn.ForeColor = Color.White;
            showGradesBtn.Location = new Point(390, 99);
            showGradesBtn.Name = "showGradesBtn";
            showGradesBtn.Size = new Size(157, 49);
            showGradesBtn.TabIndex = 82;
            showGradesBtn.Text = "Show Grades";
            showGradesBtn.UseVisualStyleBackColor = false;
            showGradesBtn.Click += showGradesBtn_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(390, 24);
            Title.MaximumSize = new Size(0, 50);
            Title.MinimumSize = new Size(0, 50);
            Title.Name = "Title";
            Title.Size = new Size(151, 50);
            Title.TabIndex = 35;
            Title.Text = "GRADES";
            // 
            // Grades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GradesPanel);
            Name = "Grades";
            Size = new Size(930, 728);
            GradesPanel.ResumeLayout(false);
            GradesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradesView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel GradesPanel;
        private Label Title;
        private Button showGradesBtn;
        private DataGridView gradesView;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Grade;
    }
}
