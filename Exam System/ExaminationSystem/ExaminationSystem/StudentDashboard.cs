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
