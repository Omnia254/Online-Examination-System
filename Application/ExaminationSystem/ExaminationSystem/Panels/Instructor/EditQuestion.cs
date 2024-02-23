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

namespace ExaminationSystem.Panels.Instructor
{
	public partial class EditQuestion : UserControl
	{
		ExaminationSystemContext context = new ExaminationSystemContext();
		Question question;
		List<Choice> choices;

		public EditQuestion()
		{
			InitializeComponent();

			Load += EditQuestion_Load;
		}

		private void EditQuestion_Load(object sender, EventArgs e)
		{
			context.Courses.Load();

			HideFields();
		}

		public void HideFields()
		{
			QuestionTextLabel.Visible = false;
			QuestionTypeLabel.Visible = false;
			ComplexityLabel.Visible = false;
			CourseName.Visible = false;
			Option1Label.Visible = false;
			Option2Label.Visible = false;
			Option3Label.Visible = false;
			Option4Label.Visible = false;
			Option5Label.Visible = false;

			QuestionText.Visible = false;
			QuestionType.Visible = false;
			Complexity.Visible = false;
			Course.Visible = false;

			ChoiceText1.Visible = false;
			ChoiceText2.Visible = false;
			ChoiceText3.Visible = false;
			ChoiceText4.Visible = false;
			ChoiceText5.Visible = false;

			radioButton1.Visible = false;
			radioButton2.Visible = false;
			radioButton3.Visible = false;
			radioButton4.Visible = false;
			radioButton5.Visible = false;

			DeleteQuestionBtn.Visible = false;
			EditQuestionBtn.Visible = false;
		}

		public void ShowFields()
		{
			QuestionTextLabel.Visible = true;
			QuestionTypeLabel.Visible = true;
			ComplexityLabel.Visible = true;
			CourseName.Visible = true;
			Option1Label.Visible = true;
			Option2Label.Visible = true;
			Option3Label.Visible = true;
			Option4Label.Visible = true;
			Option5Label.Visible = true;

			QuestionText.Visible = true;
			QuestionType.Visible = true;
			Complexity.Visible = true;
			Course.Visible = true;

			ChoiceText1.Visible = true;
			ChoiceText2.Visible = true;
			ChoiceText3.Visible = true;
			ChoiceText4.Visible = true;
			ChoiceText5.Visible = true;

			radioButton1.Visible = true;
			radioButton2.Visible = true;
			radioButton3.Visible = true;
			radioButton4.Visible = true;
			radioButton5.Visible = true;

			DeleteQuestionBtn.Visible = true;
			EditQuestionBtn.Visible = true;

			choices = context.Choices.FromSql($"SelectALLChoice").ToList()
				.Where(C => C.QuestionId == question.QuestionId)
				.ToList();

			Course.DataSource = context.Courses.Local.ToBindingList();
			Course.DisplayMember = "CourseName";
			Course.ValueMember = "CourseId";

			int questionTypeIndex = QuestionType.FindStringExact(question.QuestionType);
			int complexityIndex = Complexity.FindStringExact(question.Complexity);

			ChoiceText1.Enabled = true;
			ChoiceText2.Enabled = true;
			ChoiceText3.Enabled = true;
			ChoiceText4.Enabled = true;
			ChoiceText5.Enabled = true;

			radioButton1.Enabled = true;
			radioButton2.Enabled = true;
			radioButton3.Enabled = true;
			radioButton4.Enabled = true;
			radioButton5.Enabled = true;

			if (question.QuestionType == "T/F")
			{
				ChoiceText1.Enabled = false;
				ChoiceText2.Enabled = false;
				ChoiceText3.Enabled = false;
				ChoiceText4.Enabled = false;
				ChoiceText5.Enabled = false;

				radioButton3.Enabled = false;
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
			}

			ChoiceText1.Text = choices[0].ChoiceText;
			ChoiceText2.Text = choices[1].ChoiceText;

			if (choices[0].IsCorrect)
				radioButton1.Checked = true;
			else if (choices[1].IsCorrect)
				radioButton2.Checked = true;

			if (choices.Count() == 5)
			{
				ChoiceText3.Text = choices[2].ChoiceText;
				ChoiceText4.Text = choices[3].ChoiceText;
				ChoiceText5.Text = choices[4].ChoiceText;

				if (choices[2].IsCorrect)
					radioButton3.Checked = true;
				else if (choices[3].IsCorrect)
					radioButton4.Checked = true;
				else if (choices[4].IsCorrect)
					radioButton5.Checked = true;
			}
			else if (choices.Count() == 4)
			{
				ChoiceText3.Text = choices[2].ChoiceText;
				ChoiceText4.Text = choices[3].ChoiceText;

				if (choices[2].IsCorrect)
					radioButton3.Checked = true;
				else if (choices[3].IsCorrect)
					radioButton4.Checked = true;

				ChoiceText5.Enabled = false;
				radioButton5.Enabled = false;
			}
			else if (choices.Count() == 3)
			{
				ChoiceText3.Text = choices[2].ChoiceText;

				if (choices[2].IsCorrect)
					radioButton3.Checked = true;

				ChoiceText4.Enabled = false;
				ChoiceText5.Enabled = false;

				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
			}
			else
			{
				ChoiceText3.Enabled = false;
				ChoiceText4.Enabled = false;
				ChoiceText5.Enabled = false;

				radioButton3.Enabled = false;
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
			}

			QuestionText.Text = question.QuestionText;
			QuestionType.SelectedIndex = questionTypeIndex;
			Complexity.SelectedIndex = complexityIndex;
			Course.SelectedValue = question.CourseId;

			QuestionType.Enabled = false;
		}

