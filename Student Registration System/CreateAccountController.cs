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
        private Student s;
        private createAccount newUser;


        private string[] studentDetails = new string[6];
        string name = "";
        string address = "";
        string password = "";
        string dob = "";
        string phoneNo = "";
        string courseId = "";
        string appNum = "";

        // Start the New Student Dialogue
        public void start()
        {
            newUser = new createAccount();
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
            this.appNum = studentDetails[0];
            this.name = studentDetails[1];
            this.address = studentDetails[2];
            this.courseId = studentDetails[3];
            this.dob = studentDetails[4];
            this.phoneNo = studentDetails[5];

            System.Windows.Forms.MessageBox.Show(name);
            createStudent();

        }

        public string getAppNum()
        {
            return appNum;
        }

        public void createStudent()
        {
             s = new Student(appNum, name, address, courseId, dob, phoneNo, password);

             displayStudent();
        }

        public Student getStudent()
        {
            return s;
        }




    }
}
