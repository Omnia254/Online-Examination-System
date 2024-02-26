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
    public partial class GetInstructorCoursesAndStudentsForm : Form
    {
        public GetInstructorCoursesAndStudentsForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             
                this.getInstructorCoursesAndStudentsTableAdapter.Fill(this.examinationSystemDataSet5.GetInstructorCoursesAndStudents, new System.Nullable<int>(((int)(System.Convert.ChangeType(instructorIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
