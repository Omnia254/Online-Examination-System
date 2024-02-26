using ExaminationSystem.Context;
using ExaminationSystem.Models;
using ExaminationSystem.Panels.Instructor;
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
	public partial class StudentDashboard : Form
	{
		List<Button> buttons = new List<Button>();
		ExaminationSystemContext context = new ExaminationSystemContext();
		Student student = new();
		int studentID = 2;

		public StudentDashboard()
		{
			InitializeComponent();

			buttons.Add(ProfileButton);
			buttons.Add(TakeExamButton);
			buttons.Add(GradesButton);
			buttons.Add(HomeButton);
			buttons.Add(LogOut);

			for (int i = 0; i < buttons.Count(); i++)
			{
				buttons[i].Click += Button_Click;
			}

			studentHome1 = new Panels.Student.StudentHome();
			studentProfile1 = new Panels.Student.StudentProfile();
			takeExam1 = new Panels.Student.TakeExam();
			grades1 = new Panels.Student.Grades();

			MainPanel.Controls.Add(studentHome1);
			MainPanel.Controls.Add(studentProfile1);
			MainPanel.Controls.Add(takeExam1);
			MainPanel.Controls.Add(grades1);

			studentHome1.Visible = true;
			studentProfile1.Visible = false;
			takeExam1.Visible = false;
			grades1.Visible = false;

			ReloadForm();
		}

		public void ReloadForm()
		{
			try
			{
				Student stud = context.Students.FromSqlRaw("EXECUTE SelectStudent @StudentID",
					new SqlParameter("@StudentID", studentID)).ToList().FirstOrDefault();

				if (stud != null)
				{
					StudentNameLabel.Text = stud.FirstName + " " + stud.LastName;
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
			context.Students.Load();

			student = context.Students.FromSqlRaw("EXECUTE SelectStudent @StudentID",
					new SqlParameter("@StudentID", studentID)).ToList().FirstOrDefault();

			studentProfile1.FirstName.Text = student.FirstName;
			studentProfile1.LastName.Text = student.LastName;
			studentProfile1.Address.Text = student.Address;
			studentProfile1.PhoneNumber.Text = student.PhoneNum;
			studentProfile1.Email.Text = student.Email;

			studentProfile1.SetStudent(student);
			studentProfile1.DisableFields();

			studentProfile1.Visible = true;
			studentHome1.Visible = false;
			takeExam1.Visible = false;
			grades1.Visible = false;
		}

		private void TakeExamButton_Click(object sender, EventArgs e)
		{
			takeExam1.SetStudentID(studentID);

			takeExam1.Visible = true;
			studentHome1.Visible = false;
			studentProfile1.Visible = false;
			grades1.Visible = false;
		}

		private void GradesButton_Click(object sender, EventArgs e)
		{
			grades1.SetStudentID(studentID);

			grades1.Visible = true;
			studentHome1.Visible = false;
			studentProfile1.Visible = false;
			takeExam1.Visible = false;
		}

		private void HomeButton_Click(object sender, EventArgs e)
		{
			studentHome1.Visible = true;
			grades1.Visible = false;
			studentProfile1.Visible = false;
			takeExam1.Visible = false;
		}
	}
}
