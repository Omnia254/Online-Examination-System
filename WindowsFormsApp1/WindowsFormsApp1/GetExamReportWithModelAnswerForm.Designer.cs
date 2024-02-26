namespace WindowsFormsApp1
{
    partial class GetExamReportWithModelAnswerForm
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
            this.examinationSystemDataSet3 = new WindowsFormsApp1.ExaminationSystemDataSet3();
            this.getExamReportWithModelAnswerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getExamReportWithModelAnswerTableAdapter = new WindowsFormsApp1.ExaminationSystemDataSet3TableAdapters.GetExamReportWithModelAnswerTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.examNumberToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.examNumberToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.studentIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExamReportWithModelAnswerBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getExamReportWithModelAnswerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.GetExamReportWithModelAnswerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(862, 447);
            this.reportViewer1.TabIndex = 2;
            // 
            // examinationSystemDataSet3
            // 
            this.examinationSystemDataSet3.DataSetName = "ExaminationSystemDataSet3";
            this.examinationSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getExamReportWithModelAnswerBindingSource
            // 
            this.getExamReportWithModelAnswerBindingSource.DataMember = "GetExamReportWithModelAnswer";
            this.getExamReportWithModelAnswerBindingSource.DataSource = this.examinationSystemDataSet3;
            // 
            // getExamReportWithModelAnswerTableAdapter
            // 
            this.getExamReportWithModelAnswerTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examNumberToolStripLabel,
            this.examNumberToolStripTextBox,
            this.studentIDToolStripLabel,
            this.studentIDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(898, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // examNumberToolStripLabel
            // 
            this.examNumberToolStripLabel.Name = "examNumberToolStripLabel";
            this.examNumberToolStripLabel.Size = new System.Drawing.Size(83, 22);
            this.examNumberToolStripLabel.Text = "ExamNumber:";
            // 
            // examNumberToolStripTextBox
            // 
            this.examNumberToolStripTextBox.Name = "examNumberToolStripTextBox";
            this.examNumberToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // studentIDToolStripLabel
            // 
            this.studentIDToolStripLabel.Name = "studentIDToolStripLabel";
            this.studentIDToolStripLabel.Size = new System.Drawing.Size(62, 15);
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
            // GetExamReportWithModelAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 516);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GetExamReportWithModelAnswerForm";
            this.Text = "GetExamReportWithModelAnswerForm";
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExamReportWithModelAnswerBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getExamReportWithModelAnswerBindingSource;
        private ExaminationSystemDataSet3 examinationSystemDataSet3;
        private ExaminationSystemDataSet3TableAdapters.GetExamReportWithModelAnswerTableAdapter getExamReportWithModelAnswerTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel examNumberToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox examNumberToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel studentIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}