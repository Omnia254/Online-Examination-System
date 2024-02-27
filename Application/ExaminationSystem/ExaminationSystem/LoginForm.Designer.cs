namespace ExaminationSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            ImagePanel = new Panel();
            EmailTxt = new TextBox();
            label1 = new Label();
            PassTxt = new TextBox();
            label2 = new Label();
            stdLogin = new Button();
            insLogin = new Button();
            SuspendLayout();
            // 
            // ImagePanel
            // 
            ImagePanel.Anchor = AnchorStyles.Top;
            ImagePanel.BackColor = Color.White;
            ImagePanel.BackgroundImage = (Image)resources.GetObject("ImagePanel.BackgroundImage");
            ImagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            ImagePanel.Location = new Point(244, 12);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(300, 113);
            ImagePanel.TabIndex = 2;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(255, 217);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(225, 27);
            EmailTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 180);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 4;
            label1.Text = "UserName";
            // 
            // PassTxt
            // 
            PassTxt.Location = new Point(255, 300);
            PassTxt.Name = "PassTxt";
            PassTxt.PasswordChar = '*';
            PassTxt.Size = new Size(225, 27);
            PassTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 268);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // stdLogin
            // 
            stdLogin.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdLogin.Location = new Point(198, 385);
            stdLogin.Name = "stdLogin";
            stdLogin.Size = new Size(198, 37);
            stdLogin.TabIndex = 7;
            stdLogin.Text = "Login As Student";
            stdLogin.UseVisualStyleBackColor = true;
            stdLogin.Click += stdLogin_Click;
            // 
            // insLogin
            // 
            insLogin.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insLogin.Location = new Point(418, 385);
            insLogin.Name = "insLogin";
            insLogin.Size = new Size(193, 37);
            insLogin.TabIndex = 8;
            insLogin.Text = "Login As Instructor";
            insLogin.UseVisualStyleBackColor = true;
            insLogin.Click += insLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(insLogin);
            Controls.Add(stdLogin);
            Controls.Add(label2);
            Controls.Add(PassTxt);
            Controls.Add(label1);
            Controls.Add(EmailTxt);
            Controls.Add(ImagePanel);
            Name = "LoginForm";
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ImagePanel;
        private TextBox EmailTxt;
        private Label label1;
        private TextBox PassTxt;
        private Label label2;
        private Button stdLogin;
        private Button insLogin;
    }
}