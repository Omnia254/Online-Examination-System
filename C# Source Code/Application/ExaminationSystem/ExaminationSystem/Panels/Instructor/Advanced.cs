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
        public AddCourse addCourse1;
        public AddTopic addTopic1;
        public EnrollStudent enrollStudent1;

        public Advanced()
        {
            InitializeComponent();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            HideFields();
            addCourse1 = new(this);
            AdvancedPanel.Controls.Add(addCourse1);
        }

        private void AddTopicBtn_Click(object sender, EventArgs e)
        {
            HideFields();
            addTopic1 = new(this);
            AdvancedPanel.Controls.Add(addTopic1);
        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {
            HideFields();
            enrollStudent1 = new(this);
            AdvancedPanel.Controls.Add(enrollStudent1);
        }

        public void HideFields()
        {
            AddCourseBtn.Visible = false;
            AddTopicBtn.Visible = false;
            EnrollStudentBtn.Visible = false;
            Title.Visible = false;
        }

        public void ShowFields()
        {
            AddCourseBtn.Visible = true;
            AddTopicBtn.Visible = true;
            EnrollStudentBtn.Visible = true;
            Title.Visible = true;

            if (addCourse1 != null)
            {
                AdvancedPanel.Controls.Remove(addCourse1);
            }

            if (addTopic1 != null)
            {
                AdvancedPanel.Controls.Remove(addTopic1);
            }

            if (enrollStudent1 != null)
            {
                AdvancedPanel.Controls.Remove(enrollStudent1);
            }
        }
    }
}
