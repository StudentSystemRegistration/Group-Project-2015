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
    public abstract class Person
    {
        //  Member Variables
        private string name;
        private string address;
        private string dob;
        private string phone;

        //  Getter Methods
        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public string getDob()
        {
            return dob;
        }

        public string getPhone()
        {
            return phone;
        }

        //  Setter Methods
        public void setName(string name)
        {
            this.name = name;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }
    }
}
