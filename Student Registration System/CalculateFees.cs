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
    public partial class CalculateFees : Form
    {
        Subject[] subjects;
        private bool paymentStatus = false;

        public CalculateFees(Subject[] subs)
        {
            InitializeComponent();
            this.subjects = subs;

            sub1.Text = subjects[0].getTitle() + ":";
            sub2.Text = subjects[1].getTitle() + ":";
            sub3.Text = subjects[2].getTitle() + ":";
            sub4.Text = subjects[3].getTitle() + ":";
            sub5.Text = subjects[4].getTitle() + ":";

            sub1Cost.Text = subjects[0].getFee().ToString();
            sub2Cost.Text = subjects[1].getFee().ToString();
            sub3Cost.Text = subjects[2].getFee().ToString();
            sub4Cost.Text = subjects[3].getFee().ToString();
            sub5Cost.Text = subjects[4].getFee().ToString();
            
        }

        private void CalculateFees_Load(object sender, EventArgs e)
        {

        }

        private void payForFees_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processing Payment!");
            paymentStatus = true;

            if (paymentStatus == true)
            {
                payForFees.Enabled = false;
                MessageBox.Show("Fees Successfully Paid For!");

                SessionScreen ss = new SessionScreen();
                ss.Show();
                this.Close();
            }
        }
    }
}
