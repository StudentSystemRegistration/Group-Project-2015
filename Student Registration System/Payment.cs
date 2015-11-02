/*
Authors:    Brian Discin
            Paul Dunne
            Eddy Fakhry
            Declan Murphy
            Elvis Porebski   
Date:       01-11-15
Purpose:    Student Registration System
*/
using System;

namespace Student_Registration_System
{
    public abstract class Payment
    {
        private double amount;
        private DateTime timestamp;

        public Payment()
        {
            timestamp = DateTime.Now;
        }

        //  Getter Methods
        public double getAmount()
        {
            return this.amount;
        }

        public DateTime getTimestamp()
        {
            return this.timestamp;
        }

        //  Setter Methods
        public void setAmount(double amount)
        {
            this.amount = amount;
        }
    }
}