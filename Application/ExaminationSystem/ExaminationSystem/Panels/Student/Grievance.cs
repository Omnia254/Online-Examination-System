using ExaminationSystem.Context;

using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Panels.Student
{
    public partial class Grievance : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();
        int studentID;
        List<Course> courses = new List<Course>();
        List<ExamAnsModel> examGrievance = new();
        Exam exam = new();

        public Grievance()
        {
            InitializeComponent();

            Load += Grievance_Load;
        }

        private void Grievance_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
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
            yourAnsLabel7.Visible = false;
            yourAnsLabel8.Visible = false;
            yourAnsLabel9.Visible = false;
            yourAnsLabel10.Visible = false;
            QuestionTextLabel1.Visible = false;
            QuestionTextLabel2.Visible = false;
            QuestionTextLabel3.Visible = false;
            QuestionTextLabel4.Visible = false;
            QuestionTextLabel5.Visible = false;
            QuestionTextLabel6.Visible = false;
            QuestionTextLabel7.Visible = false;
            QuestionTextLabel8.Visible = false;
            QuestionTextLabel9.Visible = false;
            QuestionTextLabel10.Visible = false;
            correctAnsLabel1.Visible = false;
            correctAnsLabel2.Visible = false;
            correctAnsLabel3.Visible = false;
            correctAnsLabel4.Visible = false;
            correctAnsLabel5.Visible = false;
            correctAnsLabel6.Visible = false;
            correctAnsLabel7.Visible = false;
            correctAnsLabel8.Visible = false;
            correctAnsLabel9.Visible = false;
            correctAnsLabel10.Visible = false;
            Question1txt.Visible = false;
            Question2txt.Visible = false;
            Question3txt.Visible = false;
            Question4txt.Visible = false;
            Question5txt.Visible = false;
            Question6txt.Visible = false;
            Question7txt.Visible = false;
            Question8txt.Visible = false;
            Question9txt.Visible = false;
            Question10txt.Visible = false;
            correctAns1.Visible = false;
            correctAns2.Visible = false;
            correctAns3.Visible = false;
            correctAns4.Visible = false;
            correctAns5.Visible = false;
            correctAns6.Visible = false;
            correctAns7.Visible = false;
            correctAns8.Visible = false;
            correctAns9.Visible = false;
            correctAns10.Visible = false;
            studentAns1.Visible = false;
            studentAns2.Visible = false;
            studentAns3.Visible = false;
            studentAns4.Visible = false;
            studentAns5.Visible = false;
            studentAns6.Visible = false;
            studentAns7.Visible = false;
            studentAns8.Visible = false;
            studentAns9.Visible = false;
            studentAns10.Visible = false;
        }

        public void ShowFields()
        {
            yourAnsLabel1.Visible = true;
            yourAnsLabel2.Visible = true;
            yourAnsLabel3.Visible = true;
            yourAnsLabel4.Visible = true;
            yourAnsLabel5.Visible = true;
            yourAnsLabel6.Visible = true;
            yourAnsLabel7.Visible = true;
            yourAnsLabel8.Visible = true;
            yourAnsLabel9.Visible = true;
            yourAnsLabel10.Visible = true;
            QuestionTextLabel1.Visible = true;
            QuestionTextLabel2.Visible = true;
            QuestionTextLabel3.Visible = true;
            QuestionTextLabel4.Visible = true;
            QuestionTextLabel5.Visible = true;
            QuestionTextLabel6.Visible = true;
            QuestionTextLabel7.Visible = true;
            QuestionTextLabel8.Visible = true;
            QuestionTextLabel9.Visible = true;
            QuestionTextLabel10.Visible = true;
            correctAnsLabel1.Visible = true;
            correctAnsLabel2.Visible = true;
            correctAnsLabel3.Visible = true;
            correctAnsLabel4.Visible = true;
            correctAnsLabel5.Visible = true;
            correctAnsLabel6.Visible = true;
            correctAnsLabel7.Visible = true;
            correctAnsLabel8.Visible = true;
            correctAnsLabel9.Visible = true;
            correctAnsLabel10.Visible = true;
            Question1txt.Visible = true;
            Question2txt.Visible = true;
            Question3txt.Visible = true;
            Question4txt.Visible = true;
            Question5txt.Visible = true;
            Question6txt.Visible = true;
            Question7txt.Visible = true;
            Question8txt.Visible = true;
            Question9txt.Visible = true;
            Question10txt.Visible = true;
            correctAns1.Visible = true;
            correctAns2.Visible = true;
            correctAns3.Visible = true;
            correctAns4.Visible = true;
            correctAns5.Visible = true;
            correctAns6.Visible = true;
            correctAns7.Visible = true;
            correctAns8.Visible = true;
            correctAns9.Visible = true;
            correctAns10.Visible = true;
            studentAns1.Visible = true;
            studentAns2.Visible = true;
            studentAns3.Visible = true;
            studentAns4.Visible = true;
            studentAns5.Visible = true;
            studentAns6.Visible = true;
            studentAns7.Visible = true;
            studentAns8.Visible = true;
            studentAns9.Visible = true;
            studentAns10.Visible = true;

            Question1txt.Text = examGrievance[0].QuestionText;
            correctAns1.Text = examGrievance[0].ModelAnswer;
            studentAns1.Text = examGrievance[0].StudentAnswer;

            Question2txt.Text = examGrievance[1].QuestionText;
            correctAns2.Text = examGrievance[1].ModelAnswer;
            studentAns2.Text = examGrievance[1].StudentAnswer;

            Question3txt.Text = examGrievance[2].QuestionText;
            correctAns3.Text = examGrievance[2].ModelAnswer;
            studentAns3.Text = examGrievance[2].StudentAnswer;

            Question4txt.Text = examGrievance[3].QuestionText;
            correctAns4.Text = examGrievance[3].ModelAnswer;
            studentAns4.Text = examGrievance[3].StudentAnswer;

            Question5txt.Text = examGrievance[4].QuestionText;
            correctAns5.Text = examGrievance[4].ModelAnswer;
            studentAns5.Text = examGrievance[4].StudentAnswer;

            Question6txt.Text = examGrievance[5].QuestionText;
            correctAns6.Text = examGrievance[5].ModelAnswer;
            studentAns6.Text = examGrievance[5].StudentAnswer;

            Question7txt.Text = examGrievance[6].QuestionText;
            correctAns7.Text = examGrievance[6].ModelAnswer;
            studentAns7.Text = examGrievance[6].StudentAnswer;

            Question8txt.Text = examGrievance[7].QuestionText;
            correctAns8.Text = examGrievance[7].ModelAnswer;
            studentAns8.Text = examGrievance[7].StudentAnswer;

            Question9txt.Text = examGrievance[8].QuestionText;
            correctAns9.Text = examGrievance[8].ModelAnswer;
            studentAns9.Text = examGrievance[8].StudentAnswer;

            Question10txt.Text = examGrievance[9].QuestionText;
            correctAns10.Text = examGrievance[9].ModelAnswer;
            studentAns10.Text = examGrievance[9].StudentAnswer;

        }

        public void SetStudentID(int _studentID)
        {
            studentID = _studentID;
        }

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

                var result = context.Exams
                   .FromSqlRaw("EXECUTE GetExamIDbyStudentIDandCourseID @StudentID, @CourseID", new SqlParameter("@StudentID", studentID), new SqlParameter("@CourseID", courseId))
                   .ToList();

                if (result == null)
                {
                    MessageBox.Show("You have not taken any exam yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                exam = context.Exams.FromSqlRaw($"EXECUTE GetExamIDbyStudentIDandCourseID @StudentID = {studentID}, @CourseID={courseId}")
                                                 .ToList().FirstOrDefault();
               
                var result2 = context.Set<ExamAnsModel>()
                   .FromSqlRaw("EXECUTE GetExamReportWithModelAnswer @ExamNumber, @StudentID", new SqlParameter("@ExamNumber", exam.ExamId), new SqlParameter("@StudentID", studentID))
                   .ToList();

                if (result2 == null)
                {
                    MessageBox.Show("You have not taken any exam yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var examReportAnswers = context.Set<ExamAnsModel>().FromSqlRaw($"EXECUTE GetExamReportWithModelAnswer @ExamNumber = {exam.ExamId}, @StudentID={studentID}")
                                                 .ToList();
                //
                foreach (var era in examReportAnswers)
                {
                    examGrievance.Add(era);
                }
                if (examGrievance.Count < 10)
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

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
