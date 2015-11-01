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
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class SessionScreen : Form
    {
        //  Member Variables
        private Session s;

        public SessionScreen()
        {
            s = new Session();
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnCA_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            //  Start Create Account Use Case
            string userID = s.startCreateAccount();

            if(userID != null)
            {
                MessageBox.Show("Account successfully created, please log in to activate it...");
            }
            else
            {
                MessageBox.Show("Failed to create an account, something went wrong...");
            }
            
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = this.tbPassword.Text;
            string login = this.tbUsername.Text;

            if(areValid(login, password))
            {
                MessageBox.Show("Logging In..");
                this.Hide();

                HomeScreen screen = new HomeScreen();
                screen.ShowDialog();

                switch (screen.action)
                {
                    case "registerStage":
                        s.startRegisterStage();
                        break;
                    case "topup":
                        MessageBox.Show("topup");
                        break;
                    default:
                        this.Close();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Wrong credentials, try again.");
            }
        }

        private void testingCA()
        {
            Account a = Program.getAccount(this.tbUsername.Text);
            if (a != null)
            {
                Student s = Program.getStudent("Elvis Porebski");
                MessageBox.Show(a.getPassword() + " - " + s.getStudentID());
            }
        }

        private bool areValid(string username, string password)
        {
            //  For debugging purpose
            //Account a = Program.getAccount("C00170343");
            //s.setAccount(a);
            //return true;

            Account a = Program.getAccount(username);
            //  If account exists
            if (a != null)
            {
                //  Check password
                if (string.Equals(a.getPassword(), password))
                {
                    s.setAccount(a);
                    return true;
                }
            }
            
            //  Wrong Credentials
            return false;
        }
    }
}
