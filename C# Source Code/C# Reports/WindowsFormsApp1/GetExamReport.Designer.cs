namespace WindowsFormsApp1
{
    partial class GetExamReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getExamReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examinationSystemDataSet1 = new WindowsFormsApp1.ExaminationSystemDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getExamReportTableAdapter = new WindowsFormsApp1.ExaminationSystemDataSet1TableAdapters.GetExamReportTableAdapter();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.examIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.examIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.getExamReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet1)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getExamReportBindingSource
            // 
            this.getExamReportBindingSource.DataMember = "GetExamReport";
            this.getExamReportBindingSource.DataSource = this.examinationSystemDataSet1;
            // 
            // examinationSystemDataSet1
            // 
            this.examinationSystemDataSet1.DataSetName = "ExaminationSystemDataSet1";
            this.examinationSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getExamReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.GetExamReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(862, 447);
            this.reportViewer1.TabIndex = 1;
            // 
            // getExamReportTableAdapter
            // 
            this.getExamReportTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examIDToolStripLabel,
            this.examIDToolStripTextBox,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(885, 25);
            this.fillToolStrip1.TabIndex = 6;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // examIDToolStripLabel
            // 
            this.examIDToolStripLabel.Name = "examIDToolStripLabel";
            this.examIDToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.examIDToolStripLabel.Text = "ExamID:";
            // 
            // examIDToolStripTextBox
            // 
            this.examIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.examIDToolStripTextBox.Name = "examIDToolStripTextBox";
            this.examIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton1.Text = "Fill";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // GetExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 506);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GetExamReport";
            this.Text = "GetExamReport";
            this.Load += new System.EventHandler(this.GetExamReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getExamReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet1)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getExamReportBindingSource;
        private ExaminationSystemDataSet1 examinationSystemDataSet1;
        private ExaminationSystemDataSet1TableAdapters.GetExamReportTableAdapter getExamReportTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel examIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox examIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
    }
}