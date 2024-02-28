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
    public partial class AddTopic : UserControl
    {
        ExaminationSystemContext context = new ExaminationSystemContext();

        public AddTopic()
        {
            InitializeComponent();
        }

        private void AddTopicBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TopictextBox.Text))
            {
                MessageBox.Show("Please enter a Topic Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var TopicNameParameter = new SqlParameter("@COL2DATA", TopictextBox.Text);

                context.Database.ExecuteSqlRaw("EXECUTE InsertTopic  @COL2DATA",
                             TopicNameParameter);

                MessageBox.Show("Topic added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the Topic: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearFields()
        {
            TopictextBox.Text = string.Empty;
        }
    }
}
