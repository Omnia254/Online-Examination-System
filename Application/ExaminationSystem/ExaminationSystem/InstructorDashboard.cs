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

namespace ExaminationSystem
{
	public partial class InstructorDashboard : Form
	{
		List<Button> buttons = new List<Button>();
		ExaminationSystemContext context = new ExaminationSystemContext();
		int instructorID = 9;

		public InstructorDashboard()
		{
			InitializeComponent();

			buttons.Add(AddQuestionButton);
			buttons.Add(EditQuestionButton);
			buttons.Add(GenerateExam);
			buttons.Add(button4);
			buttons.Add(LogOut);

			for (int i = 0; i < buttons.Count(); i++)
			{
				buttons[i].Click += Button_Click;
			}

			try
			{
				Instructor inst = context.Instructors.FromSqlRaw("EXECUTE SelectInstructor @InstructorID",
					new SqlParameter("@InstructorID", instructorID)).ToList().FirstOrDefault();

				if (inst != null)
				{
					InstructorNameLabel.Text = inst.FirstName + " " + inst.LastName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			addQuestion1.Visible = false;
			editQuestion1.Visible = false;
			generateExam1.Visible = false;
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

		private void AddQuestionBtn_Click(object sender, EventArgs e)
		{
			addQuestion1.Visible = true;
			editQuestion1.Visible = false;
			generateExam1.Visible = false;
		}

		private void EditQuestionButton_Click(object sender, EventArgs e)
		{
			editQuestion1.Visible = true;
			addQuestion1.Visible = false;
			generateExam1.Visible = false;
		}

		private void GenerateExam_Click(object sender, EventArgs e)
		{
			generateExam1.SetInstructorID(instructorID);

			generateExam1.Visible = true;
			addQuestion1.Visible = false;
			editQuestion1.Visible = false;
		}
	}
}
