/*
Authors:    Brian Discin
            Paul Dunne
            Eddy Fakhry
            Declan Murphy
            Elvis Porebski   
Date:       31-10-15
Purpose:    Student Registration System
*/

namespace Student_Registration_System
{
    public class Session
    {
        //  Member Variables
        private Controller ctr = null;
        private Account user = null;

        //  Default Constructor
        public Session()
        {
            //startCreateAccount();
        }

        public void setAccount(Account a)
        {
            user = a;
        }

        public bool canRegister()
        {
            int currentYear = user.getCourse().getCurrentStageID();
            if(currentYear == -1)
            {
                return true;
            }
            string status = user.getCourse().getStages()[currentYear].getStatus();

            if(string.Equals(status, "passed"))
            {
                return true;
            }

            return false;
        }

        //  Loads Controller for creating an account
        public string startCreateAccount()
        {
            this.ctr = new CreateAccountController();
            string userID =  ctr.start();

            return userID;
        }

        //  Loads Controller to register for a stage
        public bool startRegisterStage()
        {
            this.ctr = new RegisterStageController(user);
            string status = ctr.start();

            if (string.Equals(status, "ok"))
            {
                return true;
            }

            return false;
        }
    }
}
