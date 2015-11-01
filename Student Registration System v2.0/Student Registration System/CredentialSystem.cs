using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
    class CredentialSystem
    {
        private Dictionary<string, string[]> studentCollection;

        public CredentialSystem()
        {
            studentCollection = new Dictionary<string, string[]>();
            studentCollection.Add("C00160133", new string[6] { "C00160133", "Paul Dunne", "Disneyland", "CW_KCSOF_B", "05/11/2015", "123456789" });
            //studentCollection.Add("C00123456", new string[6] { "C00123456", "Joe Doe", "Sesame Street", "CW_KCSOF_D", "01/01/2142", "332849324" });
            //studentCollection.Add("C00123456", new string[6] { "C00123456", "Joe Doe", "Sesame Street", "CW_KCSOF_D", "01/01/2142", "332849324" });
            studentCollection.Add("C00170343", new string[6] { "C00170343", "Elvis Porebski", "The Moon", "CW_KCSOF_B", "06/04/1987", "432445982" });
        }

        // Getter for getting a student
        public string[] getInfo(string appId)
        {
            string[] studentInfo;
            if(studentCollection.TryGetValue(appId, out studentInfo))
            {
                return studentInfo;
            }
            return null;
        }
    }
}
