using ExaminationSystem.Context;
using System;
using System.Collections.Generic;


namespace ExaminationSystem
{
    public partial class TakeExam : Form
    {
        ExaminationSystemContext context;
        ExaminationSystemContextProcedures procedures;
        Panel containerPanel = new Panel
        {
            AutoScroll = true,
            Dock = DockStyle.Fill // Dock to fill the entire form
        };
        int[] QuestuinsIdArray = new int[10];
        int[] AnswersIdArray = new int[10];
        int Counter = 0;
        int StudentId = 1;
        int ExamId = 3;
        int CourseId = 1;
        public TakeExam()
        {
            InitializeComponent();
            context = new ExaminationSystemContext();
            procedures = new ExaminationSystemContextProcedures(context);
            this.FormClosed += (sender, e) => context.Dispose();

        }

        private async void TakeExam_Load(object sender, EventArgs e)
        {
            try
            {
                var questionsList = await procedures.GetExamQuestionsTextByIdAsync(ExamId);


                // Add the Panel to the form
                Controls.Add(containerPanel);

                Label[] labels = new Label[questionsList.Count];

                for (int i = 0; i < questionsList.Count; i++)
                {
                    labels[i] = new Label
                    {
                        Text = $"{i + 1}. {questionsList[i].QuestionText}",
                        Location = new Point(20, 30 + i * 120),
                        AutoSize = true
                    };
                    containerPanel.Controls.Add(labels[i]);

                    var choicesList = await procedures.GetChoicesByQuestionIdAsync(questionsList[i].QuestionID);

                    GroupBox groupBox = new GroupBox
                    {
                        Text = $"Question {i + 1}",
                        Location = new Point(20, 30 + i * 120 + 20),
                        Size = new Size(400, 100),
                        Tag = questionsList[i].QuestionID
                    };

                    for (int j = 0; j < choicesList.Count; j++)
                    {

                        RadioButton radioButton = new RadioButton
                        {
                            Text = $"{choicesList[j].ChoiceText}",
                            AutoSize = true,
                            Location = new Point(20, 20 + j * 25),
                            Tag = choicesList[j].ChoiceID // Use the Tag property to identify the question
                        };


                        radioButton.CheckedChanged += RadioButton_CheckedChanged;

                        groupBox.Controls.Add(radioButton);

                    }
                    int totalHeight = 40 + questionsList.Count * 120;
                    Button submitButton = new Button
                    {
                        Text = "Submit Exam",
                        Location = new Point(containerPanel.Width - 150, totalHeight + 20),
                        Size = new Size(100, 30),

                    };
                    containerPanel.Controls.Add(groupBox);


                    containerPanel.Controls.Add(submitButton);
                    submitButton.Click += SubmitButton_Click;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            int result = await procedures.ExamAnswersAsync(
                            ExamId,
                           StudentId,
                           QuestuinsIdArray[0], AnswersIdArray[0],
                           QuestuinsIdArray[1], AnswersIdArray[1],
                           QuestuinsIdArray[2], AnswersIdArray[2],
                           QuestuinsIdArray[3], AnswersIdArray[3],
                           QuestuinsIdArray[4], AnswersIdArray[4],
                           QuestuinsIdArray[5], AnswersIdArray[5],
                           QuestuinsIdArray[6], AnswersIdArray[6],
                           QuestuinsIdArray[7], AnswersIdArray[7],
                           QuestuinsIdArray[8], AnswersIdArray[8],
                           QuestuinsIdArray[9], AnswersIdArray[9]);
            //Call Correction Exam 
            OutputParameter<int?> totalScoreOutputParameter = new OutputParameter<int?>();
            await procedures.ExamCorrectionAsync(ExamId, StudentId, CourseId, totalScoreOutputParameter);
            int? totalScore = totalScoreOutputParameter.Value;
            DialogResult dialogResult = MessageBox.Show($"Exam Submitted! Result: {result}. Do you want to view your grade?", "Submission Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Open the GradesForm
                GradesForm gradesForm = new GradesForm(totalScore ?? 0);
                gradesForm.ShowDialog();
            }
            else
            {
                // Close the current form or continue with any other logic
                this.Close();
            }
            //GradesForm gradesForm = new GradesForm(totalScore ?? 0);
            //gradesForm.Show();
            // MessageBox.Show($"Exam Submitted!{result} Total Score: {totalScore}");
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            int choiceIndex = (int)radioButton.Tag;
            int questionIndex = (int)radioButton.Parent.Tag;
            string choiceText = radioButton.Text;
            AnswersIdArray[Counter] = choiceIndex;
            QuestuinsIdArray[Counter] = questionIndex;
            Counter++;

        }
    }
}
