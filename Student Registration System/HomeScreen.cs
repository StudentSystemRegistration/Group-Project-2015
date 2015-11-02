/*
Authors:    Brian Discin
            Paul Dunne
            Eddy Fakhry
            Declan Murphy
            Elvis Porebski   
Date:       31-10-15
Purpose:    Student Registration System
*/

using System;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class HomeScreen : Form
    {
        public string action = "";

        public HomeScreen(bool registrationEnabled)
        {
            InitializeComponent();

            lbCurrentTime.Text = "Current Time: " + DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt");

            if (!registrationEnabled)
            {
                btnRS.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action = "registerStage";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
