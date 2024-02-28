using ExaminationSystem.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Panels.Student
{
    public partial class Grades : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();
        int studentID;
        List<StudentGradeResult> studentGrades = new();

        public Grades()
        {
            InitializeComponent();
            
            Load += Grades_Load;
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            context.Grades.Load();
            context.Students.Load();
            context.Exams.Load();
            context.Courses.Load();

            HideFields();
        }

        public void HideFields()
        {
            gradesView.Visible = false;
        }
        public void ShowFields()
        {
            gradesView.Visible = true;
            gradesView.DataSource = studentGrades;

        }

        public void SetStudentID(int _studentID)
        {
            studentID = _studentID;
        }

        private void showGradesBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var result = context?.Set<StudentGradeResult>()?
               .FromSqlRaw("EXECUTE GetStudentGrades @StudentID", new SqlParameter("@StudentID", studentID))?
               .ToList();
                if (result == null)
                {
                    MessageBox.Show("You have not taken any exam yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var S_Grades = context.Set<StudentGradeResult>().FromSqlRaw($"EXECUTE GetStudentGrades @StudentID = {studentID}")
                                                 .ToList();
                
                studentGrades.Clear();

                foreach (var g in S_Grades)
                {
                    studentGrades.Add(g);
                }

                ShowFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
