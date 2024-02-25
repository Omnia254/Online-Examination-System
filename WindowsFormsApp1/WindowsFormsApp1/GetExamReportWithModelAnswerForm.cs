using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GetExamReportWithModelAnswerForm : Form
    {
        public GetExamReportWithModelAnswerForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getExamReportWithModelAnswerTableAdapter.Fill(this.examinationSystemDataSet3.GetExamReportWithModelAnswer, new System.Nullable<int>(((int)(System.Convert.ChangeType(examNumberToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(studentIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.reportViewer1.RefreshReport();

        }
    }
}
