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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
	public partial class StudentDashboard : Form
	{
		List<Button> buttons = new List<Button>();
		ExaminationSystemContext context = new ExaminationSystemContext();
		int studentID = 7;

		public StudentDashboard()
		{
			InitializeComponent();

			buttons.Add(button1);
			buttons.Add(button2);
			buttons.Add(button3);
			buttons.Add(button4);
			buttons.Add(LogOut);

			for (int i = 0; i < buttons.Count(); i++)
			{
				buttons[i].Click += Button_Click;
			}

			try
			{
				Student stud = context.Students.FromSqlRaw("EXECUTE SelectStudent @StudentID",
					new SqlParameter("@StudentID", studentID)).ToList().FirstOrDefault();

				if (stud != null)
				{
					StudentNameLabel.Text = stud.FirstName + " " + stud.LastName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while executing the stored procedure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;

			clickedButton.BackColor = Color.LightGray;

			foreach (var button in buttons)
			{
				if (button != clickedButton)
				{
					button.BackColor = Color.White;
				}
			}
		}
	}
}
