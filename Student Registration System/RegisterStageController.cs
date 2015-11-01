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
    public class RegisterStageController : Controller
    {
        //  Member Variables
        private Account account;

        public RegisterStageController(Account account)
        {
            this.account = account;
        }

        public override string start()
        {
            Course c = account.getCourse();
            int nextYear = c.getNextStageID();

            StageDetailsScreen screen = new StageDetailsScreen(c);
            screen.Show();
            return null;
        }


    }
}