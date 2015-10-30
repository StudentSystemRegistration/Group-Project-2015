using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    class Session
    {
        private CreateAccountController ctr;
        private string applicationNo = "";

        public void loadCreateAccountCtr()
        {
            // Create Controller
            ctr = new CreateAccountController();
            // Start Controller
            ctr.start();
            // Session is active
            
        }

        public void sendCredentials(string appNum)
        {
            this.applicationNo = appNum;
            ctr.checkCredentials(applicationNo);
        }









    
    }
}
