namespace ExaminationSystem.Panels.Instructor
{
    partial class AddTopic
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
            AddTopicPanel = new Panel();
            label1 = new Label();
            AddTopicBtn = new Button();
            TopictextBox = new TextBox();
            Title = new Label();
            AddTopicPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddTopicPanel
            // 
            AddTopicPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddTopicPanel.Controls.Add(label1);
            AddTopicPanel.Controls.Add(AddTopicBtn);
            AddTopicPanel.Controls.Add(TopictextBox);
            AddTopicPanel.Location = new Point(0, 0);
            AddTopicPanel.Name = "AddTopicPanel";
            AddTopicPanel.Size = new Size(930, 728);
            AddTopicPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 190);
            label1.MaximumSize = new Size(0, 30);
            label1.MinimumSize = new Size(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 54;
            label1.Text = "Topic Name";
            // 
            // AddTopicBtn
            // 
            AddTopicBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddTopicBtn.BackColor = Color.FromArgb(174, 37, 43);
            AddTopicBtn.FlatStyle = FlatStyle.Flat;
            AddTopicBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTopicBtn.ForeColor = Color.White;
            AddTopicBtn.Location = new Point(500, 274);
            AddTopicBtn.Margin = new Padding(3, 2, 3, 2);
            AddTopicBtn.Name = "AddTopicBtn";
            AddTopicBtn.Size = new Size(157, 49);
            AddTopicBtn.TabIndex = 50;
            AddTopicBtn.Text = "Add Topic";
            AddTopicBtn.UseVisualStyleBackColor = false;
            AddTopicBtn.Click += AddTopicBtn_Click;
            // 
            // TopictextBox
            // 
            TopictextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TopictextBox.BackColor = Color.White;
            TopictextBox.BorderStyle = BorderStyle.None;
            TopictextBox.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TopictextBox.Location = new Point(438, 190);
            TopictextBox.Margin = new Padding(3, 2, 3, 2);
            TopictextBox.MaximumSize = new Size(219, 30);
            TopictextBox.MinimumSize = new Size(219, 30);
            TopictextBox.Name = "TopictextBox";
            TopictextBox.Size = new Size(219, 30);
            TopictextBox.TabIndex = 47;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Font = new Font("Candara", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(174, 37, 43);
            Title.Location = new Point(367, 42);
            Title.MaximumSize = new Size(0, 38);
            Title.MinimumSize = new Size(0, 38);
            Title.Name = "Title";
            Title.Size = new Size(195, 38);
            Title.TabIndex = 51;
            Title.Text = "ADD TOPIC";
            // 
            // AddTopic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Title);
            Controls.Add(AddTopicPanel);
            Name = "AddTopic";
            Size = new Size(930, 728);
            AddTopicPanel.ResumeLayout(false);
            AddTopicPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AddTopicPanel;
        private TextBox TopictextBox;
        private Button AddTopicBtn;
        private Label Title;
        private Label label1;
    }
}
