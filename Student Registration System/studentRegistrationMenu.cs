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

        private void startCreateAccount_Click(object sender, EventArgs e)
        {
            // Hide Registration Menu Window
            this.Hide();
            // Create and createAccount window
            createAccount newUser = new createAccount();
            newUser.ShowDialog();
            // Close Registration Menu window
            this.Close();


        }
    }
}
