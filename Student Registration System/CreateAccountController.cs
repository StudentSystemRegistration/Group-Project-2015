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

namespace Student_Registration_System
{
    class CreateAccountController : Controller
    {
        //  Member Variables
        private CredentialSystem c;
        private Student s;

        private string appNbr;
        private string courseCode;

        //  Default Constructor
        public CreateAccountController()
        {

        }

        public string getAppNbr()
        {
            return appNbr;
        }

        public override string start()
        {
            appNbr = askForAppNbr();

            //  Check if user is already registered as a student
            if(!(Program.getAccount(appNbr) == null))
            {
                //  User already has an account, exit
                return null;
            }

            string[] studentInfo = checkCredentials(appNbr);

            while(studentInfo == null)
            {
                //  Wrong Application Number, try again
                appNbr = askForAppNbr();
                studentInfo = checkCredentials(appNbr);
            }
            appNbr = studentInfo[0];
            string name = studentInfo[1];
            string address = studentInfo[2];
            courseCode = studentInfo[3];
            string dob = studentInfo[4];
            string phone = studentInfo[5];

            s = new Student(appNbr);
            s.setName(studentInfo[1]);
            s.setAddress(studentInfo[2]);
            s.setPhone(studentInfo[5]);
            s.setDob(studentInfo[4]);

            //  Display student info , ask for password
            string[] updatedInfo = askForMoreInfo();
            
            if (updatedInfo != null)
            {
                address = updatedInfo[0];
                phone = updatedInfo[1];
                string password = updatedInfo[2];

                //  Update student address and phone number
                s.setAddress(address);
                s.setPhone(phone);

                createAccount(password);
                
                return appNbr;
            }
            else
            {
                //  User pressed cancel
                return null;
            }
        }

        private string askForAppNbr()
        {
            using (AuthScreen screen = new AuthScreen())
            {
                if (screen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    return screen.tbAppNbr.Text;
                }
            }

            return null;
        }

        private string[] checkCredentials(String appNbr)
        {
            c = new CredentialSystem();
            return c.getInfo(appNbr);
        }

        private string[] askForMoreInfo()
        {
            using (StudentInfoScreen screen = new StudentInfoScreen(s, courseCode))
            {
                if (screen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string[] updatedInfo = new string[3];
                    updatedInfo[0] = screen.tbAddress.Text;
                    updatedInfo[1] = screen.tbPhone.Text;
                    updatedInfo[2] = screen.tbPassword.Text;

                    return updatedInfo;
                }
            }

            return null;
        }

        private void createAccount(string password)
        {
            Course c = Program.getCourse(courseCode);
            Account a = new Account(appNbr, password);
            a.setupEmail();
            a.setCourse(c);

            Program.addStudent(s);
            Program.addAccount(a);
        }
    }
}
