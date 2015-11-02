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
    public partial class PaymentScreen : Form
    {
        private Subject[] subjects;
        private double totalCost = 0;

        public PaymentScreen(Subject[] subjects)
        {
            InitializeComponent();
            this.subjects = subjects;

            for(int index = 0; index < subjects.Length; index++)
            {
                ListViewItem lvi = new ListViewItem(subjects[index].getTitle());
                lvi.SubItems.Add(subjects[index].getFee().ToString());
                lvSubjects.Items.Add(lvi);

                //  Calculate total fee
                totalCost += subjects[index].getFee();
            }

            //  Update label with total fee
            tbTotalCost.Text = totalCost.ToString();
            
            
        }

        private void CalculateFees_Load(object sender, EventArgs e)
        {

        }

        private void payForFees_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert your credit card...");

            string ccn = "1234567890";
            string pin = "1234";

            PaymentSystem ps = new PaymentSystem();
            if(ps.makePayment(ccn, pin, totalCost))
            {
                MessageBox.Show("Fees Successfully Paid For!");
                this.Close();
            }
        }

        public double getTotalCost()
        {
            return this.totalCost;
        }
    }
}
