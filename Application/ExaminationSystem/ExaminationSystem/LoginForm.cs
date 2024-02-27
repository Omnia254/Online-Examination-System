using ExaminationSystem.Context;
using ExaminationSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class LoginForm : Form
    {
        ExaminationSystemContext context = new();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void stdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailTxt.Text.Trim();
                context.Students.Load();
                if (IsValidEmail(email))
                {
                    if (context.Students.Local.Where(S => S.Email == email).Any())
                    {
                        context.Logins.Load();
                        Login selectedLogin = context.Logins.Where(L => L.Email == email).FirstOrDefault();
                        if (selectedLogin != null && selectedLogin.Password == PassTxt.Text)
                        {
                            StudentDashboard studentDashboard = new(context.Students.Local.Where(S => S.Email == email).FirstOrDefault());
                            studentDashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show("Failed To Sign in..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        private void insLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailTxt.Text.Trim();
                if (IsValidEmail(email))
                {
                    if (context.Instructors.Where(I => I.Email == email).Any())
                    {
                        
                        Login selectedLogin = context.Logins.Where(L => L.Email == email).FirstOrDefault();
                        if (selectedLogin != null && selectedLogin.Password == PassTxt.Text)
                        {
                            InstructorDashboard instructorDashboard = new(context.Instructors.Where(I => I.Email == email).FirstOrDefault());
                            instructorDashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { MessageBox.Show("Failed To Sign in..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
