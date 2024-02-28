using ExaminationSystem.Context;
using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class AssignExam : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();
        public TakeExam takeExam1;
        int studentID;

        public AssignExam()
        {
            InitializeComponent();

            Load += AssignExam_Load;
        }

        public void SetStudentID(int _studentID)
        {
            studentID = _studentID;
        }

        private void AssignExam_Load(object sender, EventArgs e)
        {
            var Cour = context.Courses.FromSqlRaw("EXECUTE GetEnrolledStudentCourses @StudentID",
                    new SqlParameter("@StudentID", studentID)).ToList();

            CName.DataSource = Cour;
            CName.DisplayMember = "CourseName";
            CName.ValueMember = "CourseId";
        }

        private void CName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CName.SelectedValue.ToString();
        }

        private void TakeExamBtn_Click(object sender, EventArgs e)
        {
            var Examobject = context.Exams.FromSqlRaw("EXECUTE GetDistinctExamIDs @CourseID",
                    new SqlParameter("@CourseID", CName.SelectedValue)).ToList().FirstOrDefault();
            
            if (Examobject == null)
            {
                MessageBox.Show($"NO EXAM AVAILABLE RIGHT NOW!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CName.SelectedIndex == -1)
            {
                MessageBox.Show($"An error occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                takeExam1 = new(this);

                takeExam1.ClearVariables();
                takeExam1.SetStudentID(studentID);
                takeExam1.SetCourseID(Examobject.CourseId);
                takeExam1.SetExamID(Examobject.ExamId);
                HideFields();

                AssignExamPanel.Controls.Add(takeExam1);
            }
        }

        public void HideFields()
        {
            CName.Visible = false;
            Title.Visible = false;
            TakeExamBtn.Visible = false;
            CourseNameLabel.Visible = false;
        }

        public void ShowFields()
        {
            CName.Visible = true;
            Title.Visible = true;
            TakeExamBtn.Visible = true;
            CourseNameLabel.Visible = true;
            
            if (takeExam1 != null)
            {
                AssignExamPanel.Controls.Remove(takeExam1);
            }
        }
    }
}
