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
    public partial class studentRegistrationMenu : Form
    {
        public studentRegistrationMenu()
        {
            InitializeComponent();
        }

        public void startCreateAccount_Click(object sender, EventArgs e)
        {

            // Hide Registration Menu Window
            this.Hide();
            // Creates a Session
            Session s = new Session();
            // Starts the CreateAccountController which opens createAccount window
            s.loadCreateAccountCtr();
            // Close Registration Menu window
            this.Close();
       
        }
    }
}
