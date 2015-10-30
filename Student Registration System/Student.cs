using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    class Student
    {
        // Variables of Student Collection
        private string applicationNo = "";
        private string name = "";
        private string address = "";
        private string password = "";
        private string courseId = "";
        private string dob = "";
        private string phoneNo = "";
        // Array to hold Collection to be returned
        private string[] studentData = new string[7];

        // and pass in data
        public Student(string appNo, string name, string address, string courseId, string dob, string phoneNo, string password)
        {
            this.setAppNo(appNo);
            this.setName(name);
            this.setAddress(address);
            this.setCourseId(courseId);
            this.setDob(dob);
            this.setPhoneNo(phoneNo);
            this.setPassword(password);
        }

        // Setters
        private void setAppNo(string appNo)
        {
            this.applicationNo = appNo;
            this.studentData[0] = appNo;
        }

        private void setName(string name)
        {
            this.name = name;
            this.studentData[1] = name;
        }

        public void setAddress(string a)
        {
            this.address = a;
            this.studentData[2] = a;
        }

        public void setCourseId(string id)
        {
            this.courseId = id;
            this.studentData[3] = id;
        }

        private void setDob(string d)
        {
            this.dob = d;
            this.studentData[4] = d;
        }

        public void setPhoneNo(string n)
        {
            this.phoneNo = n;
            this.studentData[5] = n;
        }

        public void setPassword(string p)
        {
            this.password = p;
            this.studentData[6] = p;
        }

        // Get Student Data Collection
        public string[] getStudent()
        {
            return studentData;
        }
           
        
    }
}
