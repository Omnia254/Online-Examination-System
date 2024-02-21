﻿namespace ExaminationSystem
{
    partial class StudentDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            LeftSideBar = new Panel();
            LogOut = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            StudentNameLabel = new Label();
            StudentImage = new PictureBox();
            Header = new Panel();
            ImagePanel = new Panel();
            MainPanel = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            test = new Button();
            LeftSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentImage).BeginInit();
            Header.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftSideBar
            // 
            LeftSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LeftSideBar.BackColor = Color.FromArgb(174, 37, 43);
            LeftSideBar.Controls.Add(LogOut);
            LeftSideBar.Controls.Add(button4);
            LeftSideBar.Controls.Add(button3);
            LeftSideBar.Controls.Add(button2);
            LeftSideBar.Controls.Add(button1);
            LeftSideBar.Controls.Add(StudentNameLabel);
            LeftSideBar.Controls.Add(StudentImage);
            LeftSideBar.Location = new Point(0, 0);
            LeftSideBar.Name = "LeftSideBar";
            LeftSideBar.Size = new Size(350, 855);
            LeftSideBar.TabIndex = 0;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Bottom;
            LogOut.BackColor = Color.White;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Black;
            LogOut.Location = new Point(0, 776);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(350, 49);
            LogOut.TabIndex = 6;
            LogOut.Text = "Log Out";
            LogOut.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(0, 590);
            button4.Name = "button4";
            button4.Size = new Size(350, 49);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 535);
            button3.Name = "button3";
            button3.Size = new Size(350, 49);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 480);
            button2.Name = "button2";
            button2.Size = new Size(350, 49);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 425);
            button1.Name = "button1";
            button1.Size = new Size(350, 49);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNameLabel.ForeColor = Color.White;
            StudentNameLabel.Location = new Point(47, 303);
            StudentNameLabel.MaximumSize = new Size(250, 80);
            StudentNameLabel.MinimumSize = new Size(250, 35);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.RightToLeft = RightToLeft.No;
            StudentNameLabel.Size = new Size(250, 35);
            StudentNameLabel.TabIndex = 1;
            StudentNameLabel.Text = "Student Name";
            StudentNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentImage
            // 
            StudentImage.BackgroundImage = (Image)resources.GetObject("StudentImage.BackgroundImage");
            StudentImage.BackgroundImageLayout = ImageLayout.Stretch;
            StudentImage.Location = new Point(47, 25);
            StudentImage.Name = "StudentImage";
            StudentImage.Size = new Size(250, 250);
            StudentImage.TabIndex = 0;
            StudentImage.TabStop = false;
            // 
            // Header
            // 
            Header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Header.BackColor = Color.White;
            Header.BackgroundImageLayout = ImageLayout.Center;
            Header.Controls.Add(ImagePanel);
            Header.Location = new Point(350, 0);
            Header.Name = "Header";
            Header.Size = new Size(930, 125);
            Header.TabIndex = 0;
            // 
            // ImagePanel
            // 
            ImagePanel.Anchor = AnchorStyles.Top;
            ImagePanel.BackColor = Color.White;
            ImagePanel.BackgroundImage = Properties.Resources.iti_logo_text;
            ImagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            ImagePanel.Location = new Point(315, 0);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(300, 113);
            ImagePanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.BackColor = Color.FromArgb(242, 242, 242);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(textBox2);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(textBox1);
            MainPanel.Controls.Add(test);
            MainPanel.Location = new Point(350, 125);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(930, 728);
            MainPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(351, 288);
            label2.MaximumSize = new Size(0, 30);
            label2.MinimumSize = new Size(0, 30);
            label2.Name = "label2";
            label2.Size = new Size(53, 30);
            label2.TabIndex = 11;
            label2.Text = "Test";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(351, 326);
            textBox2.MaximumSize = new Size(250, 30);
            textBox2.MinimumSize = new Size(250, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 30);
            textBox2.TabIndex = 10;
            textBox2.Text = "Ay Kalam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 197);
            label1.MaximumSize = new Size(0, 30);
            label1.MinimumSize = new Size(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(53, 30);
            label1.TabIndex = 9;
            label1.Text = "Test";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(351, 235);
            textBox1.MaximumSize = new Size(250, 30);
            textBox1.MinimumSize = new Size(250, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 30);
            textBox1.TabIndex = 8;
            textBox1.Text = "Ay Kalam";
            // 
            // test
            // 
            test.BackColor = Color.FromArgb(174, 37, 43);
            test.FlatStyle = FlatStyle.Flat;
            test.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            test.ForeColor = Color.White;
            test.Location = new Point(410, 439);
            test.Name = "test";
            test.Size = new Size(138, 49);
            test.TabIndex = 7;
            test.Text = "button5";
            test.UseVisualStyleBackColor = false;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 853);
            Controls.Add(MainPanel);
            Controls.Add(Header);
            Controls.Add(LeftSideBar);
            MinimumSize = new Size(1300, 900);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            LeftSideBar.ResumeLayout(false);
            LeftSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentImage).EndInit();
            Header.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftSideBar;
        private Panel Header;
        private Panel ImagePanel;
        private Panel MainPanel;
        private PictureBox StudentImage;
        private Label StudentNameLabel;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button LogOut;
        private Button test;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
    }
}