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
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class StageDetailsScreen : Form
    {
        private Subject[] allSubjects;
        private int nbrOptional;
        //private List<Subject> chosen;

        //  Optional subjects stored in dictionary
        private Dictionary<int, Subject> chosen;

        public StageDetailsScreen(Course c)
        {
            InitializeComponent();

            chosen = new Dictionary<int, Subject>();

            //  Init UI
            tbCourseCode.Text = c.getCourseCode();
            tbCourseTitle.Text = c.getTitle();

            int nextYear = c.getNextStageID();
            int currentYear = c.getCurrentStageID();

            tbCurrYear.Text = "" + (currentYear + 1);
            tbNextYear.Text = "" + (nextYear + 1);

            //  Get next stage
            Stage stage = Program.getCourse(c.getCourseCode()).getStages()[nextYear];
            allSubjects = stage.getSubjects();
            nbrOptional = stage.getNbrOptional();
            //nbrMandatory = 0;

            //  Update label
            lbSelected.Text = "" + chosen.Count + "/" + nbrOptional;

            for (int index = 0; index < allSubjects.Length; index++)
            {
                if (allSubjects[index].isOptional())
                {
                    cbOptional.Items.Add(allSubjects[index].getTitle());
                }
                else
                {
                    cbMandatory.Items.Add(allSubjects[index].getTitle());
                    //nbrMandatory++;
                }
            }

            for (int index = 0; index < cbMandatory.Items.Count; index++)
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

        private void cbOptional_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //  If optional subject was checked
            if (e.NewValue == CheckState.Checked)
            {
                //  Get text from checkbox item that was selected
                string title = cbOptional.GetItemText(cbOptional.Items[e.Index]);

                //  Add it to collection of optional
                chosen.Add(e.Index, getSubject(title));
            }
            else
            {
                chosen.Remove(e.Index);
            }

            lbSelected.Text = "" + chosen.Count + "/" + nbrOptional;
            if (chosen.Count != nbrOptional)
            {
                btnPickOptional.Enabled = false;
            }
            else
            {
                btnPickOptional.Enabled = true;
            }
        }

        private Subject getSubject(string title)
        {
            for(int index = 0; index < allSubjects.Length; index++)
            {
                if(string.Equals(title, allSubjects[index].getTitle()))
                {
                    return allSubjects[index];
                }
            }
            return null;
        }

        private void btnPickOptional_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Returns all mandatory + chosen optional subjects
        public Subject[] getSelectedSubjects()
        {
            //  Create a list of mandatory subjects
            List<Subject> selectedSubjects = getMandatory();
            //  Add optional subject chosen by student
            selectedSubjects.AddRange(chosen.Values);

            //  Convert list to an array and return it
            return selectedSubjects.ToArray();
        }

        private List<Subject> getMandatory()
        {
            List<Subject> mandatory = new List<Subject>();

            //  Check each subject
            for (int index = 0; index < allSubjects.Length; index++)
            {
                //  If it is mandatory add it to a list
                if (!allSubjects[index].isOptional())
                {
                    mandatory.Add(allSubjects[index]);
                }
            }
            //  Return list of mandatory subjects
            return mandatory;
        }
    }
}
