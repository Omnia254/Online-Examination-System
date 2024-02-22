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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

 

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getTopicsByCourseTableAdapter.Fill(this.examinationSystemDataSet.GetTopicsByCourse, new System.Nullable<int>(((int)(System.Convert.ChangeType(course_IDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
