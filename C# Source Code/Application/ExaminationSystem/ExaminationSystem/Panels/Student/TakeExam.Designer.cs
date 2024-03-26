namespace ExaminationSystem.Panels.Student
{
    partial class TakeExam
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
            containerPanel = new Panel();
            SuspendLayout();
            // 
            // containerPanel
            // 
            containerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            containerPanel.AutoScroll = true;
            containerPanel.BackColor = SystemColors.Control;
            containerPanel.Location = new Point(0, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(930, 728);
            containerPanel.TabIndex = 0;
            // 
            // TakeExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(containerPanel);
            Name = "TakeExam";
            Size = new Size(930, 728);
            Load += TakeExam_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel containerPanel;
    }
}
