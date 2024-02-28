using ExaminationSystem.Context;
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
    public partial class TakeExam : UserControl
    {
        ExaminationSystemContext context;
        ExaminationSystemContextProcedures procedures;
        AssignExam assignExamPanel = new();
        int[] QuestuinsIdArray = new int[10];
        int[] AnswersIdArray = new int[10];
        int Counter = 0;
        int ExamId;
        int CourseId;
        int StudentId;

        public TakeExam(AssignExam assignExam)
        {
            InitializeComponent();

            context = new ExaminationSystemContext();
            procedures = new ExaminationSystemContextProcedures(context);
            assignExamPanel = assignExam;
            //this.FormClosed += (sender, e) => context.Dispose();
        }

        public void SetStudentID(int _studentID)
        {
            StudentId = _studentID;
        }

        public void SetCourseID(int _courseID)
        {
            CourseId = _courseID;
        }

        public void SetExamID(int _examID)
        {
            ExamId = _examID;
        }

        public void ClearVariables()
        {
            QuestuinsIdArray = new int[10];
            AnswersIdArray = new int[10];
            Counter = 0;
        }

        private async void TakeExam_Load(object sender, EventArgs e)
        {
            try
            {
                var questionsList = await procedures.GetExamQuestionsTextByIdAsync(ExamId);

                // Add the Panel to the form
                Controls.Add(containerPanel);

                Label[] labels = new Label[questionsList.Count];
                int totalHeight = 20;

                for (int i = 0; i < questionsList.Count; i++)
                {
                    labels[i] = new Label
                    {
                        Text = $"{i + 1}. {questionsList[i].QuestionText}",
                        Location = new Point(50, totalHeight),
                        AutoSize = true,
                        Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
                    };
                    containerPanel.Controls.Add(labels[i]);

                    var choicesList = await procedures.GetChoicesByQuestionIdAsync(questionsList[i].QuestionID);

                    GroupBox groupBox = new GroupBox
                    {
                        Text = $"Question {i + 1}",
                        Location = new Point(50, totalHeight + labels[i].Height + 10),
                        Size = new Size(400, 100 + choicesList.Count * 15),
                        Tag = questionsList[i].QuestionID
                    };

                    int choiceTop = 20;
                    for (int j = 0; j < choicesList.Count; j++)
                    {
                        RadioButton radioButton = new RadioButton
                        {
                            Text = $"{choicesList[j].ChoiceText}",
                            AutoSize = true,
                            Location = new Point(50, choiceTop),
                            Tag = choicesList[j].ChoiceID,
                            Font = new Font("Candara", 12F, FontStyle.Bold),
                            UseVisualStyleBackColor = true
                        };

                        radioButton.CheckedChanged += RadioButton_CheckedChanged;
                        groupBox.Controls.Add(radioButton);

                        choiceTop += radioButton.Height;
                    }

                    totalHeight += labels[i].Height + groupBox.Height + 30;

                    containerPanel.Controls.Add(groupBox);
                }

                Button submitButton = new Button
                {
                    Text = "Submit Exam",
                    Location = new Point(700, totalHeight),
                    BackColor = Color.FromArgb(174, 37, 43),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    ForeColor = Color.White,
                    Size = new Size(130, 49),
                    UseVisualStyleBackColor = false
                };
                containerPanel.Controls.Add(submitButton);
                submitButton.Click += SubmitButton_Click;

                Label blank = new()
                {
                    Text = "",
                    Size = new Size(130, 100),
                    Location = new Point(600, totalHeight)
                };
                containerPanel.Controls.Add(blank);
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

            assignExamPanel.ShowFields();

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"YOUR SCORE IS {totalScore ?? 0}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            assignExamPanel.ShowFields();
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
