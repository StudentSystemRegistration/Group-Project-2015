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
    public partial class StageDetailsScreen : Form
    {

        Subject[] subjects;

        public StageDetailsScreen(Course c)
        {
            InitializeComponent();

            //  Init UI
            tbCourseCode.Text = c.getCourseCode();
            tbCourseTitle.Text = c.getTitle();

            int nextYear = c.getNextStageID();
            int currentYear = c.getCurrentStageID();

            tbCurrYear.Text = "" + currentYear;
            tbNextYear.Text = "" + nextYear;

            subjects = Program.getCourse(c.getCourseCode()).getStages()[nextYear].getSubjects();

            for(int index = 0; index < subjects.Length; index++)
            {
                if (subjects[index].isOptional())
                {
                    cbOptional.Items.Add(subjects[index].getTitle());
                } else
                {
                    cbMandatory.Items.Add(subjects[index].getTitle());
                }
            }

            for(int index = 0; index < cbMandatory.Items.Count; index++)
            {
                cbMandatory.SetItemChecked(index, true);
            }

        }

        private void StageDetailsScreen_Load(object sender, EventArgs e)
        {

        }

        private void tbCourseTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void stageNextButton_Click(object sender, EventArgs e)
        {
            CalculateFees studentFees = new CalculateFees(subjects);
            studentFees.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
