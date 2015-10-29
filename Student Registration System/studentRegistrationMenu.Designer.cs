namespace Student_Registration_System
{
    partial class studentRegistrationMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.existingStudent = new System.Windows.Forms.Button();
            this.startCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please select your student status to register:";
            // 
            // existingStudent
            // 
            this.existingStudent.Location = new System.Drawing.Point(92, 149);
            this.existingStudent.Name = "existingStudent";
            this.existingStudent.Size = new System.Drawing.Size(98, 23);
            this.existingStudent.TabIndex = 7;
            this.existingStudent.Text = "Existing Student";
            this.existingStudent.UseVisualStyleBackColor = true;
            // 
            // startCreateAccount
            // 
            this.startCreateAccount.Location = new System.Drawing.Point(92, 120);
            this.startCreateAccount.Name = "startCreateAccount";
            this.startCreateAccount.Size = new System.Drawing.Size(98, 23);
            this.startCreateAccount.TabIndex = 6;
            this.startCreateAccount.Text = "New Student";
            this.startCreateAccount.UseVisualStyleBackColor = true;
            this.startCreateAccount.Click += new System.EventHandler(this.startCreateAccount_Click);
            // 
            // studentRegistrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.existingStudent);
            this.Controls.Add(this.startCreateAccount);
            this.Name = "studentRegistrationMenu";
            this.Text = "studentRegistrationMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button existingStudent;
        private System.Windows.Forms.Button startCreateAccount;
    }
}