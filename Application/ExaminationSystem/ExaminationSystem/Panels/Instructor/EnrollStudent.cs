using ExaminationSystem.Context;
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

namespace ExaminationSystem.Panels.Instructor
{
    public partial class EnrollStudent : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();
        Advanced advancedPanel = new Advanced();

        public EnrollStudent(Advanced advPanel)
        {
            InitializeComponent();

            advancedPanel = advPanel;

            Load += EnrollStudentToCourse_Load;
        }

        private void EnrollStudentToCourse_Load(object sender, EventArgs e)
        {
            context.Courses.Load();

            CName.DataSource = context.Courses.Local.ToBindingList();
            CName.DisplayMember = "CourseName";
            CName.ValueMember = "CourseId";

            context.Students.Load();

            StudentComboBox.DataSource = context.Students.Local.ToBindingList();
            StudentComboBox.DisplayMember = "StudentId";
            StudentComboBox.ValueMember = "StudentId";
        }

        private void CName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CName.SelectedValue.ToString();
        }

        private void EnrollStudentBtn_Click(object sender, EventArgs e)
        {
            // Get selected student and course IDs
            int studentID = (int)StudentComboBox.SelectedValue;
            int courseID = (int)CName.SelectedValue;

            // Declare output parameter for the status message
            SqlParameter enrollmentStatusParam = new SqlParameter("@EnrollmentStatus", SqlDbType.NVarChar, 100);
            enrollmentStatusParam.Direction = ParameterDirection.Output;

            // Call the stored procedure to enroll the student in the course
            try
            {
                context.Database.ExecuteSqlRaw("EXEC [EnrollStudentInCourse] @StudentID, @CourseID, @EnrollmentStatus OUTPUT",
                    new SqlParameter("@StudentID", studentID),
                    new SqlParameter("@CourseID", courseID),
                    enrollmentStatusParam);

                // Retrieve the output parameter value
                string enrollmentStatus = enrollmentStatusParam.Value.ToString();

                MessageBox.Show(enrollmentStatus);

                advancedPanel.ShowFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
