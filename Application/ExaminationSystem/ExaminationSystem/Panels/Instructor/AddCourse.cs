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
    public partial class AddCourse : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();

        public AddCourse()
        {
            InitializeComponent();

            Load += AddCourse_Load;
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            context.Topics.Load();

            TopicName.DataSource = context.Topics.Local.ToBindingList();
            TopicName.DisplayMember = "TopicTitle";
            TopicName.ValueMember = "TopicID";
        }

        private void TopicName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TopicName.SelectedValue.ToString();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CourseNametextBox.Text))
            {
                MessageBox.Show("Please enter a Course Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TopicName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Topic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var CourseNameParameter = new SqlParameter("@COL2DATA", CourseNametextBox.Text);
                var TopicParameter = new SqlParameter("@COL3DATA", TopicName.SelectedValue);

                context.Database.ExecuteSqlRaw("EXECUTE InsertCourse  @COL2DATA, @COL3DATA",
                     CourseNameParameter, TopicParameter);

                MessageBox.Show("Course added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the Course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearFields()
        {
            CourseNametextBox.Text = string.Empty;
            TopicName.SelectedIndex = 0;
        }
    }
}
