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
    public partial class StudentInfoScreen : Form
    {
        public StudentInfoScreen(Student s, string courseCode)
        {
            InitializeComponent();

            //  Update UI with student info
            this.tbAppNbr.Text = s.getStudentID();
            this.tbName.Text = s.getName();
            this.tbDob.Text = s.getDob();
            this.tbCourseCode.Text = courseCode;
            this.tbAddress.Text = s.getAddress();
            this.tbPhone.Text = s.getPhone();
        }

        private void StudentInfoScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
