using ExaminationSystem.Context;
<<<<<<< HEAD
using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 79e27462d310e8e001baf81a5e76ccf20c9f653a
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
<<<<<<< HEAD
        List<Course> courses = new List<Course>();
        List<ExamAnsModel> examGrievance = new();
=======
>>>>>>> 79e27462d310e8e001baf81a5e76ccf20c9f653a

        public Grievance()
        {
            InitializeComponent();
<<<<<<< HEAD
            Load += Grievance_Load;
        }
        private void Grievance_Load(object sender, EventArgs e)
        {
            //context.Grades.Load();
            context.Students.Load();
            context.Exams.Load();
            context.Courses.Load();
            context.Questions.Load();
            context.Choices.Load();
            var result = context?.Courses?
               .FromSqlRaw("EXECUTE GetStudentCourses @StudentID", new SqlParameter("@StudentID", studentID))?
               .ToList();
            if (result == null)
            {
                MessageBox.Show("You have not taken any exam yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var corses = context.Courses.FromSqlRaw($"EXECUTE GetStudentCourses @StudentID = {studentID}")
                                             .ToList();
            foreach (var course in corses)
            {
                courses.Add(course);
                CourseComboBox.Items.Add(course.CourseName);
            }

            HideFields();
        }
        public void HideFields()
        {
            yourAnsLabel1.Visible = false;
            yourAnsLabel2.Visible = false;
            yourAnsLabel3.Visible = false;
            yourAnsLabel4.Visible = false;
            yourAnsLabel5.Visible = false;
            yourAnsLabel6.Visible = false;
            QuestionTextLabel1.Visible = false;
            QuestionTextLabel2.Visible = false;
            QuestionTextLabel3.Visible = false;
            QuestionTextLabel4.Visible = false;
            QuestionTextLabel5.Visible = false;
            QuestionTextLabel6.Visible = false;
            correctAnsLabel1.Visible = false;
            correctAnsLabel2.Visible = false;
            correctAnsLabel3.Visible = false;
            correctAnsLabel4.Visible = false;
            correctAnsLabel5.Visible = false;
            correctAnsLabel6.Visible = false;
            Question1txt.Visible = false;
            Question2txt.Visible = false;
            Question3txt.Visible = false;
            Question4txt.Visible = false;
            Question5txt.Visible = false;
            Question6txt.Visible = false;
            correctAns1.Visible = false;
            correctAns2.Visible = false;
            correctAns3.Visible = false;
            correctAns4.Visible = false;
            correctAns5.Visible = false;
            correctAns6.Visible = false;
            studentAns1.Visible = false;
            studentAns2.Visible = false;
            studentAns3.Visible = false;
            studentAns4.Visible = false;
            studentAns5.Visible = false;
            studentAns6.Visible = false;



        }
        public void ShowFields()
        {
            yourAnsLabel1.Visible = true;
            yourAnsLabel2.Visible = true;
            yourAnsLabel3.Visible = true;
            yourAnsLabel4.Visible = true;
            yourAnsLabel5.Visible = true;
            yourAnsLabel6.Visible = true;
            QuestionTextLabel1.Visible = true;
            QuestionTextLabel2.Visible = true;
            QuestionTextLabel3.Visible = true;
            QuestionTextLabel4.Visible = true;
            QuestionTextLabel5.Visible = true;
            QuestionTextLabel6.Visible = true;
            correctAnsLabel1.Visible = true;
            correctAnsLabel2.Visible = true;
            correctAnsLabel3.Visible = true;
            correctAnsLabel4.Visible = true;
            correctAnsLabel5.Visible = true;
            correctAnsLabel6.Visible = true;
            Question1txt.Visible = true;
            Question2txt.Visible = true;
            Question3txt.Visible = true;
            Question4txt.Visible = true;
            Question5txt.Visible = true;
            Question6txt.Visible = true;
            correctAns1.Visible = true;
            correctAns2.Visible = true;
            correctAns3.Visible = true;
            correctAns4.Visible = true;
            correctAns5.Visible = true;
            correctAns6.Visible = true;
            studentAns1.Visible = true;
            studentAns2.Visible = true;
            studentAns3.Visible = true;
            studentAns4.Visible = true;
            studentAns5.Visible = true;
            studentAns6.Visible = true;

            Question1txt.Text = examGrievance[0].questionText;
            correctAns1.Text = examGrievance[0].modelAnsText;
            studentAns1.Text = examGrievance[0].answerText;

            Question2txt.Text = examGrievance[1].questionText;
            correctAns2.Text = examGrievance[1].modelAnsText;
            studentAns2.Text = examGrievance[1].answerText;

            Question3txt.Text = examGrievance[2].questionText;
            correctAns3.Text = examGrievance[2].modelAnsText;
            studentAns3.Text = examGrievance[2].answerText;

            Question4txt.Text = examGrievance[3].questionText;
            correctAns4.Text = examGrievance[3].modelAnsText;
            studentAns4.Text = examGrievance[3].answerText;

            Question5txt.Text = examGrievance[4].questionText;
            correctAns5.Text = examGrievance[4].modelAnsText;
            studentAns5.Text = examGrievance[4].answerText;

            Question6txt.Text = examGrievance[5].questionText;
            correctAns6.Text = examGrievance[5].modelAnsText;
            studentAns6.Text = examGrievance[5].answerText;

        }
=======
        }

>>>>>>> 79e27462d310e8e001baf81a5e76ccf20c9f653a
        public void SetStudentID(int _studentID)
        {
            studentID = _studentID;
        }
<<<<<<< HEAD

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ShowGrievance_Click(object sender, EventArgs e)
        {
            if (CourseComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int courseId = 0;
                for (int i = 0; i < courses.Count; i++)
                {
                    if (CourseComboBox.SelectedItem.ToString() == courses[i].CourseName)
                    {
                        courseId = courses[i].CourseId;
                        break;
                    }
                }
                var result = context.Set<ExamAnsModel>()
                   .FromSqlRaw("EXECUTE GetExamIDbyStudentIDandCourseID @StudentID, @CourseID", new SqlParameter("@StudentID", studentID), new SqlParameter("@CourseID", courseId))
                   .ToList();
                if (result == null)
                {
                    MessageBox.Show("You have not taken any exam yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var examReportAnswers = context.Set<ExamAnsModel>().FromSqlRaw($"EXECUTE GetExamIDbyStudentIDandCourseID @StudentID = {studentID}, @CourseID={courseId}")
                                                 .ToList();

                foreach (var era in examReportAnswers)
                {
                    examGrievance.Add(era);
                }
                if (examGrievance.Count <10)
                {
                    MessageBox.Show("You haven't exam in this course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ShowFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
=======
>>>>>>> 79e27462d310e8e001baf81a5e76ccf20c9f653a
    }
}
