namespace ExaminationSystem.Panels.Student
{
	partial class StudentHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
			StudentHomePanel = new Panel();
			Title = new Label();
			pictureBox1 = new PictureBox();
			StudentHomePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// StudentHomePanel
			// 
			StudentHomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			StudentHomePanel.BackColor = SystemColors.Control;
			StudentHomePanel.Controls.Add(Title);
			StudentHomePanel.Controls.Add(pictureBox1);
			StudentHomePanel.Location = new Point(0, 0);
			StudentHomePanel.Name = "StudentHomePanel";
			StudentHomePanel.Size = new Size(930, 728);
			StudentHomePanel.TabIndex = 0;
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
			Title.TabIndex = 35;
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
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// StudentHome
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(StudentHomePanel);
			Name = "StudentHome";
			Size = new Size(930, 728);
			StudentHomePanel.ResumeLayout(false);
			StudentHomePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel StudentHomePanel;
		private PictureBox pictureBox1;
		private Label Title;
	}
}
