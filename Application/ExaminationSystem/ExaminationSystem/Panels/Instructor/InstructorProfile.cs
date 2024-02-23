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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ExaminationSystem.Panels.Instructor
{
	public partial class InstructorProfile : UserControl
	{
		ExaminationSystemContext context = new ExaminationSystemContext();
		public Models.Instructor instructor = new();
		int instructorID;

		public InstructorProfile()
		{
			InitializeComponent();

			Load += InstructorProfile_Load;
		}

		private void InstructorProfile_Load(object sender, EventArgs e)
		{
			context.Instructors.Load();

			DisableFields();

			FirstName.Text = instructor.FirstName;
			LastName.Text = instructor.LastName;
			PhoneNumber.Text = instructor.PhoneNumber;
			Email.Text = instructor.Email;
		}

		public void SetInstructor(Models.Instructor _instructor)
		{
			instructor = _instructor;
			instructorID = _instructor.InstructorId;
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
				var instructirIDParameter = new SqlParameter("@InstructorID", instructorID);
				var firstNameParameter = new SqlParameter("@FirstName", FirstName.Text);
				var lastNameParameter = new SqlParameter("@LastName", LastName.Text);
				var hireDateParameter = new SqlParameter("@HireDate", instructor.HireDate);
				var phoneNumberParameter = new SqlParameter("@PhoneNumber", PhoneNumber.Text);
				var emailParameter = new SqlParameter("@Email", Email.Text);
				var deptIDParameter = new SqlParameter("@DepartmentID", instructor.DepartmentId);

				context.Database.ExecuteSqlRaw("EXECUTE UPDATEINSTRUCTOR @InstructorID, @FirstName, @LastName, @HireDate, @PhoneNumber, @Email, @DepartmentID",
					instructirIDParameter, firstNameParameter, lastNameParameter, hireDateParameter, phoneNumberParameter, emailParameter, deptIDParameter);

				MessageBox.Show("Your Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				instructor.FirstName = FirstName.Text;
				instructor.LastName = LastName.Text;
				instructor.PhoneNumber = PhoneNumber.Text;
				instructor.Email = Email.Text;

				context.SaveChanges();

				var instructorDashboardForm = Application.OpenForms.OfType<InstructorDashboard>().FirstOrDefault();
				instructorDashboardForm?.ReloadForm();
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
			PhoneNumber.Enabled = true;
			Email.Enabled = true;

			SaveBtn.Visible = true;
			EditBtn.Visible = false;
		}

		public void DisableFields()
		{
			FirstName.Enabled = false;
			LastName.Enabled = false;
			PhoneNumber.Enabled = false;
			Email.Enabled = false;

			EditBtn.Visible = true;
			SaveBtn.Visible = false;
		}
	}
}
