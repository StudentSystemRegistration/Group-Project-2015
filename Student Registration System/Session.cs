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

        //  Loads Controller for creating an account
        public string startCreateAccount()
        {
            this.ctr = new CreateAccountController();
            string userID =  ctr.start();

            return userID;
            //string userID = ctr.start();

            //if(userID != null)
            //{
            //    //  display home screen
            //    displayHomeScreen();
            //}
            
        }

        //  Loads Controller to register for a stage
        public void startRegisterStage()
        {
            this.ctr = new RegisterStageController(user);
            ctr.start();

        }

        public void displayHomeScreen()
        {
            using (HomeScreen screen = new HomeScreen())
            {
                System.Windows.Forms.DialogResult result = screen.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Retry)
                {
                    //startRegisterStage();
                    startCreateAccount();
                }

                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    //  Logout here
                }
            }
        }
    }
}
