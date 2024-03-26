namespace ExaminationSystem.Panels.Instructor
{
	partial class EditQuestion
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			EditQuestionPanel = new Panel();
			SearchID = new Button();
			DeleteQuestionBtn = new Button();
			QuestionID = new TextBox();
			EnterQuestionIDLabel = new Label();
			radioButton5 = new RadioButton();
			radioButton4 = new RadioButton();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			Option2Label = new Label();
			Option3Label = new Label();
			Option4Label = new Label();
			Option5Label = new Label();
			Option1Label = new Label();
			ChoiceText2 = new TextBox();
			ChoiceText3 = new TextBox();
			ChoiceText5 = new TextBox();
			ChoiceText4 = new TextBox();
			ChoiceText1 = new TextBox();
			EditQuestionBtn = new Button();
			QuestionText = new RichTextBox();
			Complexity = new ComboBox();
			ComplexityLabel = new Label();
			Course = new ComboBox();
			CourseName = new Label();
			QuestionType = new ComboBox();
			QuestionTypeLabel = new Label();
			QuestionTextLabel = new Label();
			Title = new Label();
			SaveBtn = new Button();
			EditQuestionPanel.SuspendLayout();
			SuspendLayout();
			// 
			// EditQuestionPanel
			// 
			EditQuestionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			EditQuestionPanel.BackColor = Color.FromArgb(242, 242, 242);
			EditQuestionPanel.Controls.Add(SaveBtn);
			EditQuestionPanel.Controls.Add(SearchID);
			EditQuestionPanel.Controls.Add(DeleteQuestionBtn);
			EditQuestionPanel.Controls.Add(QuestionID);
			EditQuestionPanel.Controls.Add(EnterQuestionIDLabel);
			EditQuestionPanel.Controls.Add(radioButton5);
			EditQuestionPanel.Controls.Add(radioButton4);
			EditQuestionPanel.Controls.Add(radioButton3);
			EditQuestionPanel.Controls.Add(radioButton2);
			EditQuestionPanel.Controls.Add(radioButton1);
			EditQuestionPanel.Controls.Add(Option2Label);
			EditQuestionPanel.Controls.Add(Option3Label);
			EditQuestionPanel.Controls.Add(Option4Label);
			EditQuestionPanel.Controls.Add(Option5Label);
			EditQuestionPanel.Controls.Add(Option1Label);
			EditQuestionPanel.Controls.Add(ChoiceText2);
			EditQuestionPanel.Controls.Add(ChoiceText3);
			EditQuestionPanel.Controls.Add(ChoiceText5);
			EditQuestionPanel.Controls.Add(ChoiceText4);
			EditQuestionPanel.Controls.Add(ChoiceText1);
			EditQuestionPanel.Controls.Add(EditQuestionBtn);
			EditQuestionPanel.Controls.Add(QuestionText);
			EditQuestionPanel.Controls.Add(Complexity);
			EditQuestionPanel.Controls.Add(ComplexityLabel);
			EditQuestionPanel.Controls.Add(Course);
			EditQuestionPanel.Controls.Add(CourseName);
			EditQuestionPanel.Controls.Add(QuestionType);
			EditQuestionPanel.Controls.Add(QuestionTypeLabel);
			EditQuestionPanel.Controls.Add(QuestionTextLabel);
			EditQuestionPanel.Controls.Add(Title);
			EditQuestionPanel.Location = new Point(0, 0);
			EditQuestionPanel.Name = "EditQuestionPanel";
			EditQuestionPanel.Size = new Size(930, 728);
			EditQuestionPanel.TabIndex = 0;
			// 
			// SearchID
			// 
			SearchID.Anchor = AnchorStyles.Right;
			SearchID.BackColor = Color.FromArgb(174, 37, 43);
			SearchID.FlatStyle = FlatStyle.Flat;
			SearchID.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			SearchID.ForeColor = Color.White;
			SearchID.Location = new Point(611, 95);
			SearchID.Name = "SearchID";
			SearchID.Size = new Size(97, 40);
			SearchID.TabIndex = 61;
			SearchID.Text = "Search";
			SearchID.UseVisualStyleBackColor = false;
			SearchID.Click += SearchID_Click;
			// 
			// DeleteQuestionBtn
			// 
			DeleteQuestionBtn.Anchor = AnchorStyles.None;
			DeleteQuestionBtn.BackColor = Color.FromArgb(174, 37, 43);
			DeleteQuestionBtn.FlatStyle = FlatStyle.Flat;
			DeleteQuestionBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DeleteQuestionBtn.ForeColor = Color.White;
			DeleteQuestionBtn.Location = new Point(110, 642);
			DeleteQuestionBtn.Name = "DeleteQuestionBtn";
			DeleteQuestionBtn.Size = new Size(157, 49);
			DeleteQuestionBtn.TabIndex = 60;
			DeleteQuestionBtn.Text = "Delete Question";
			DeleteQuestionBtn.UseVisualStyleBackColor = false;
			DeleteQuestionBtn.Click += DeleteQuestionBtn_Click;
			// 
			// QuestionID
			// 
			QuestionID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			QuestionID.BackColor = Color.White;
			QuestionID.BorderStyle = BorderStyle.None;
			QuestionID.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			QuestionID.Location = new Point(437, 100);
			QuestionID.MaximumSize = new Size(150, 30);
			QuestionID.MinimumSize = new Size(150, 30);
			QuestionID.Name = "QuestionID";
			QuestionID.Size = new Size(150, 30);
			QuestionID.TabIndex = 59;
			// 
			// EnterQuestionIDLabel
			// 
			EnterQuestionIDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			EnterQuestionIDLabel.AutoSize = true;
			EnterQuestionIDLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			EnterQuestionIDLabel.Location = new Point(230, 100);
			EnterQuestionIDLabel.MaximumSize = new Size(0, 30);
			EnterQuestionIDLabel.MinimumSize = new Size(0, 30);
			EnterQuestionIDLabel.Name = "EnterQuestionIDLabel";
			EnterQuestionIDLabel.Size = new Size(182, 30);
			EnterQuestionIDLabel.TabIndex = 58;
			EnterQuestionIDLabel.Text = "Enter QuestionID";
			// 
			// radioButton5
			// 
			radioButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			radioButton5.AutoSize = true;
			radioButton5.Font = new Font("Candara", 12F, FontStyle.Bold);
			radioButton5.Location = new Point(717, 587);
			radioButton5.Name = "radioButton5";
			radioButton5.Size = new Size(113, 28);
			radioButton5.TabIndex = 57;
			radioButton5.TabStop = true;
			radioButton5.Text = "Is Correct";
			radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			radioButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			radioButton4.AutoSize = true;
			radioButton4.Font = new Font("Candara", 12F, FontStyle.Bold);
			radioButton4.Location = new Point(717, 492);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(113, 28);
			radioButton4.TabIndex = 56;
			radioButton4.TabStop = true;
			radioButton4.Text = "Is Correct";
			radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			radioButton3.AutoSize = true;
			radioButton3.Font = new Font("Candara", 12F, FontStyle.Bold);
			radioButton3.Location = new Point(717, 397);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(113, 28);
			radioButton3.TabIndex = 55;
			radioButton3.TabStop = true;
			radioButton3.Text = "Is Correct";
			radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			radioButton2.AutoSize = true;
			radioButton2.Font = new Font("Candara", 12F, FontStyle.Bold);
			radioButton2.Location = new Point(717, 302);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(113, 28);
			radioButton2.TabIndex = 54;
			radioButton2.TabStop = true;
			radioButton2.Text = "Is Correct";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			radioButton1.AutoSize = true;
			radioButton1.Font = new Font("Candara", 12F, FontStyle.Bold);
			radioButton1.Location = new Point(717, 207);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(113, 28);
			radioButton1.TabIndex = 53;
			radioButton1.TabStop = true;
			radioButton1.Text = "Is Correct";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// Option2Label
			// 
			Option2Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Option2Label.AutoSize = true;
			Option2Label.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Option2Label.Location = new Point(441, 254);
			Option2Label.MaximumSize = new Size(0, 30);
			Option2Label.MinimumSize = new Size(0, 30);
			Option2Label.Name = "Option2Label";
			Option2Label.Size = new Size(97, 30);
			Option2Label.TabIndex = 52;
			Option2Label.Text = "Option 2";
			// 
			// Option3Label
			// 
			Option3Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Option3Label.AutoSize = true;
			Option3Label.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Option3Label.Location = new Point(441, 347);
			Option3Label.MaximumSize = new Size(0, 30);
			Option3Label.MinimumSize = new Size(0, 30);
			Option3Label.Name = "Option3Label";
			Option3Label.Size = new Size(97, 30);
			Option3Label.TabIndex = 51;
			Option3Label.Text = "Option 3";
			// 
			// Option4Label
			// 
			Option4Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Option4Label.AutoSize = true;
			Option4Label.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Option4Label.Location = new Point(441, 440);
			Option4Label.MaximumSize = new Size(0, 30);
			Option4Label.MinimumSize = new Size(0, 30);
			Option4Label.Name = "Option4Label";
			Option4Label.Size = new Size(98, 30);
			Option4Label.TabIndex = 50;
			Option4Label.Text = "Option 4";
			// 
			// Option5Label
			// 
			Option5Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Option5Label.AutoSize = true;
			Option5Label.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Option5Label.Location = new Point(441, 533);
			Option5Label.MaximumSize = new Size(0, 30);
			Option5Label.MinimumSize = new Size(0, 30);
			Option5Label.Name = "Option5Label";
			Option5Label.Size = new Size(97, 30);
			Option5Label.TabIndex = 49;
			Option5Label.Text = "Option 5";
			// 
			// Option1Label
			// 
			Option1Label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Option1Label.AutoSize = true;
			Option1Label.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Option1Label.Location = new Point(441, 161);
			Option1Label.MaximumSize = new Size(0, 30);
			Option1Label.MinimumSize = new Size(0, 30);
			Option1Label.Name = "Option1Label";
			Option1Label.Size = new Size(94, 30);
			Option1Label.TabIndex = 48;
			Option1Label.Text = "Option 1";
			// 
			// ChoiceText2
			// 
			ChoiceText2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			ChoiceText2.BackColor = Color.White;
			ChoiceText2.BorderStyle = BorderStyle.None;
			ChoiceText2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChoiceText2.Location = new Point(441, 300);
			ChoiceText2.MaximumSize = new Size(250, 30);
			ChoiceText2.MinimumSize = new Size(250, 30);
			ChoiceText2.Name = "ChoiceText2";
			ChoiceText2.Size = new Size(250, 30);
			ChoiceText2.TabIndex = 47;
			// 
			// ChoiceText3
			// 
			ChoiceText3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			ChoiceText3.BackColor = Color.White;
			ChoiceText3.BorderStyle = BorderStyle.None;
			ChoiceText3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChoiceText3.Location = new Point(441, 395);
			ChoiceText3.MaximumSize = new Size(250, 30);
			ChoiceText3.MinimumSize = new Size(250, 30);
			ChoiceText3.Name = "ChoiceText3";
			ChoiceText3.Size = new Size(250, 30);
			ChoiceText3.TabIndex = 46;
			// 
			// ChoiceText5
			// 
			ChoiceText5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			ChoiceText5.BackColor = Color.White;
			ChoiceText5.BorderStyle = BorderStyle.None;
			ChoiceText5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChoiceText5.Location = new Point(441, 585);
			ChoiceText5.MaximumSize = new Size(250, 30);
			ChoiceText5.MinimumSize = new Size(250, 30);
			ChoiceText5.Name = "ChoiceText5";
			ChoiceText5.Size = new Size(250, 30);
			ChoiceText5.TabIndex = 45;
			// 
			// ChoiceText4
			// 
			ChoiceText4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			ChoiceText4.BackColor = Color.White;
			ChoiceText4.BorderStyle = BorderStyle.None;
			ChoiceText4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChoiceText4.Location = new Point(441, 490);
			ChoiceText4.MaximumSize = new Size(250, 30);
			ChoiceText4.MinimumSize = new Size(250, 30);
			ChoiceText4.Name = "ChoiceText4";
			ChoiceText4.Size = new Size(250, 30);
			ChoiceText4.TabIndex = 44;
			// 
			// ChoiceText1
			// 
			ChoiceText1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			ChoiceText1.BackColor = Color.White;
			ChoiceText1.BorderStyle = BorderStyle.None;
			ChoiceText1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChoiceText1.Location = new Point(443, 205);
			ChoiceText1.MaximumSize = new Size(250, 30);
			ChoiceText1.MinimumSize = new Size(250, 30);
			ChoiceText1.Name = "ChoiceText1";
			ChoiceText1.Size = new Size(250, 30);
			ChoiceText1.TabIndex = 43;
			// 
			// EditQuestionBtn
			// 
			EditQuestionBtn.Anchor = AnchorStyles.None;
			EditQuestionBtn.BackColor = Color.FromArgb(174, 37, 43);
			EditQuestionBtn.FlatStyle = FlatStyle.Flat;
			EditQuestionBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			EditQuestionBtn.ForeColor = Color.White;
			EditQuestionBtn.Location = new Point(677, 642);
			EditQuestionBtn.Name = "EditQuestionBtn";
			EditQuestionBtn.Size = new Size(157, 49);
			EditQuestionBtn.TabIndex = 42;
			EditQuestionBtn.Text = "Edit Question";
			EditQuestionBtn.UseVisualStyleBackColor = false;
			EditQuestionBtn.Click += EditQuestionBtn_Click;
			// 
			// QuestionText
			// 
			QuestionText.Anchor = AnchorStyles.Top;
			QuestionText.BorderStyle = BorderStyle.None;
			QuestionText.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			QuestionText.Location = new Point(110, 207);
			QuestionText.Name = "QuestionText";
			QuestionText.Size = new Size(250, 123);
			QuestionText.TabIndex = 41;
			QuestionText.Text = "";
			// 
			// Complexity
			// 
			Complexity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Complexity.FlatStyle = FlatStyle.Flat;
			Complexity.Font = new Font("Candara", 10.8F);
			Complexity.FormattingEnabled = true;
			Complexity.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
			Complexity.Location = new Point(110, 492);
			Complexity.MaximumSize = new Size(250, 0);
			Complexity.MinimumSize = new Size(250, 0);
			Complexity.Name = "Complexity";
			Complexity.Size = new Size(250, 30);
			Complexity.TabIndex = 40;
			// 
			// ComplexityLabel
			// 
			ComplexityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			ComplexityLabel.AutoSize = true;
			ComplexityLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ComplexityLabel.Location = new Point(110, 440);
			ComplexityLabel.MaximumSize = new Size(0, 30);
			ComplexityLabel.MinimumSize = new Size(0, 30);
			ComplexityLabel.Name = "ComplexityLabel";
			ComplexityLabel.Size = new Size(125, 30);
			ComplexityLabel.TabIndex = 39;
			ComplexityLabel.Text = "Complexity";
			// 
			// Course
			// 
			Course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Course.FlatStyle = FlatStyle.Flat;
			Course.Font = new Font("Candara", 10.8F);
			Course.FormattingEnabled = true;
			Course.Location = new Point(110, 589);
			Course.MaximumSize = new Size(250, 0);
			Course.MinimumSize = new Size(250, 0);
			Course.Name = "Course";
			Course.Size = new Size(250, 30);
			Course.TabIndex = 38;
			// 
			// CourseName
			// 
			CourseName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			CourseName.AutoSize = true;
			CourseName.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			CourseName.Location = new Point(110, 533);
			CourseName.MaximumSize = new Size(0, 30);
			CourseName.MinimumSize = new Size(0, 30);
			CourseName.Name = "CourseName";
			CourseName.Size = new Size(81, 30);
			CourseName.TabIndex = 37;
			CourseName.Text = "Course";
			// 
			// QuestionType
			// 
			QuestionType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			QuestionType.FlatStyle = FlatStyle.Flat;
			QuestionType.Font = new Font("Candara", 10.8F);
			QuestionType.FormattingEnabled = true;
			QuestionType.Items.AddRange(new object[] { "T/F", "MCQ" });
			QuestionType.Location = new Point(110, 397);
			QuestionType.MaximumSize = new Size(250, 0);
			QuestionType.MinimumSize = new Size(250, 0);
			QuestionType.Name = "QuestionType";
			QuestionType.Size = new Size(250, 30);
			QuestionType.TabIndex = 36;
			// 
			// QuestionTypeLabel
			// 
			QuestionTypeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			QuestionTypeLabel.AutoSize = true;
			QuestionTypeLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			QuestionTypeLabel.Location = new Point(110, 347);
			QuestionTypeLabel.MaximumSize = new Size(0, 30);
			QuestionTypeLabel.MinimumSize = new Size(0, 30);
			QuestionTypeLabel.Name = "QuestionTypeLabel";
			QuestionTypeLabel.Size = new Size(154, 30);
			QuestionTypeLabel.TabIndex = 35;
			QuestionTypeLabel.Text = "Question Type";
			// 
			// QuestionTextLabel
			// 
			QuestionTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			QuestionTextLabel.AutoSize = true;
			QuestionTextLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			QuestionTextLabel.Location = new Point(110, 161);
			QuestionTextLabel.MaximumSize = new Size(0, 30);
			QuestionTextLabel.MinimumSize = new Size(0, 30);
			QuestionTextLabel.Name = "QuestionTextLabel";
			QuestionTextLabel.Size = new Size(150, 30);
			QuestionTextLabel.TabIndex = 34;
			QuestionTextLabel.Text = "Question Text";
			// 
			// Title
			// 
			Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Title.AutoSize = true;
			Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Title.ForeColor = Color.FromArgb(174, 37, 43);
			Title.Location = new Point(327, 24);
			Title.MaximumSize = new Size(0, 50);
			Title.MinimumSize = new Size(0, 50);
			Title.Name = "Title";
			Title.Size = new Size(270, 50);
			Title.TabIndex = 33;
			Title.Text = "EDIT QUESTION";
			// 
			// SaveBtn
			// 
			SaveBtn.Anchor = AnchorStyles.None;
			SaveBtn.BackColor = Color.FromArgb(174, 37, 43);
			SaveBtn.FlatStyle = FlatStyle.Flat;
			SaveBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			SaveBtn.ForeColor = Color.White;
			SaveBtn.Location = new Point(731, 642);
			SaveBtn.Name = "SaveBtn";
			SaveBtn.Size = new Size(103, 49);
			SaveBtn.TabIndex = 62;
			SaveBtn.Text = "Save";
			SaveBtn.UseVisualStyleBackColor = false;
			SaveBtn.Click += SaveBtn_Click;
			// 
			// EditQuestion
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(EditQuestionPanel);
			Name = "EditQuestion";
			Size = new Size(930, 728);
			EditQuestionPanel.ResumeLayout(false);
			EditQuestionPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel EditQuestionPanel;
		private Label Title;
		private RichTextBox QuestionText;
		private System.Windows.Forms.ComboBox Complexity;
		private Label ComplexityLabel;
		private System.Windows.Forms.ComboBox Course;
		private Label CourseName;
		private System.Windows.Forms.ComboBox QuestionType;
		private Label QuestionTypeLabel;
		private Label QuestionTextLabel;
		private RadioButton radioButton5;
		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private Label Option2Label;
		private Label Option3Label;
		private Label Option4Label;
		private Label Option5Label;
		private Label Option1Label;
		private System.Windows.Forms.TextBox ChoiceText2;
		private System.Windows.Forms.TextBox ChoiceText3;
		private System.Windows.Forms.TextBox ChoiceText5;
		private System.Windows.Forms.TextBox ChoiceText4;
		private System.Windows.Forms.TextBox ChoiceText1;
		private System.Windows.Forms.Button EditQuestionBtn;
		public TextBox QuestionID;
		private Label EnterQuestionIDLabel;
		private Button DeleteQuestionBtn;
		private Button SearchID;
		private Button SaveBtn;
	}
}
