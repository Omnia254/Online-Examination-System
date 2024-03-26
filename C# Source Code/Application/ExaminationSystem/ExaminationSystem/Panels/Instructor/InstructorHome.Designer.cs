namespace ExaminationSystem.Panels.Instructor
{
	partial class InstructorHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorHome));
			InstructorHomePanel = new Panel();
			Title = new Label();
			pictureBox1 = new PictureBox();
			InstructorHomePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// InstructorHomePanel
			// 
			InstructorHomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			InstructorHomePanel.BackColor = SystemColors.Control;
			InstructorHomePanel.Controls.Add(Title);
			InstructorHomePanel.Controls.Add(pictureBox1);
			InstructorHomePanel.Location = new Point(0, 0);
			InstructorHomePanel.Name = "InstructorHomePanel";
			InstructorHomePanel.Size = new Size(930, 728);
			InstructorHomePanel.TabIndex = 0;
			// 
			// Title
			// 
			Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			Title.AutoSize = true;
			Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Title.ForeColor = Color.FromArgb(174, 37, 43);
			Title.Location = new Point(320, 24);
			Title.MaximumSize = new Size(0, 50);
			Title.MinimumSize = new Size(0, 50);
			Title.Name = "Title";
			Title.Size = new Size(290, 50);
			Title.TabIndex = 37;
			Title.Text = "WELCOME TO ITI";
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(135, 173);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(660, 420);
			pictureBox1.TabIndex = 36;
			pictureBox1.TabStop = false;
			// 
			// InstructorHome
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(InstructorHomePanel);
			Name = "InstructorHome";
			Size = new Size(930, 728);
			InstructorHomePanel.ResumeLayout(false);
			InstructorHomePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel InstructorHomePanel;
		private Label Title;
		private PictureBox pictureBox1;
	}
}
