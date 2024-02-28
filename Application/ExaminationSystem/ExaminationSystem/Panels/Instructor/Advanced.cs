using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Panels.Instructor
{
    public partial class Advanced : UserControl
    {
        public Advanced()
        {
            InitializeComponent();

            addCourse1 = new AddCourse();          

            this.Controls.Add(addCourse1);

            addCourse1.Visible = false;
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            addCourse1.Visible = true;
            this.Visible = false;
        }

        private void AddTopicBtn_Click(object sender, EventArgs e)
        {

        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
