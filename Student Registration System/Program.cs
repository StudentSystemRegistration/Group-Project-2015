/*
Authors:    Brian Discin
            Paul Dunne
            Eddy Fakhry
            Declan Murphy
            Elvis Porebski   
Date:       31-10-15
Purpose:    Student Registration System
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student_Registration_System
{
    static class Program
    {
        public static Dictionary<string, Course> courseCatalog;
        public static Dictionary<string, Person> users;
        public static Dictionary<string, Account> accounts;

        //  Finds course using its course code
        public static Course getCourse(string courseCode)
        {
            //  Retrieve course from catalog using courseCode as a key
            return courseCatalog[courseCode];
        }

        public static Student getStudent(string name)
        {
            Person student;
            if (users.TryGetValue(name, out student))
            {
                return (Student)student;
            }
            return null;
        }

        public static Subject[] getSubjects(string courseCode, int stage)
        {
            return getCourse(courseCode).getStages()[stage].getSubjects();
        }

        //  Save student
        public static void addStudent(Student s)
        {
            users.Add(s.getName(), s);
        }

        //  Save Account
        public static void addAccount(Account a)
        {
            if (accounts.ContainsKey(a.getLogin()))
            {
                return;
            }
            accounts.Add(a.getLogin(), a);
        }

        //  Find account, given its login id
        public static Account getAccount(string login)
        {
            Account account;
            if (accounts.TryGetValue(login, out account))
            {
                return account;
            }
            return null;
        }

        public static void updateStudentAccount(Account a)
        {
            accounts[a.getLogin()] = a;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// Init Dictionaries
            /// 
            courseCatalog = new Dictionary<string, Course>();
            users = new Dictionary<string, Person>();
            accounts = new Dictionary<string, Account>();

            /// <summary>
            /// Create 1st set of subjects for 1st stage
            /// </summary>
            Subject[] subjects1 = new Subject[7];
            Subject mathematics = new Subject("Mathematics", 42, false, 0.50, 200);
            subjects1[0] = mathematics;
            Subject programming = new Subject("Programming", 42, false, 1.0, 200);
            subjects1[1] = programming;
            Subject applications = new Subject("Applications", 42, false, 0.50, 150);
            subjects1[2] = applications;
            Subject operatingSystems = new Subject("Operating Systems", 42, false, 0.50, 150);
            subjects1[3] = operatingSystems;
            Subject webProg = new Subject("Web Prog and Databases", 42, true, 0.25, 150);
            subjects1[4] = webProg;
            Subject computerHardware = new Subject("Computer Hardware", 42, true, 0.50, 150);
            subjects1[5] = computerHardware;
            Subject networking = new Subject("Networking", 42, true, 0.50, 100);
            subjects1[6] = networking;

            /// <summary>
            /// Create 2nd set of subjects for 2nd stage
            /// </summary>
            Subject[] subjects2 = new Subject[7];
            Subject managementAccounting = new Subject("Management Accounting", 42, false, 0.50, 200);
            subjects2[0] = managementAccounting;
            Subject sysAnalysis = new Subject("System Analysis", 42, false, 1.0, 200);
            subjects2[1] = sysAnalysis;
            Subject computerArchitecture = new Subject("Computer Architecture", 42, true, 0.50, 100);
            subjects2[2] = computerArchitecture;
            Subject mathematics2 = new Subject("Mathematics 2", 42, false, 0.50, 100);
            subjects2[3] = mathematics2;
            Subject ooProg = new Subject("Object Oriented Programming", 42, false, 0.50, 150);
            subjects2[4] = ooProg;
            Subject webProg2 = new Subject("Web Programming and Databases 2", 42, true, 0.25, 150);
            subjects2[5] = webProg2;
            Subject proj = new Subject("Project", 42, false, 0.25, 150);
            subjects2[6] = proj;

            /// <summary>
            /// Create a stage for the subjects
            /// </summary>
            Stage stage1 = new Stage(1, subjects1);
            stage1.setStatus("passed");
            Stage stage2 = new Stage(1, subjects2);

            Stage[] stages = new Stage[4];
            stages[0] = stage1;
            stages[1] = stage2;

            Course course1 = new Course("CW_KCSOF_B", "Bachelor of Science(Honours) in Software Development", "NFQ Level 8", 335, stages); 
            course1.setCurrentStageID(-1);
            courseCatalog.Add(course1.getCourseCode(), course1);


            Account account = new Account("C00170343", "1234");
            course1.setCurrentStageID(0);
            account.setBalance(0);
            account.setCourse(course1);
            account.setDiskSpace(250);

            //  For debugging purpose
            addAccount(account);

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            while (true)
            {
                Application.Run(new SessionScreen());
            }
        }
    }
}
