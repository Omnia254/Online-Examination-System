using ExaminationSystem.Context;
using System;
using System.Collections.Generic;


namespace ExaminationSystem
{
    public partial class TakeExam : Form
    {
        ExaminationSystemContext context;
        ExaminationSystemContextProcedures procedures;
        public TakeExam()
        {
            InitializeComponent();
            context = new ExaminationSystemContext();
            procedures = new ExaminationSystemContextProcedures(context);
            this.FormClosed += (sender, e) => context.Dispose();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var questionsList = await procedures.GetExamQuestionsTextByIdAsync(4);
                Panel containerPanel = new Panel
                {
                    AutoScroll = true,
                    Dock = DockStyle.Fill // Dock to fill the entire form
                };
              
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
                        Size = new Size(400, 100)
                    };

                    for (int j = 0; j < choicesList.Count; j++)
                    {
                        RadioButton radioButton = new RadioButton
                        {
                            Text = $"{choicesList[j].ChoiceText}",
                            AutoSize = true,
                            Location = new Point(20, 20 + j * 25),
                            Tag = i // Use the Tag property to identify the question
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
        private void SubmitButton_Click(object sender, EventArgs e)
        {
     
            MessageBox.Show("Exam Submitted!");
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            int questionIndex = (int)radioButton.Tag;
            string choiceText = radioButton.Text;
           // MessageBox.Show(choiceText);
        }
    }
}
