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
    public class Subject
    {
        //  Member Variables
        private string title;
        private int nbrWeeks;
        private bool optional;
        private double diskSpace;
        private double fee;

        //  Custom Constructor
        public Subject(string title, int nbrWeeks, bool optional, double diskSpace, double fee)
        {
            setTitle(title);
            setNbrWeeks(nbrWeeks);
            setOptional(optional);
            setDiskSpace(diskSpace);
            setFee(fee);
        }

        //  Getter Methods
        public string getTitle()
        {
            return this.title;
        }

        public int getNbrWeeks()
        {
            return this.nbrWeeks;
        }

        public double getDiskSpace()
        {
            return this.diskSpace;
        }

        public double getFee()
        {
            return this.fee;
        }

        // Check if subject is optional
        public bool isOptional()
        {
            return optional;
        }

        //  Setter Methods
        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setNbrWeeks(int nbrWeeks)
        {
            this.nbrWeeks = nbrWeeks;
        }

        public void setOptional(bool optional)
        {
            this.optional = optional;
        }

        public void setDiskSpace(double diskSpace)
        {
            this.diskSpace = diskSpace;
        }

        public void setFee(double fee)
        {
            this.fee = fee;
        }
    }
}

