namespace Student_Registration_System
{
    partial class createAccount
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
            this.returnToRegMenu = new System.Windows.Forms.Button();
            this.appNum = new System.Windows.Forms.TextBox();
            this.checkCredentials = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnToRegMenu
            // 
            this.returnToRegMenu.Location = new System.Drawing.Point(23, 205);
            this.returnToRegMenu.Name = "returnToRegMenu";
            this.returnToRegMenu.Size = new System.Drawing.Size(75, 23);
            this.returnToRegMenu.TabIndex = 7;
            this.returnToRegMenu.Text = "Return";
            this.returnToRegMenu.UseVisualStyleBackColor = true;
            this.returnToRegMenu.Click += new System.EventHandler(this.returnToRegMenu_Click);
            // 
            // appNum
            // 
            this.appNum.Location = new System.Drawing.Point(36, 102);
            this.appNum.Name = "appNum";
            this.appNum.Size = new System.Drawing.Size(136, 20);
            this.appNum.TabIndex = 6;
            this.appNum.TextChanged += new System.EventHandler(this.appNum_TextChanged);
            // 
            // checkCredentials
            // 
            this.checkCredentials.Location = new System.Drawing.Point(178, 100);
            this.checkCredentials.Name = "checkCredentials";
            this.checkCredentials.Size = new System.Drawing.Size(71, 23);
            this.checkCredentials.TabIndex = 5;
            this.checkCredentials.Text = "Submit";
            this.checkCredentials.UseVisualStyleBackColor = true;
            this.checkCredentials.Click += new System.EventHandler(this.checkCredentials_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter your unique application number";
            // 
            // createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.returnToRegMenu);
            this.Controls.Add(this.appNum);
            this.Controls.Add(this.checkCredentials);
            this.Controls.Add(this.label1);
            this.Name = "createAccount";
            this.Text = "createAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToRegMenu;
        private System.Windows.Forms.TextBox appNum;
        private System.Windows.Forms.Button checkCredentials;
        private System.Windows.Forms.Label label1;
    }
}