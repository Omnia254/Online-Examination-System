using ExaminationSystem.Context;
using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace ExaminationSystem
{
    public partial class StudentDashboard : Form
    {
        List<Button> buttons = new List<Button>();
        ExaminationSystemContext context = new ExaminationSystemContext();
        Student student = new();

        public StudentDashboard(Student std)
        {
            InitializeComponent();
            student = std;
            buttons.Add(ProfileButton);
            buttons.Add(TakeExamButton);
            buttons.Add(GradesButton);
            buttons.Add(HomeButton);
            buttons.Add(GrievanceButton);
            buttons.Add(EnrolledCoursesBtn);
            buttons.Add(LogOut);

            for (int i = 0; i < buttons.Count(); i++)
            {
                buttons[i].Click += Button_Click;
            }

            studentHome1 = new Panels.Student.StudentHome();
            studentProfile1 = new Panels.Student.StudentProfile();
            assignExam1 = new Panels.Student.AssignExam();
            grades1 = new Panels.Student.Grades();
            grievance1 = new Panels.Student.Grievance();
            enrolledCourses1 = new Panels.Student.EnrolledCourses();

            MainPanel.Controls.Add(studentHome1);
            MainPanel.Controls.Add(studentProfile1);
            MainPanel.Controls.Add(assignExam1);
            MainPanel.Controls.Add(grades1);
            MainPanel.Controls.Add(grievance1);
            MainPanel.Controls.Add(enrolledCourses1);
            MainPanel.Controls.Add(assignExam1.takeExam1);

            studentHome1.Visible = true;
            studentProfile1.Visible = false;
            assignExam1.Visible = false;
            grades1.Visible = false;
            grievance1.Visible = false;
            enrolledCourses1.Visible = false;
            //takeExam1.Visible = false;

            ReloadForm();
        }

        public void ReloadForm()
        {
            try
            {
                Student stud = context.Students.FromSqlRaw("EXECUTE SelectStudent @StudentID",
                    new SqlParameter("@StudentID", student.StudentId)).ToList().FirstOrDefault();

                if (student != null)
                {
                    StudentNameLabel.Text = student.FirstName + " " + student.LastName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            clickedButton.BackColor = Color.LightGray;

            foreach (var button in buttons)
            {
                if (button != clickedButton)
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            studentProfile1.FirstName.Text = student.FirstName;
            studentProfile1.LastName.Text = student.LastName;
            studentProfile1.Address.Text = student.Address;
            studentProfile1.PhoneNumber.Text = student.PhoneNum;
            studentProfile1.Email.Text = student.Email;

            studentProfile1.SetStudent(student);
            studentProfile1.DisableFields();

            studentProfile1.Visible = true;
            studentHome1.Visible = false;
            assignExam1.Visible = false;
            grades1.Visible = false;
            grievance1.Visible = false;
            enrolledCourses1.Visible = false;
            //takeExam1.Visible = false;
        }

        private void TakeExamButton_Click(object sender, EventArgs e)
        {
            assignExam1.SetStudentID(student.StudentId);

            assignExam1.Visible = true;
            studentHome1.Visible = false;
            studentProfile1.Visible = false;
            grades1.Visible = false;
            grievance1.Visible = false;
            enrolledCourses1.Visible = false;
            //takeExam1.Visible = false;
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            grades1.SetStudentID(student.StudentId);

            grades1.Visible = true;
            studentHome1.Visible = false;
            studentProfile1.Visible = false;
            assignExam1.Visible = false;
            grievance1.Visible = false;
            enrolledCourses1.Visible = false;
            //takeExam1.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            studentHome1.Visible = true;
            grades1.Visible = false;
            studentProfile1.Visible = false;
            assignExam1.Visible = false;
            grievance1.Visible = false;
            enrolledCourses1.Visible = false;
            //takeExam1.Visible = false;
        }

        private void GrievanceButton_Click(object sender, EventArgs e)
        {
            grievance1.SetStudentID(student.StudentId);

            grievance1.Visible = true;
            studentHome1.Visible = false;
            studentProfile1.Visible = false;
            assignExam1.Visible = false;
            grades1.Visible = false;
            enrolledCourses1.Visible = false;
            //takeExam1.Visible = false;
        }

        private void EnrolledCoursesBtn_Click(object sender, EventArgs e)
        {
            enrolledCourses1.SetStudentID(student.StudentId);

            enrolledCourses1.Visible = true;
            studentHome1.Visible = false;
            grades1.Visible = false;
            studentProfile1.Visible = false;
            assignExam1.Visible = false;
            grievance1.Visible = false;
            //takeExam1.Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void StudentDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
