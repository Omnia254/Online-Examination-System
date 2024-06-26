﻿using ExaminationSystem.Context;
using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace ExaminationSystem
{
    public partial class InstructorDashboard : Form
    {
        List<Button> buttons = new List<Button>();
        ExaminationSystemContext context = new ExaminationSystemContext();
        Instructor instructor = new();

        public InstructorDashboard(Instructor ins)
        {
            InitializeComponent();
            instructor = ins;
            buttons.Add(HomeButton);
            buttons.Add(AddQuestionButton);
            buttons.Add(EditQuestionButton);
            buttons.Add(GenerateExamButton);
            buttons.Add(ProfileButton);
            buttons.Add(AdvancedButton);
            buttons.Add(LogOut);

            for (int i = 0; i < buttons.Count(); i++)
            {
                buttons[i].Click += Button_Click;
            }

            instructorHome1 = new Panels.Instructor.InstructorHome();
            instructorProfile1 = new Panels.Instructor.InstructorProfile();
            addQuestion1 = new Panels.Instructor.AddQuestion();
            editQuestion1 = new Panels.Instructor.EditQuestion();
            generateExam1 = new Panels.Instructor.GenerateExam();
            advanced1 = new Panels.Instructor.Advanced();

            MainPanel.Controls.Add(instructorHome1);
            MainPanel.Controls.Add(instructorProfile1);
            MainPanel.Controls.Add(addQuestion1);
            MainPanel.Controls.Add(editQuestion1);
            MainPanel.Controls.Add(generateExam1);
            MainPanel.Controls.Add(advanced1);

            instructorHome1.Visible = true;
            instructorProfile1.Visible = false;
            addQuestion1.Visible = false;
            editQuestion1.Visible = false;
            generateExam1.Visible = false;
            advanced1.Visible = false;

            ReloadForm();
        }

        public void ReloadForm()
        {
            try
            {
                instructor = context.Instructors.FromSqlRaw("EXECUTE SelectInstructor @InstructorID",
                    new SqlParameter("@InstructorID", instructor.InstructorId)).ToList().FirstOrDefault();

                if (instructor != null)
                {
                    InstructorNameLabel.Text = instructor.FirstName + " " + instructor.LastName;
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

        private void AddQuestionBtn_Click(object sender, EventArgs e)
        {
            addQuestion1.Visible = true;
            instructorHome1.Visible = false;
            instructorProfile1.Visible = false;
            editQuestion1.Visible = false;
            generateExam1.Visible = false;
            advanced1.Visible = false;
        }

        private void EditQuestionButton_Click(object sender, EventArgs e)
        {
            editQuestion1.HideFields();
            editQuestion1.QuestionID.Text = string.Empty;

            editQuestion1.Visible = true;
            instructorHome1.Visible = false;
            instructorProfile1.Visible = false;
            addQuestion1.Visible = false;
            generateExam1.Visible = false;
            advanced1.Visible = false;
        }

        private void GenerateExam_Click(object sender, EventArgs e)
        {
            generateExam1.SetInstructorID(instructor.InstructorId);

            generateExam1.Visible = true;
            instructorHome1.Visible = false;
            instructorProfile1.Visible = false;
            addQuestion1.Visible = false;
            editQuestion1.Visible = false;
            advanced1.Visible = false;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            instructorProfile1.FirstName.Text = instructor.FirstName;
            instructorProfile1.LastName.Text = instructor.LastName;
            instructorProfile1.PhoneNumber.Text = instructor.PhoneNumber;
            instructorProfile1.Email.Text = instructor.Email;

            instructorProfile1.SetInstructor(instructor);

            instructorProfile1.Visible = true;
            instructorHome1.Visible = false;
            generateExam1.Visible = false;
            addQuestion1.Visible = false;
            editQuestion1.Visible = false;
            advanced1.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            instructorHome1.Visible = true;
            instructorProfile1.Visible = false;
            generateExam1.Visible = false;
            addQuestion1.Visible = false;
            editQuestion1.Visible = false;
            advanced1.Visible = false;
        }

        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            advanced1.ShowFields();

            advanced1.Visible = true;
            instructorHome1.Visible = false;
            instructorProfile1.Visible = false;
            addQuestion1.Visible = false;
            editQuestion1.Visible = false;
            generateExam1.Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void InstructorDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
