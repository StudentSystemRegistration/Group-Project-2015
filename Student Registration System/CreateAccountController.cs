using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    class CreateAccountController
    {
        private ExternalSystem c;
        private string[] studentDetails = new string[6];

        // Start the New Student Dialogue
        public void start()
        {
            createAccount newUser = new createAccount();
            newUser.ShowDialog();
        }

        // Create Instance of Credential System
        public void create()
        {
            c = new ExternalSystem();
        }

        // Display Student Details Form
        public void displayStudent()
        {
            StudentDetails sd = new StudentDetails();
            sd.ShowDialog();
        }

        // Check if the application number exists
        public void checkCredentials(string appNum)
        {
            studentDetails = c.getInfo(appNum);

            // If data exists, then call next window to display data
            if(studentDetails[0] != "")
            {
                displayStudent();
            }
        }

    }
}
