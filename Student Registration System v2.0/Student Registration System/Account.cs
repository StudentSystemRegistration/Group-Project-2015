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
    public class Account
    {
        //  Member Variables
        private string login;
        private string password;
        private double balance;
        private string email;
        private double diskSpace;

        private Course course;

        //  Custom Constructor
        public Account(string login, string password)
        {
            setLogin(login);
            setPassword(password);
            setBalance(0);
            setDiskSpace(0);
        }

        //  Getter Methods
        public string getLogin()
        {
            return this.login;
        }

        public string getPassword()
        {
            return this.password;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public string getEmail()
        {
            return this.email;
        }

        public double getDiskSpace()
        {
            return this.diskSpace;
        }

        public Course getCourse()
        {
            return this.course;
        }

        //  Setter Methods
        public void setLogin(string login)
        {
            this.login = login;
            this.email = this.login + "@itcarlow.ie";
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public void setDiskSpace(double diskSpace)
        {
            this.diskSpace = diskSpace;
        }

        public void setCourse(Course course)
        {
            this.course = course;
        }
    }
}
