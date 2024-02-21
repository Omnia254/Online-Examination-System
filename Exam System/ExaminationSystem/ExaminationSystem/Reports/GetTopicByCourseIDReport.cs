using ExaminationSystem.Context;
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
    public partial class GetTopicByCourseIDReport : Form
    {
        
        private int courseid;
        public GetTopicByCourseIDReport()
        {
            InitializeComponent();
        }
        public GetTopicByCourseIDReport(int c)
        {
            InitializeComponent();
            this.courseid = c;
        }

        private void GetTopicByCourseIDReport_Load(object sender, EventArgs e)
        {
            ExaminationSystemContext examinationSystemContext = new ExaminationSystemContext();
           // CrystalReport1 cr = new CrystalReport1();


        }
    }
}
