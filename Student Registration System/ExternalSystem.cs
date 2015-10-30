using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    class ExternalSystem
    {
        // List of Students               AppNo         Name         Address        CourseId        DoB         PhoneNo
        private string[,] student = { { "C00160133", "Paul Dunne", "Disneyland", "CW_KCSOF_B", "05/11/2015", "123456789"},
                                      { "C00123456", "Joe Doe", "Sesame Street", "CW_KCSOF_D", "01/01/2142", "332849324"},
                                      { "C00789101", "Doe Jane", "The Moon", "CW_KCSOF_B", "06/04/1987", "432445982"} 
                                    };
        // Array for Details of found student
        private string[] studentInfo = new string[6];

        // Getter for getting a student
        public string[] getInfo(string appId)
        {
            for (int i = 0; i < 3; i++)
            {
                if(student[i,0] == appId)
                {
                    studentInfo[0] = student[i, 0];
                    studentInfo[1] = student[i, 1];
                    studentInfo[2] = student[i, 2];
                    studentInfo[3] = student[i, 3];
                    studentInfo[4] = student[i, 4];
                    studentInfo[5] = student[i, 5];
                }
            }

            //TODO Add Error Handlers to print error to screen

                return studentInfo;
        }

                                    
                                          

    }
}
