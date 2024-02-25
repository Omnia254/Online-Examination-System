namespace WindowsFormsApp1
{
    partial class GetStudentsByDepartmentForm
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
            this.examinationSystemDataSet2 = new WindowsFormsApp1.ExaminationSystemDataSet2();
            this.getStudentsByDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getStudentsByDepartmentTableAdapter = new WindowsFormsApp1.ExaminationSystemDataSet2TableAdapters.GetStudentsByDepartmentTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.department_IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.department_IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentsByDepartmentBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.getStudentsByDepartmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.GetStudentsByDepartmentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(862, 447);
            this.reportViewer1.TabIndex = 2;
            // 
            // examinationSystemDataSet2
            // 
            this.examinationSystemDataSet2.DataSetName = "ExaminationSystemDataSet2";
            this.examinationSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getStudentsByDepartmentBindingSource
            // 
            this.getStudentsByDepartmentBindingSource.DataMember = "GetStudentsByDepartment";
            this.getStudentsByDepartmentBindingSource.DataSource = this.examinationSystemDataSet2;
            // 
            // getStudentsByDepartmentTableAdapter
            // 
            this.getStudentsByDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.department_IDToolStripLabel,
            this.department_IDToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(906, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // department_IDToolStripLabel
            // 
            this.department_IDToolStripLabel.Name = "department_IDToolStripLabel";
            this.department_IDToolStripLabel.Size = new System.Drawing.Size(89, 15);
            this.department_IDToolStripLabel.Text = "Department_ID:";
            // 
            // department_IDToolStripTextBox
            // 
            this.department_IDToolStripTextBox.Name = "department_IDToolStripTextBox";
            this.department_IDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // GetStudentsByDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 532);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GetStudentsByDepartmentForm";
            this.Text = "GetStudentsByDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.examinationSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStudentsByDepartmentBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getStudentsByDepartmentBindingSource;
        private ExaminationSystemDataSet2 examinationSystemDataSet2;
        private ExaminationSystemDataSet2TableAdapters.GetStudentsByDepartmentTableAdapter getStudentsByDepartmentTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel department_IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox department_IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}