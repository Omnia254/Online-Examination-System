namespace WindowsFormsApp1
{
    partial class Form1
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
            this.getTopicsByCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examinationSystemDataSet = new WindowsFormsApp1.ExaminationSystemDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.examinationSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTopicsByCourseTableAdapter = new WindowsFormsApp1.ExaminationSystemDataSetTableAdapters.GetTopicsByCourseTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.course_IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.course_IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.getTopicsByCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSetBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // getTopicsByCourseBindingSource
            // 
            this.getTopicsByCourseBindingSource.DataMember = "GetTopicsByCourse";
            this.getTopicsByCourseBindingSource.DataSource = this.examinationSystemDataSet;
            // 
            // examinationSystemDataSet
            // 
            this.examinationSystemDataSet.DataSetName = "ExaminationSystemDataSet";
            this.examinationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.getTopicsByCourseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 275);
            this.reportViewer1.TabIndex = 0;
            // 
            // examinationSystemDataSetBindingSource
            // 
            this.examinationSystemDataSetBindingSource.DataSource = this.examinationSystemDataSet;
            this.examinationSystemDataSetBindingSource.Position = 0;
            // 
            // getTopicsByCourseTableAdapter
            // 
            this.getTopicsByCourseTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.course_IDToolStripLabel,
            this.course_IDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(801, 25);
            this.fillToolStrip.TabIndex = 4;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // course_IDToolStripLabel
            // 
            this.course_IDToolStripLabel.Name = "course_IDToolStripLabel";
            this.course_IDToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.course_IDToolStripLabel.Text = "Course_ID:";
            // 
            // course_IDToolStripTextBox
            // 
            this.course_IDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.course_IDToolStripTextBox.Name = "course_IDToolStripTextBox";
            this.course_IDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 370);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTopicsByCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSetBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getTopicsByCourseBindingSource;
        private ExaminationSystemDataSet examinationSystemDataSet;
        private System.Windows.Forms.BindingSource examinationSystemDataSetBindingSource;
        private ExaminationSystemDataSetTableAdapters.GetTopicsByCourseTableAdapter getTopicsByCourseTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel course_IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox course_IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;


    }

}

