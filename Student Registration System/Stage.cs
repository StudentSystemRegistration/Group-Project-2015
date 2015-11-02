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
    public class Stage
    {
        //  Member Variables
        private int nbrOptional;
        private string status;

        private StagePayment stagePayment;
        private Subject[] subjects;

        //  Custom Constructor
        public Stage(int nbrOptional, Subject[] subjects)
        {
            setNbrOptional(nbrOptional);
            setSubjects(subjects);
        }

        //  Getter Methods
        public int getNbrOptional()
        {
            return this.nbrOptional;
        }

        public string getStatus()
        {
            return this.status;
        }

        public StagePayment getStageFee()
        {
            return this.stagePayment;
        }

        public Subject[] getSubjects()
        {
            return this.subjects;
        }

        //  Setter Methods
        public void setNbrOptional(int nbrOptional)
        {
            this.nbrOptional = nbrOptional;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public void setStagePayment(StagePayment stagePayment)
        {
            this.stagePayment = stagePayment;
        }

        public void setSubjects(Subject[] subjects)
        {
            this.subjects = subjects;
        }
    }
}

