using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Reports
{
    public partial class TakeFromUserCourseId : Form
    {
        public TakeFromUserCourseId()
        {
            InitializeComponent();
        }

        private void getReportBtn_Click(object sender, EventArgs e)
        {
            int courseid = int.Parse(CourseIdTxt.Text);
            GetTopicByCourseIDReport newReport = new GetTopicByCourseIDReport();
            newReport.ShowDialog();
        }
    }
}
