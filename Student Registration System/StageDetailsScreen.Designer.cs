namespace Student_Registration_System
{
    partial class StageDetailsScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCurrYear = new System.Windows.Forms.TextBox();
            this.tbCourseTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNextYear = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMandatory = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOptional = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPickOptional = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCurrYear);
            this.groupBox1.Controls.Add(this.tbCourseTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCourseCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // tbCurrYear
            // 
            this.tbCurrYear.Location = new System.Drawing.Point(108, 71);
            this.tbCurrYear.Name = "tbCurrYear";
            this.tbCurrYear.ReadOnly = true;
            this.tbCurrYear.Size = new System.Drawing.Size(30, 20);
            this.tbCurrYear.TabIndex = 6;
            // 
            // tbCourseTitle
            // 
            this.tbCourseTitle.Location = new System.Drawing.Point(108, 45);
            this.tbCourseTitle.Name = "tbCourseTitle";
            this.tbCourseTitle.ReadOnly = true;
            this.tbCourseTitle.Size = new System.Drawing.Size(345, 20);
            this.tbCourseTitle.TabIndex = 5;
            this.tbCourseTitle.TextChanged += new System.EventHandler(this.tbCourseTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(108, 19);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.ReadOnly = true;
            this.tbCourseCode.Size = new System.Drawing.Size(345, 20);
            this.tbCourseCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code:";
            // 
            // tbNextYear
            // 
            this.tbNextYear.Location = new System.Drawing.Point(108, 19);
            this.tbNextYear.Name = "tbNextYear";
            this.tbNextYear.ReadOnly = true;
            this.tbNextYear.Size = new System.Drawing.Size(30, 20);
            this.tbNextYear.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMandatory);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbOptional);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNextYear);
            this.groupBox2.Location = new System.Drawing.Point(13, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 284);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Next Stage Details";
            // 
            // cbMandatory
            // 
            this.cbMandatory.Enabled = false;
            this.cbMandatory.FormattingEnabled = true;
            this.cbMandatory.Location = new System.Drawing.Point(9, 61);
            this.cbMandatory.Name = "cbMandatory";
            this.cbMandatory.Size = new System.Drawing.Size(220, 214);
            this.cbMandatory.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mandatory Subjects:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Optional Subjects:";
            // 
            // cbOptional
            // 
            this.cbOptional.CheckOnClick = true;
            this.cbOptional.FormattingEnabled = true;
            this.cbOptional.Location = new System.Drawing.Point(233, 61);
            this.cbOptional.Name = "cbOptional";
            this.cbOptional.Size = new System.Drawing.Size(220, 214);
            this.cbOptional.TabIndex = 8;
            this.cbOptional.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbOptional_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year:";
            // 
            // btnPickOptional
            // 
            this.btnPickOptional.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPickOptional.Enabled = false;
            this.btnPickOptional.Location = new System.Drawing.Point(391, 429);
            this.btnPickOptional.Name = "btnPickOptional";
            this.btnPickOptional.Size = new System.Drawing.Size(75, 23);
            this.btnPickOptional.TabIndex = 9;
            this.btnPickOptional.Text = "Next";
            this.btnPickOptional.UseVisualStyleBackColor = true;
            this.btnPickOptional.Click += new System.EventHandler(this.btnPickOptional_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "NUMBER OF OPTIONAL SUBJECT SELECTED:";
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Location = new System.Drawing.Point(266, 434);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(24, 13);
            this.lbSelected.TabIndex = 13;
            this.lbSelected.Text = "0/3";
            // 
            // StageDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPickOptional);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StageDetailsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration System";
            this.Load += new System.EventHandler(this.StageDetailsScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCurrYear;
        private System.Windows.Forms.TextBox tbCourseTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNextYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cbMandatory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox cbOptional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPickOptional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSelected;
    }
}