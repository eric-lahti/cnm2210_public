namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            btnShow = new Button();
            gbMajor = new GroupBox();
            lblMajor = new Label();
            rbSoftware = new RadioButton();
            rbUBW = new RadioButton();
            rbSpeechComm = new RadioButton();
            rbEnrolled = new RadioButton();
            rbNotEnrolled = new RadioButton();
            gbMajor.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 9);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(96, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(154, 6);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(346, 31);
            txtStudentID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(154, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(346, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(154, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(346, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 46);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 83);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(388, 300);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show It!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // gbMajor
            // 
            gbMajor.Controls.Add(rbSpeechComm);
            gbMajor.Controls.Add(rbUBW);
            gbMajor.Controls.Add(rbSoftware);
            gbMajor.Location = new Point(159, 125);
            gbMajor.Name = "gbMajor";
            gbMajor.Size = new Size(341, 147);
            gbMajor.TabIndex = 7;
            gbMajor.TabStop = false;
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(12, 125);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(109, 25);
            lblMajor.TabIndex = 8;
            lblMajor.Text = "Select Major";
            // 
            // rbSoftware
            // 
            rbSoftware.AutoSize = true;
            rbSoftware.Location = new Point(14, 24);
            rbSoftware.Name = "rbSoftware";
            rbSoftware.Size = new Size(219, 29);
            rbSoftware.TabIndex = 0;
            rbSoftware.TabStop = true;
            rbSoftware.Text = "Software Development";
            rbSoftware.UseVisualStyleBackColor = true;
            // 
            // rbUBW
            // 
            rbUBW.AutoSize = true;
            rbUBW.Location = new Point(14, 59);
            rbUBW.Name = "rbUBW";
            rbUBW.Size = new Size(257, 29);
            rbUBW.TabIndex = 1;
            rbUBW.TabStop = true;
            rbUBW.Text = "Underwater Basket Weaving";
            rbUBW.UseVisualStyleBackColor = true;
            // 
            // rbSpeechComm
            // 
            rbSpeechComm.AutoSize = true;
            rbSpeechComm.Location = new Point(14, 94);
            rbSpeechComm.Name = "rbSpeechComm";
            rbSpeechComm.Size = new Size(225, 29);
            rbSpeechComm.TabIndex = 2;
            rbSpeechComm.TabStop = true;
            rbSpeechComm.Text = "Speech Communication";
            rbSpeechComm.UseVisualStyleBackColor = true;
            // 
            // rbEnrolled
            // 
            rbEnrolled.AutoSize = true;
            rbEnrolled.Location = new Point(601, 148);
            rbEnrolled.Name = "rbEnrolled";
            rbEnrolled.Size = new Size(101, 29);
            rbEnrolled.TabIndex = 9;
            rbEnrolled.TabStop = true;
            rbEnrolled.Text = "Enrolled";
            rbEnrolled.UseVisualStyleBackColor = true;
            // 
            // rbNotEnrolled
            // 
            rbNotEnrolled.AutoSize = true;
            rbNotEnrolled.Location = new Point(601, 184);
            rbNotEnrolled.Name = "rbNotEnrolled";
            rbNotEnrolled.Size = new Size(136, 29);
            rbNotEnrolled.TabIndex = 10;
            rbNotEnrolled.TabStop = true;
            rbNotEnrolled.Text = "Not Enrolled";
            rbNotEnrolled.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(rbNotEnrolled);
            Controls.Add(rbEnrolled);
            Controls.Add(lblMajor);
            Controls.Add(gbMajor);
            Controls.Add(btnShow);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Name = "Form1";
            Text = "WinForms Demo!";
            gbMajor.ResumeLayout(false);
            gbMajor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private Button btnShow;
        private GroupBox gbMajor;
        private Label lblMajor;
        private RadioButton rbSpeechComm;
        private RadioButton rbUBW;
        private RadioButton rbSoftware;
        private RadioButton rbEnrolled;
        private RadioButton rbNotEnrolled;
    }
}
