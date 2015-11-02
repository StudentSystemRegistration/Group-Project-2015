namespace Student_Registration_System
{
    partial class PaymentScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.payForFees = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.lvSubjects = new System.Windows.Forms.ListView();
            this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payForFees
            // 
            this.payForFees.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.payForFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payForFees.Location = new System.Drawing.Point(191, 317);
            this.payForFees.Name = "payForFees";
            this.payForFees.Size = new System.Drawing.Size(263, 48);
            this.payForFees.TabIndex = 0;
            this.payForFees.Text = "Pay Fees";
            this.payForFees.UseVisualStyleBackColor = true;
            this.payForFees.Click += new System.EventHandler(this.payForFees_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Amount:";
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCost.Location = new System.Drawing.Point(352, 279);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(102, 32);
            this.tbTotalCost.TabIndex = 16;
            // 
            // lvSubjects
            // 
            this.lvSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSubject,
            this.chCost});
            this.lvSubjects.FullRowSelect = true;
            this.lvSubjects.GridLines = true;
            this.lvSubjects.Location = new System.Drawing.Point(6, 42);
            this.lvSubjects.Name = "lvSubjects";
            this.lvSubjects.Size = new System.Drawing.Size(448, 231);
            this.lvSubjects.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSubjects.TabIndex = 17;
            this.lvSubjects.UseCompatibleStateImageBehavior = false;
            this.lvSubjects.View = System.Windows.Forms.View.Details;
            // 
            // chSubject
            // 
            this.chSubject.Text = "Subject Title";
            this.chSubject.Width = 350;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSubjects);
            this.groupBox1.Controls.Add(this.tbTotalCost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.payForFees);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 371);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stage Fee";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRS Pay Fees";
            this.Load += new System.EventHandler(this.CalculateFees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button payForFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.ListView lvSubjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader chSubject;
        private System.Windows.Forms.ColumnHeader chCost;
    }
}