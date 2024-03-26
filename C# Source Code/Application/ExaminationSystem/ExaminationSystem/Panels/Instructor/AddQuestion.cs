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
	public partial class AddQuestion : UserControl
	{
		ExaminationSystemContext context = new ExaminationSystemContext();

		public AddQuestion()
		{
			InitializeComponent();

			Load += AddQuestion_Load;
			QuestionType.SelectedIndexChanged += QuestionType_SelectedIndexChanged;
		}

		private void AddQuestion_Load(object sender, EventArgs e)
		{
			context.Courses.Load();

			Course.DataSource = context.Courses.Local.ToBindingList();
			Course.DisplayMember = "CourseName";
			Course.ValueMember = "CourseId";
		}

		private void QuestionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (QuestionType.SelectedItem.ToString() == "T/F")
			{
				radioButton1.Checked = true;

				ChoiceText1.Text = "True";
				ChoiceText2.Text = "False";
				ChoiceText3.Text = string.Empty;
				ChoiceText4.Text = string.Empty;
				ChoiceText5.Text = string.Empty;

				ChoiceText1.Enabled = false;
				ChoiceText2.Enabled = false;
				ChoiceText3.Enabled = false;
				ChoiceText4.Enabled = false;
				ChoiceText5.Enabled = false;

				radioButton3.Enabled = false;
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
			}
			else
			{
				ChoiceText1.Text = string.Empty;
				ChoiceText2.Text = string.Empty;

				ChoiceText1.Enabled = true;
				ChoiceText2.Enabled = true;
				ChoiceText3.Enabled = true;
				ChoiceText4.Enabled = true;
				ChoiceText5.Enabled = true;

				radioButton3.Enabled = true;
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
			}
		}

		private void AddQuestionBtn_Click(object sender, EventArgs e)
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
				int countNullChoices = 0;

				if (string.IsNullOrEmpty(ChoiceText1.Text))
				{
					countNullChoices++;

					if (radioButton1.Checked)
					{
						MessageBox.Show("INVALID ISCORRECT CHOICE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				if (string.IsNullOrEmpty(ChoiceText2.Text))
				{
					countNullChoices++;

					if (radioButton2.Checked)
					{
						MessageBox.Show("INVALID ISCORRECT CHOICE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				if (string.IsNullOrEmpty(ChoiceText3.Text))
				{
					countNullChoices++;

					if (radioButton3.Checked)
					{
						MessageBox.Show("INVALID ISCORRECT CHOICE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				if (string.IsNullOrEmpty(ChoiceText4.Text))
				{
					countNullChoices++;

					if (radioButton4.Checked)
					{
						MessageBox.Show("INVALID ISCORRECT CHOICE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				if (string.IsNullOrEmpty(ChoiceText5.Text))
				{
					countNullChoices++;

					if (radioButton5.Checked)
					{
						MessageBox.Show("INVALID ISCORRECT CHOICE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}

				if (countNullChoices > 3)
				{
					MessageBox.Show("MINIMUN NUMBER OF CHOICES IS 2!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			try
			{
				var questionTextParameter = new SqlParameter("@COL2DATA", QuestionText.Text);
				var questionTypeParameter = new SqlParameter("@COL3DATA", QuestionType.SelectedItem.ToString());
				var complexityParameter = new SqlParameter("@COL4DATA", Complexity.SelectedItem.ToString());
				var courseIdParameter = new SqlParameter("@COL5DATA", Course.SelectedValue);

				context.Database.ExecuteSqlRaw("EXECUTE QUESTIONInsert @COL2DATA, @COL3DATA, @COL4DATA, @COL5DATA",
					questionTextParameter, questionTypeParameter, complexityParameter, courseIdParameter);

				var lastQuestion = context.Questions.OrderByDescending(Q => Q.QuestionId).FirstOrDefault().QuestionId;

				var questionIdParameter = new SqlParameter("@COL4DATA", lastQuestion);

				if (!string.IsNullOrEmpty(ChoiceText1.Text))
				{
					var choice1TextParameter = new SqlParameter("@COL2DATA", ChoiceText1.Text);
					var isCorrect1Parameter = new SqlParameter("@COL3DATA", radioButton1.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE CHOICEInsert @COL2DATA, @COL3DATA, @COL4DATA",
						choice1TextParameter, isCorrect1Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText2.Text))
				{
					var choice2TextParameter = new SqlParameter("@COL2DATA", ChoiceText2.Text);
					var isCorrect2Parameter = new SqlParameter("@COL3DATA", radioButton2.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE CHOICEInsert @COL2DATA, @COL3DATA, @COL4DATA",
						choice2TextParameter, isCorrect2Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText3.Text))
				{
					var choice3TextParameter = new SqlParameter("@COL2DATA", ChoiceText3.Text);
					var isCorrect3Parameter = new SqlParameter("@COL3DATA", radioButton3.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE CHOICEInsert @COL2DATA, @COL3DATA, @COL4DATA",
						choice3TextParameter, isCorrect3Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText4.Text))
				{
					var choice4TextParameter = new SqlParameter("@COL2DATA", ChoiceText4.Text);
					var isCorrect4Parameter = new SqlParameter("@COL3DATA", radioButton4.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE CHOICEInsert @COL2DATA, @COL3DATA, @COL4DATA",
						choice4TextParameter, isCorrect4Parameter, questionIdParameter);
				}
				if (!string.IsNullOrEmpty(ChoiceText5.Text))
				{
					var choice5TextParameter = new SqlParameter("@COL2DATA", ChoiceText5.Text);
					var isCorrect5Parameter = new SqlParameter("@COL3DATA", radioButton5.Checked);

					context.Database.ExecuteSqlRaw("EXECUTE CHOICEInsert @COL2DATA, @COL3DATA, @COL4DATA",
						choice5TextParameter, isCorrect5Parameter, questionIdParameter);
				}

				MessageBox.Show("Question added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				ClearFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while adding the question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ClearFields()
		{
			QuestionText.Text = string.Empty;
			QuestionType.SelectedIndex = 0;
			Complexity.SelectedIndex = 0;
			Course.SelectedIndex = 0;
			ChoiceText1.Text = string.Empty;
			ChoiceText2.Text = string.Empty;
			ChoiceText3.Text = string.Empty;
			ChoiceText4.Text = string.Empty;
			ChoiceText5.Text = string.Empty;
			radioButton1.Checked = true;
		}
	}
}
