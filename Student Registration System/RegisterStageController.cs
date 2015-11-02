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
        private Subject[] subjects;
        private int nextYear;
        private Course c;

        public RegisterStageController(Account account)
        {
            this.account = account;
        }

        public override string start()
        {
            c = account.getCourse();
            nextYear = c.getNextStageID();

            //  Display new stage details and ask for optional
            StageDetailsScreen screen = new StageDetailsScreen(c);

            //  Pick Optional
            if (screen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //  Set both mandatory and chosen optional subjects
                this.subjects = screen.getSelectedSubjects();

                //  Calculate fees, ask for payment and pay 
                

                PaymentScreen studentFees = new PaymentScreen(subjects);
                if(studentFees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StagePayment p = new StagePayment();
                    p.setAmount(studentFees.getTotalCost());

                    registerStage(p);
                    return "ok";
                }
            }
            return null;
        }

        private void registerStage(StagePayment p)
        {
            c.progressToNextStage(nextYear, subjects, p);
            double diskSpace = calculateDiskSpace(subjects);
            account.setDiskSpace(diskSpace);
            account.setCourse(c);
            Program.updateStudentAccount(account);
        }

        private double calculateDiskSpace(Subject[] subjects)
        {
            double diskSpace = 0;

            for(int index=0; index < subjects.Length; index++)
            {
                diskSpace += subjects[index].getDiskSpace();
            }

            return diskSpace;
        }
    }
}