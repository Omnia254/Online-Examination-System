using ExaminationSystem.Context;
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
	public partial class GenerateExam : UserControl
	{
		ExaminationSystemContext context = new();

		public GenerateExam()
		{
			InitializeComponent();

			Load += GenerateExam_Load;
		}

		private void GenerateExam_Load(object sender, EventArgs e)
		{
			context.Courses.Load();

			Course.DataSource = context.Courses.Local.ToBindingList();
			Course.DisplayMember = "CourseName";
			Course.ValueMember = "CourseId";
		}

		private void GenerateBtn_Click(object sender, EventArgs e)
		{
			// Calculate the sum of the values of the numeric up-down controls
			int sum = (NoOfTFQuestion.SelectedIndex + 1) + (NoOfMCQQuestions.SelectedIndex + 1);

			// Check if the sum not equal 10
			if (sum != 10)
			{
				// If the sum not equal 10, show a message box
				MessageBox.Show("The sum of the two numbers not equal 10!", "Sum Not Equal 10", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				// Assuming context is your DbContext instance
				context.Database.ExecuteSqlRaw($"EXECUTE [ExamGeneration] {Course.SelectedValue}, {NoOfTFQuestion.SelectedIndex + 1}, {NoOfMCQQuestions.SelectedIndex + 1}, {Complexity.SelectedItem}, {Convert.ToInt32(InstructorID.Text)}");

				MessageBox.Show("Exam added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while generating the Exam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
