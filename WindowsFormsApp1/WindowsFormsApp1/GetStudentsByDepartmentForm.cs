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
    public partial class GetStudentsByDepartmentForm : Form
    {
        public GetStudentsByDepartmentForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getStudentsByDepartmentTableAdapter.Fill(this.examinationSystemDataSet2.GetStudentsByDepartment, new System.Nullable<int>(((int)(System.Convert.ChangeType(department_IDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }

    }
}
