namespace Student_Registration_System
{
    partial class StudentDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayUserName = new System.Windows.Forms.TextBox();
            this.displayName = new System.Windows.Forms.TextBox();
            this.displayAddress = new System.Windows.Forms.TextBox();
            this.displayCourseId = new System.Windows.Forms.TextBox();
            this.displayDoB = new System.Windows.Forms.TextBox();
            this.displayPhoneNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone No:";
            // 
            // displayUserName
            // 
            this.displayUserName.Location = new System.Drawing.Point(107, 36);
            this.displayUserName.Name = "displayUserName";
            this.displayUserName.Size = new System.Drawing.Size(133, 20);
            this.displayUserName.TabIndex = 6;
            this.displayUserName.TextChanged += new System.EventHandler(this.displayUserName_TextChanged);
            // 
            // displayName
            // 
            this.displayName.Location = new System.Drawing.Point(107, 63);
            this.displayName.Name = "displayName";
            this.displayName.ReadOnly = true;
            this.displayName.Size = new System.Drawing.Size(133, 20);
            this.displayName.TabIndex = 7;
            this.displayName.TextChanged += new System.EventHandler(this.displayName_TextChanged);
            // 
            // displayAddress
            // 
            this.displayAddress.Location = new System.Drawing.Point(107, 89);
            this.displayAddress.Name = "displayAddress";
            this.displayAddress.Size = new System.Drawing.Size(133, 20);
            this.displayAddress.TabIndex = 8;
            this.displayAddress.TextChanged += new System.EventHandler(this.displayAddress_TextChanged);
            // 
            // displayCourseId
            // 
            this.displayCourseId.Location = new System.Drawing.Point(107, 115);
            this.displayCourseId.Name = "displayCourseId";
            this.displayCourseId.ReadOnly = true;
            this.displayCourseId.Size = new System.Drawing.Size(133, 20);
            this.displayCourseId.TabIndex = 9;
            this.displayCourseId.TextChanged += new System.EventHandler(this.displayCourseId_TextChanged);
            // 
            // displayDoB
            // 
            this.displayDoB.Location = new System.Drawing.Point(107, 141);
            this.displayDoB.Name = "displayDoB";
            this.displayDoB.ReadOnly = true;
            this.displayDoB.Size = new System.Drawing.Size(133, 20);
            this.displayDoB.TabIndex = 10;
            this.displayDoB.TextChanged += new System.EventHandler(this.displayDoB_TextChanged);
            // 
            // displayPhoneNo
            // 
            this.displayPhoneNo.Location = new System.Drawing.Point(107, 167);
            this.displayPhoneNo.Name = "displayPhoneNo";
            this.displayPhoneNo.Size = new System.Drawing.Size(133, 20);
            this.displayPhoneNo.TabIndex = 11;
            this.displayPhoneNo.TextChanged += new System.EventHandler(this.displayPhoneNo_TextChanged);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.displayPhoneNo);
            this.Controls.Add(this.displayDoB);
            this.Controls.Add(this.displayCourseId);
            this.Controls.Add(this.displayAddress);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.displayUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox displayUserName;
        private System.Windows.Forms.TextBox displayName;
        private System.Windows.Forms.TextBox displayAddress;
        private System.Windows.Forms.TextBox displayCourseId;
        private System.Windows.Forms.TextBox displayDoB;
        private System.Windows.Forms.TextBox displayPhoneNo;
    }
}