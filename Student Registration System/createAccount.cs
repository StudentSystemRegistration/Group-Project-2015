using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_System
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void checkCredentials_Click(object sender, EventArgs e)
        {
            CreateAccountController ctr = new CreateAccountController();
            ctr.create();
            ctr.checkCredentials(appNum.Text);
            string tmp = ctr.getAppNum();

            if (tmp.Equals(appNum.Text)) ;
            {

            }

        }

        private void appNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnToRegMenu_Click(object sender, EventArgs e)
        {
            // Hide Login Window
            this.Hide();
            // Create and Show Menu window
            studentRegistrationMenu studentReturn = new studentRegistrationMenu();
            studentReturn.ShowDialog();
            // Close Login window
            this.Close();
        }
    }
}
