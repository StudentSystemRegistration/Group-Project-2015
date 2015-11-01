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

        //private StagePayment stageFee;
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

        //public double getStageFee()
        //{
        //    return this.stageFee;
        //}

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

        //public void setStageFee()
        //{

        //}

        public void setSubjects(Subject[] subjects)
        {
            this.subjects = subjects;
        }


        //// getOptionalSubjects
        //public Subject[] getOptionalSubjects()
        //{
        //    Subject[] optSubjects = new Subject[2];
        //    int subjectCount = 0;

        //    for (int i = 0; i < subjects.Length; ++i)
        //    {
        //        if (subjects[i].isOptional())
        //        {
        //            optSubjects[subjectCount] = subjects[i];
        //            subjectCount++;
        //        }
        //    }
        //    return optSubjects;
        //}

        //// calculateFee
        //public double calculateFee()
        //{
        //    double fee = 0;
        //    for(int i = 0; i < subjects.Length; ++i)
        //    {
        //        if(subjects[i].isOptional() == false)
        //        {
        //            fee += subjects[i].getFee();
        //        }

        //    }
        //    return fee;
        //}

        //// calculateDiskSpace
        //public double calculateDiskSpace()
        //{
        //    double diskSpace = 0;
        //    for (int i = 0; i < subjects.Length; ++i)
        //    {
        //        diskSpace += subjects[i].getDiskSpace();
        //    }
        //    return diskSpace;
        //}
    }
}

