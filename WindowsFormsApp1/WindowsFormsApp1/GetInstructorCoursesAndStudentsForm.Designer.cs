namespace WindowsFormsApp1
{
    partial class GetInstructorCoursesAndStudentsForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.examinationSystemDataSet5 = new WindowsFormsApp1.ExaminationSystemDataSet5();
            this.examinationSystemDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getInstructorCoursesAndStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getInstructorCoursesAndStudentsTableAdapter = new WindowsFormsApp1.ExaminationSystemDataSet5TableAdapters.GetInstructorCoursesAndStudentsTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.instructorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.instructorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInstructorCoursesAndStudentsBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getInstructorCoursesAndStudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.GetInstructorCoursesAndStudentsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 275);
            this.reportViewer1.TabIndex = 1;
            // 
            // examinationSystemDataSet5
            // 
            this.examinationSystemDataSet5.DataSetName = "ExaminationSystemDataSet5";
            this.examinationSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examinationSystemDataSet5BindingSource
            // 
            this.examinationSystemDataSet5BindingSource.DataSource = this.examinationSystemDataSet5;
            this.examinationSystemDataSet5BindingSource.Position = 0;
            // 
            // getInstructorCoursesAndStudentsBindingSource
            // 
            this.getInstructorCoursesAndStudentsBindingSource.DataMember = "GetInstructorCoursesAndStudents";
            this.getInstructorCoursesAndStudentsBindingSource.DataSource = this.examinationSystemDataSet5BindingSource;
            // 
            // getInstructorCoursesAndStudentsTableAdapter
            // 
            this.getInstructorCoursesAndStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructorIDToolStripLabel,
            this.instructorIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // instructorIDToolStripLabel
            // 
            this.instructorIDToolStripLabel.Name = "instructorIDToolStripLabel";
            this.instructorIDToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.instructorIDToolStripLabel.Text = "InstructorID:";
            // 
            // instructorIDToolStripTextBox
            // 
            this.instructorIDToolStripTextBox.Name = "instructorIDToolStripTextBox";
            this.instructorIDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // GetInstructorCoursesAndStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GetInstructorCoursesAndStudentsForm";
            this.Text = "GetInstructorCoursesAndStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInstructorCoursesAndStudentsBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getInstructorCoursesAndStudentsBindingSource;
        private System.Windows.Forms.BindingSource examinationSystemDataSet5BindingSource;
        private ExaminationSystemDataSet5 examinationSystemDataSet5;
        private ExaminationSystemDataSet5TableAdapters.GetInstructorCoursesAndStudentsTableAdapter getInstructorCoursesAndStudentsTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel instructorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox instructorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}