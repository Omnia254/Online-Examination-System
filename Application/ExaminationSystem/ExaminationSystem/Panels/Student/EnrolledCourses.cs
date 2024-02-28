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
    public partial class EnrolledCourses : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();
        int studentID;

        public EnrolledCourses()
        {
            InitializeComponent();

            enrolledCoursesDataGridView.Columns.Add("CourseNameColumn", "Course Name");
            Load += EnrolledCourses_Load;
        }

        public void SetStudentID(int _studentID)
        {
            studentID = _studentID;
        }

        private void EnrolledCourses_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView();

            // Call the method to get and display enrolled courses
            GetEnrolledCoursesByStudentID(studentID);
        }

        private void GetEnrolledCoursesByStudentID(int studentID)
        {
            try
            {
                // Create a DataTable to store the result set
                DataTable enrolledCourses = new DataTable();

                using (var command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "EXEC [GetEnrolledCoursesByStudentID] @StudentID";
                    command.Parameters.Add(new SqlParameter("@StudentID", studentID));

                    context.Database.OpenConnection();

                    using (var reader = command.ExecuteReader())
                    {
                        enrolledCourses.Load(reader);
                    }
                }

                // Clear the existing rows in the DataGridView
                enrolledCoursesDataGridView.Rows.Clear();

                // Add rows to DataGridView from the DataTable
                foreach (DataRow row in enrolledCourses.Rows)
                {
                    enrolledCoursesDataGridView.Rows.Add(row["CourseName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CustomizeDataGridView()
        {
            // Customize the appearance of the DataGridView
            enrolledCoursesDataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            enrolledCoursesDataGridView.DefaultCellStyle.ForeColor = Color.Black;

            enrolledCoursesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            enrolledCoursesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            enrolledCoursesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            enrolledCoursesDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            enrolledCoursesDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            enrolledCoursesDataGridView.BackgroundColor = Color.White;
            enrolledCoursesDataGridView.BorderStyle = BorderStyle.Fixed3D;

            enrolledCoursesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            enrolledCoursesDataGridView.AllowUserToAddRows = false;

            enrolledCoursesDataGridView.GridColor = Color.DarkGray;
            enrolledCoursesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            enrolledCoursesDataGridView.DefaultCellStyle.SelectionBackColor = Color.Gray;
            enrolledCoursesDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

            enrolledCoursesDataGridView.EnableHeadersVisualStyles = false;
        }
    }
}
