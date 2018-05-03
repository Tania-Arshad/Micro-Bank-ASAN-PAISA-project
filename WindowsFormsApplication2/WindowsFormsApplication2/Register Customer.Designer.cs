namespace WindowsFormsApplication2
{
    partial class Register_Customer
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.CNIC = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(159, 13);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(159, 80);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtCNIC.TabIndex = 2;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(159, 122);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(100, 20);
            this.txtContactNo.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(46, 13);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "UserName";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(46, 39);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // CNIC
            // 
            this.CNIC.AutoSize = true;
            this.CNIC.Location = new System.Drawing.Point(46, 87);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(32, 13);
            this.CNIC.TabIndex = 6;
            this.CNIC.Text = "CNIC";
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Location = new System.Drawing.Point(46, 125);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(58, 13);
            this.ContactNo.TabIndex = 7;
            this.ContactNo.Text = "ContactNo";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(173, 232);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 8;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Location = new System.Drawing.Point(12, 232);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(33, 13);
            this.lnkLogin.TabIndex = 9;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "Login";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.Location = new System.Drawing.Point(12, 272);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(49, 13);
            this.lnkGoBack.TabIndex = 10;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go Back";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(159, 148);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 20);
            this.txtAccount.TabIndex = 11;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(159, 189);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Account_No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Amount in Account";
            // 
            // Register_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lnkGoBack);
            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "Register_Customer";
            this.Text = "Register_Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label CNIC;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.LinkLabel lnkLogin;
        private System.Windows.Forms.LinkLabel lnkGoBack;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}