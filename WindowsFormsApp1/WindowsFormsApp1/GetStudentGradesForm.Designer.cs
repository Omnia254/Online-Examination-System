namespace WindowsFormsApp1
{
    partial class GetStudentGradesForm
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
            this.examinationSystemDataSet6 = new WindowsFormsApp1.ExaminationSystemDataSet6();
            this.examinationSystemDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStudentGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStudentGradesTableAdapter = new WindowsFormsApp1.ExaminationSystemDataSet6TableAdapters.GetStudentGradesTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentGradesBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getStudentGradesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.GetStudentGradesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 275);
            this.reportViewer1.TabIndex = 1;
            // 
            // examinationSystemDataSet6
            // 
            this.examinationSystemDataSet6.DataSetName = "ExaminationSystemDataSet6";
            this.examinationSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examinationSystemDataSet6BindingSource
            // 
            this.examinationSystemDataSet6BindingSource.DataSource = this.examinationSystemDataSet6;
            this.examinationSystemDataSet6BindingSource.Position = 0;
            // 
            // getStudentGradesBindingSource
            // 
            this.getStudentGradesBindingSource.DataMember = "GetStudentGrades";
            this.getStudentGradesBindingSource.DataSource = this.examinationSystemDataSet6;
            // 
            // getStudentGradesTableAdapter
            // 
            this.getStudentGradesTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentIDToolStripLabel,
            this.studentIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // studentIDToolStripLabel
            // 
            this.studentIDToolStripLabel.Name = "studentIDToolStripLabel";
            this.studentIDToolStripLabel.Size = new System.Drawing.Size(62, 22);
            this.studentIDToolStripLabel.Text = "StudentID:";
            // 
            // studentIDToolStripTextBox
            // 
            this.studentIDToolStripTextBox.Name = "studentIDToolStripTextBox";
            this.studentIDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // GetStudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GetStudentGradesForm";
            this.Text = "GetStudentGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentGradesBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getStudentGradesBindingSource;
        private ExaminationSystemDataSet6 examinationSystemDataSet6;
        private System.Windows.Forms.BindingSource examinationSystemDataSet6BindingSource;
        private ExaminationSystemDataSet6TableAdapters.GetStudentGradesTableAdapter getStudentGradesTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel studentIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}