		private void SearchID_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(QuestionID.Text))
			{
				MessageBox.Show("PLEASE ENTER A QUESTION ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!int.TryParse(QuestionID.Text, out int questionId))
			{
				MessageBox.Show("INVALID QUESTION ID. PLEASE ENTER A VALID INTEGER.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				var result = context.Questions.FromSqlRaw("EXECUTE SelectQuestion @QuestionID",
					new SqlParameter("@QuestionID", questionId)).ToList().FirstOrDefault();

				if (result == null)
				{
					MessageBox.Show("Question with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var questions = context.Questions.FromSqlRaw($"EXECUTE SelectQuestion @QuestionID = {questionId}")
												 .ToList();

				foreach (var q in questions)
				{
					question = q;
				}

				ShowFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EditQuestionBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(QuestionText.Text))
			{
				MessageBox.Show("Please enter a question text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (QuestionType.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a question type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Complexity.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a complexity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Course.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (QuestionType.SelectedItem.ToString() == "MCQ")
			{
				if (string.IsNullOrEmpty(ChoiceText1.Text))
				{
					MessageBox.Show("CHOICE 1 IS NULL!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (string.IsNullOrEmpty(ChoiceText2.Text))
				{
					MessageBox.Show("CHOICE 2 IS NULL!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (string.IsNullOrEmpty(ChoiceText3.Text) && ChoiceText3.Enabled == true)
				{
					MessageBox.Show("CHOICE 3 IS NULL!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (string.IsNullOrEmpty(ChoiceText4.Text) && ChoiceText4.Enabled == true)
				{
					MessageBox.Show("CHOICE 4 IS NULL!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (string.IsNullOrEmpty(ChoiceText5.Text) && ChoiceText5.Enabled == true)
				{
					MessageBox.Show("CHOICE 5 IS NULL!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			try
			{
				int questionID = question.QuestionId;

				var questionIdParameter = new SqlParameter("@QuestionID", questionID);
				var questionTextParameter = new SqlParameter("@QuestionText", QuestionText.Text);
				var questionTypeParameter = new SqlParameter("@QuestionType", QuestionType.SelectedItem.ToString());
				var complexityParameter = new SqlParameter("@Complexity", Complexity.SelectedItem.ToString());
				var courseIdParameter = new SqlParameter("@CourseID", Course.SelectedValue);

				context.Database.ExecuteSqlRaw("EXECUTE UPDATEQUESTION @QuestionID, @QuestionText, @QuestionType, @Complexity, @CourseID",
					questionIdParameter, questionTextParameter, questionTypeParameter, complexityParameter, courseIdParameter);

				if (!string.IsNullOrEmpty(ChoiceText1.Text))
				{
					var choice1IdParameter = new SqlParameter("@ChoiceID", choices[0].ChoiceId);
					var choice1TextParameter = new SqlParameter("@ChoiceText", ChoiceText1.Text);
					var isCorrect1Parameter = new SqlParameter("@IsCorrect", radioButton1.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE UPDATECHOICE @ChoiceID, @ChoiceText, @IsCorrect, @QuestionID",
						choice1IdParameter, choice1TextParameter, isCorrect1Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText2.Text))
				{
					var choice2IdParameter = new SqlParameter("@ChoiceID", choices[1].ChoiceId);
					var choice2TextParameter = new SqlParameter("@ChoiceText", ChoiceText2.Text);
					var isCorrect2Parameter = new SqlParameter("@IsCorrect", radioButton2.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE UPDATECHOICE @ChoiceID, @ChoiceText, @IsCorrect, @QuestionID",
						choice2IdParameter, choice2TextParameter, isCorrect2Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText3.Text) && choices.Count() >= 3)
				{
					var choice3IdParameter = new SqlParameter("@ChoiceID", choices[2].ChoiceId);
					var choice3TextParameter = new SqlParameter("@ChoiceText", ChoiceText3.Text);
					var isCorrect3Parameter = new SqlParameter("@IsCorrect", radioButton3.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE UPDATECHOICE @ChoiceID, @ChoiceText, @IsCorrect, @QuestionID",
						choice3IdParameter, choice3TextParameter, isCorrect3Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText4.Text) && choices.Count() >= 4)
				{
					var choice4IdParameter = new SqlParameter("@ChoiceID", choices[3].ChoiceId);
					var choice4TextParameter = new SqlParameter("@ChoiceText", ChoiceText4.Text);
					var isCorrect4Parameter = new SqlParameter("@IsCorrect", radioButton4.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE UPDATECHOICE @ChoiceID, @ChoiceText, @IsCorrect, @QuestionID",
						choice4IdParameter, choice4TextParameter, isCorrect4Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText5.Text) && choices.Count() == 5)
				{
					var choice5IdParameter = new SqlParameter("@ChoiceID", choices[4].ChoiceId);
					var choice5TextParameter = new SqlParameter("@ChoiceText", ChoiceText5.Text);
					var isCorrect5Parameter = new SqlParameter("@IsCorrect", radioButton5.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE UPDATECHOICE @ChoiceID, @ChoiceText, @IsCorrect, @QuestionID",
						choice5IdParameter, choice5TextParameter, isCorrect5Parameter, questionIdParameter);
				}

				MessageBox.Show("Question Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				HideFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while Updating the question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteQuestionBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(QuestionID.Text))
			{
				MessageBox.Show("PLEASE ENTER A QUESTION ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!int.TryParse(QuestionID.Text, out int questionId))
			{
				MessageBox.Show("INVALID QUESTION ID. PLEASE ENTER A VALID INTEGER.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				var result = context.Questions.FromSqlRaw("EXECUTE SelectQuestion @QuestionID",
					new SqlParameter("@QuestionID", questionId)).ToList().FirstOrDefault();

				if (result == null)
				{
					MessageBox.Show("Question with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var choices = context.Choices.FromSql($"SelectALLChoice").ToList()
											 .Where(C => C.QuestionId == questionId)
											 .ToList();

				foreach (var choice in choices)
				{
					context.Database.ExecuteSqlRaw("EXECUTE DeleteChoice @ChoiceID",
						new SqlParameter("@ChoiceID", choice.ChoiceId));
				}

				context.Database.ExecuteSqlRaw("EXECUTE DeleteQuestion @QuestionID",
					new SqlParameter("@QuestionID", questionId));

				MessageBox.Show("Question Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				HideFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
