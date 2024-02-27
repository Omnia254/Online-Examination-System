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
    public partial class GradesForm : Form
    {
        private Label labelTotalScore;

        public GradesForm(int totalScore)
        {
            InitializeComponent();
            InitializeComponents(totalScore);
        }

        private void InitializeComponents(int totalScore)
        {
            labelTotalScore = new Label
            {
                Text = $"Total Score: {totalScore}",
                Font = new Font("Arial", 18, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Controls.Add(labelTotalScore);

        }
    }
}