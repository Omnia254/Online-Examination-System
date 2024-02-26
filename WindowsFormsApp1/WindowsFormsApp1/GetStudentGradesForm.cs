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
    public partial class GetStudentGradesForm : Form
    {
        public GetStudentGradesForm()
        {
            InitializeComponent();
        }



        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getStudentGradesTableAdapter.Fill(this.examinationSystemDataSet6.GetStudentGrades, new System.Nullable<int>(((int)(System.Convert.ChangeType(studentIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();

        }
    }
}
