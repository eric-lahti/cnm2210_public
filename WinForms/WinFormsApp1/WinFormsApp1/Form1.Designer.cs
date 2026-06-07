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
            btnShow.Location = new Point(388, 126);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show It!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Name = "Form1";
            Text = "WinForms Demo!";
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
    }
}
