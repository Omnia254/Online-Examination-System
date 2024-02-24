namespace ExaminationSystem.Panels.Student
{
	partial class StudentProfile
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
			StudentProfilePanel = new Panel();
			AddressLabel = new Label();
			Address = new TextBox();
			EditBtn = new Button();
			SaveBtn = new Button();
			LastNameLabel = new Label();
			PhoneNumberLabel = new Label();
			EmailLabel = new Label();
			FirstNameLabel = new Label();
			LastName = new TextBox();
			PhoneNumber = new TextBox();
			Email = new TextBox();
			FirstName = new TextBox();
			Title = new Label();
			StudentProfilePanel.SuspendLayout();
			SuspendLayout();
			// 
			// StudentProfilePanel
			// 
			StudentProfilePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			StudentProfilePanel.Controls.Add(AddressLabel);
			StudentProfilePanel.Controls.Add(Address);
			StudentProfilePanel.Controls.Add(EditBtn);
			StudentProfilePanel.Controls.Add(SaveBtn);
			StudentProfilePanel.Controls.Add(LastNameLabel);
			StudentProfilePanel.Controls.Add(PhoneNumberLabel);
			StudentProfilePanel.Controls.Add(EmailLabel);
			StudentProfilePanel.Controls.Add(FirstNameLabel);
			StudentProfilePanel.Controls.Add(LastName);
			StudentProfilePanel.Controls.Add(PhoneNumber);
			StudentProfilePanel.Controls.Add(Email);
			StudentProfilePanel.Controls.Add(FirstName);
			StudentProfilePanel.Controls.Add(Title);
			StudentProfilePanel.Location = new Point(0, 0);
			StudentProfilePanel.Name = "StudentProfilePanel";
			StudentProfilePanel.Size = new Size(930, 728);
			StudentProfilePanel.TabIndex = 0;
			// 
			// AddressLabel
			// 
			AddressLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddressLabel.AutoSize = true;
			AddressLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			AddressLabel.Location = new Point(243, 330);
			AddressLabel.MaximumSize = new Size(0, 30);
			AddressLabel.MinimumSize = new Size(0, 30);
			AddressLabel.Name = "AddressLabel";
			AddressLabel.Size = new Size(93, 30);
			AddressLabel.TabIndex = 75;
			AddressLabel.Text = "Address";
			// 
			// Address
			// 
			Address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			Address.BackColor = Color.White;
			Address.BorderStyle = BorderStyle.None;
			Address.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Address.Location = new Point(438, 330);
			Address.MaximumSize = new Size(250, 30);
			Address.MinimumSize = new Size(250, 30);
			Address.Name = "Address";
			Address.Size = new Size(250, 30);
			Address.TabIndex = 74;
			// 
			// EditBtn
			// 
			EditBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			EditBtn.BackColor = Color.FromArgb(174, 37, 43);
			EditBtn.FlatStyle = FlatStyle.Flat;
			EditBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			EditBtn.ForeColor = Color.White;
			EditBtn.Location = new Point(573, 600);
			EditBtn.Name = "EditBtn";
			EditBtn.Size = new Size(117, 49);
			EditBtn.TabIndex = 73;
			EditBtn.Text = "Edit";
			EditBtn.UseVisualStyleBackColor = false;
			EditBtn.Click += EditBtn_Click;
			// 
			// SaveBtn
			// 
			SaveBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			SaveBtn.BackColor = Color.FromArgb(174, 37, 43);
			SaveBtn.FlatStyle = FlatStyle.Flat;
			SaveBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			SaveBtn.ForeColor = Color.White;
			SaveBtn.Location = new Point(573, 600);
			SaveBtn.Name = "SaveBtn";
			SaveBtn.Size = new Size(117, 49);
			SaveBtn.TabIndex = 72;
			SaveBtn.Text = "Save";
			SaveBtn.UseVisualStyleBackColor = false;
			SaveBtn.Click += SaveBtn_Click;
			// 
			// LastNameLabel
			// 
			LastNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			LastNameLabel.AutoSize = true;
			LastNameLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LastNameLabel.Location = new Point(243, 235);
			LastNameLabel.MaximumSize = new Size(0, 30);
			LastNameLabel.MinimumSize = new Size(0, 30);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new Size(114, 30);
			LastNameLabel.TabIndex = 71;
			LastNameLabel.Text = "Last Name";
			// 
			// PhoneNumberLabel
			// 
			PhoneNumberLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			PhoneNumberLabel.AutoSize = true;
			PhoneNumberLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PhoneNumberLabel.Location = new Point(243, 425);
			PhoneNumberLabel.MaximumSize = new Size(0, 30);
			PhoneNumberLabel.MinimumSize = new Size(0, 30);
			PhoneNumberLabel.Name = "PhoneNumberLabel";
			PhoneNumberLabel.Size = new Size(161, 30);
			PhoneNumberLabel.TabIndex = 70;
			PhoneNumberLabel.Text = "Phone Number";
			// 
			// EmailLabel
			// 
			EmailLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			EmailLabel.AutoSize = true;
			EmailLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			EmailLabel.Location = new Point(243, 520);
			EmailLabel.MaximumSize = new Size(0, 30);
			EmailLabel.MinimumSize = new Size(0, 30);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new Size(66, 30);
			EmailLabel.TabIndex = 69;
			EmailLabel.Text = "Email";
			// 
			// FirstNameLabel
			// 
			FirstNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			FirstNameLabel.AutoSize = true;
			FirstNameLabel.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			FirstNameLabel.Location = new Point(243, 140);
			FirstNameLabel.MaximumSize = new Size(0, 30);
			FirstNameLabel.MinimumSize = new Size(0, 30);
			FirstNameLabel.Name = "FirstNameLabel";
			FirstNameLabel.Size = new Size(118, 30);
			FirstNameLabel.TabIndex = 68;
			FirstNameLabel.Text = "First Name";
			// 
			// LastName
			// 
			LastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			LastName.BackColor = Color.White;
			LastName.BorderStyle = BorderStyle.None;
			LastName.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LastName.Location = new Point(438, 235);
			LastName.MaximumSize = new Size(250, 30);
			LastName.MinimumSize = new Size(250, 30);
			LastName.Name = "LastName";
			LastName.Size = new Size(250, 30);
			LastName.TabIndex = 67;
			// 
			// PhoneNumber
			// 
			PhoneNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			PhoneNumber.BackColor = Color.White;
			PhoneNumber.BorderStyle = BorderStyle.None;
			PhoneNumber.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			PhoneNumber.Location = new Point(438, 425);
			PhoneNumber.MaximumSize = new Size(250, 30);
			PhoneNumber.MinimumSize = new Size(250, 30);
			PhoneNumber.Name = "PhoneNumber";
			PhoneNumber.Size = new Size(250, 30);
			PhoneNumber.TabIndex = 66;
			// 
			// Email
			// 
			Email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			Email.BackColor = Color.White;
			Email.BorderStyle = BorderStyle.None;
			Email.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Email.Location = new Point(438, 520);
			Email.MaximumSize = new Size(250, 30);
			Email.MinimumSize = new Size(250, 30);
			Email.Name = "Email";
			Email.Size = new Size(250, 30);
			Email.TabIndex = 65;
			// 
			// FirstName
			// 
			FirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			FirstName.BackColor = Color.White;
			FirstName.BorderStyle = BorderStyle.None;
			FirstName.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FirstName.Location = new Point(440, 140);
			FirstName.MaximumSize = new Size(250, 30);
			FirstName.MinimumSize = new Size(250, 30);
			FirstName.Name = "FirstName";
			FirstName.Size = new Size(250, 30);
			FirstName.TabIndex = 64;
			// 
			// Title
			// 
			Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			Title.AutoSize = true;
			Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Title.ForeColor = Color.FromArgb(174, 37, 43);
			Title.Location = new Point(387, 24);
			Title.MaximumSize = new Size(0, 50);
			Title.MinimumSize = new Size(0, 50);
			Title.Name = "Title";
			Title.Size = new Size(155, 50);
			Title.TabIndex = 63;
			Title.Text = "PROFILE";
			// 
			// StudentProfile
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(StudentProfilePanel);
			Name = "StudentProfile";
			Size = new Size(930, 728);
			StudentProfilePanel.ResumeLayout(false);
			StudentProfilePanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel StudentProfilePanel;
		private Button EditBtn;
		private Button SaveBtn;
		private Label LastNameLabel;
		private Label PhoneNumberLabel;
		private Label EmailLabel;
		private Label FirstNameLabel;
		public TextBox LastName;
		public TextBox PhoneNumber;
		public TextBox Email;
		public TextBox FirstName;
		private Label Title;
		private Label AddressLabel;
		public TextBox Address;
	}
}
