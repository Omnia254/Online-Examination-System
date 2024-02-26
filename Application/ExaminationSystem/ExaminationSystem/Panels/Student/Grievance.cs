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

namespace ExaminationSystem.Panels.Student
{
    public partial class Grievance : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();
        int studentID;

        public Grievance()
        {
            InitializeComponent();
        }

        public void SetStudentID(int _studentID)
        {
            studentID = _studentID;
        }
    }
}
