using ExaminationSystem.Context;
using ExaminationSystem.Models;
using Microsoft.Data.SqlClient;
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

namespace ExaminationSystem.Panels.Student
{
	public partial class StudentProfile : UserControl
	{
		ExaminationSystemContext context = new ExaminationSystemContext();
		public Models.Student student = new();
		int studentID;

		public StudentProfile()
		{
			InitializeComponent();

			Load += StudentProfile_Load;
		}

		private void StudentProfile_Load(object sender, EventArgs e)
		{
			context.Students.Load();
			DisableFields();

			FirstName.Text = student.FirstName;
			LastName.Text = student.LastName;
			Address.Text = student.Address;
			PhoneNumber.Text = student.PhoneNum;
			Email.Text = student.Email;
		}

		public void SetStudent(Models.Student _student)
		{
			student = _student;
			studentID = _student.StudentId;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FirstName.Text))
			{
				MessageBox.Show("Please enter your First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(LastName.Text))
			{
				MessageBox.Show("Please enter your Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(Address.Text))
			{
				MessageBox.Show("Please enter your Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(PhoneNumber.Text))
			{
				MessageBox.Show("Please enter your Phone Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(Email.Text))
			{
				MessageBox.Show("Please enter your Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (PhoneNumber.Text.Length != 11)
			{
				MessageBox.Show("Phone Number Should be 11 Numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string firstThreeDigits = PhoneNumber.Text.Substring(0, 3);
			string onlyNumbersPattern = @"^\d+$";

			if (!Regex.IsMatch(PhoneNumber.Text, onlyNumbersPattern))
			{
				MessageBox.Show("Phone Number MUST Contain only Digits!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!(firstThreeDigits == "010" || firstThreeDigits == "011" || firstThreeDigits == "012" || firstThreeDigits == "015"))
			{
				MessageBox.Show("Phone Number MUST Start with 010, 011, 012, or 015.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

			if (!Regex.IsMatch(Email.Text, pattern))
			{
				MessageBox.Show("INVALID EMAIL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				var studentIDParameter = new SqlParameter("@StudentId", studentID);
				var firstNameParameter = new SqlParameter("@FirstName", FirstName.Text);
				var lastNameParameter = new SqlParameter("@LastName", LastName.Text);
				var addressParameter = new SqlParameter("@Address", Address.Text);
				var phoneNumberParameter = new SqlParameter("@PhoneNum", PhoneNumber.Text);
				var emailParameter = new SqlParameter("@Email", Email.Text);
				var deptIDParameter = new SqlParameter("@DepartmentID", student.DepartmentId);

				context.Database.ExecuteSqlRaw("EXECUTE UPDATESTUDENT @StudentId, @FirstName, @LastName, @Address, @Email, @PhoneNum, @DepartmentID",
					studentIDParameter, firstNameParameter, lastNameParameter, addressParameter, emailParameter, phoneNumberParameter, deptIDParameter);

				MessageBox.Show("Your Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				student.FirstName = FirstName.Text;
				student.LastName = LastName.Text;
				student.Address = Address.Text;
				student.PhoneNum = PhoneNumber.Text;
				student.Email = Email.Text;

				context.SaveChanges();

				var studentDashboardForm = Application.OpenForms.OfType<StudentDashboard>().FirstOrDefault();
				studentDashboardForm?.ReloadForm();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while saving your Profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			DisableFields();
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			EnableFields();
		}

		public void EnableFields()
		{
			FirstName.Enabled = true;
			LastName.Enabled = true;
			Address.Enabled = true;
			PhoneNumber.Enabled = true;
			Email.Enabled = true;

			SaveBtn.Visible = true;
			EditBtn.Visible = false;
		}

		public void DisableFields()
		{
			FirstName.Text = student.FirstName;
			LastName.Text = student.LastName;
			Address.Text = student.Address;
			PhoneNumber.Text = student.PhoneNum;
			Email.Text = student.Email;

			FirstName.Enabled = false;
			LastName.Enabled = false;
			Address.Enabled = false;
			PhoneNumber.Enabled = false;
			Email.Enabled = false;

			EditBtn.Visible = true;
			SaveBtn.Visible = false;
		}
	}
}
