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
    public class Student : Person
    {
        //  Member Variables
        private string studentID;

        private Account account;

        //  Custom Constructor
        public Student(string studentID)
        {
            this.studentID = studentID;
        }

        //  Getter Method
        public string getStudentID()
        {
            return this.studentID;
        }
        //  Setter Method
        public void setAccount(string studentID)
        {
            this.studentID = studentID;
        }
    }
}
