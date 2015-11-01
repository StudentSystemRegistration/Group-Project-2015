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

        public HomeScreen()
        {
            InitializeComponent();
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
