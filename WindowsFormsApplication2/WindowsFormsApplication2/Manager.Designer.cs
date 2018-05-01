namespace WindowsFormsApplication2
{
    partial class Admin
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
            this.cmdRegister_Customer = new System.Windows.Forms.Button();
            this.cmdData = new System.Windows.Forms.Button();
            this.lnkSignOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmdRegister_Customer
            // 
            this.cmdRegister_Customer.Location = new System.Drawing.Point(63, 29);
            this.cmdRegister_Customer.Name = "cmdRegister_Customer";
            this.cmdRegister_Customer.Size = new System.Drawing.Size(157, 28);
            this.cmdRegister_Customer.TabIndex = 0;
            this.cmdRegister_Customer.Text = "Register_Customer";
            this.cmdRegister_Customer.UseVisualStyleBackColor = true;
            this.cmdRegister_Customer.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // cmdData
            // 
            this.cmdData.Location = new System.Drawing.Point(63, 94);
            this.cmdData.Name = "cmdData";
            this.cmdData.Size = new System.Drawing.Size(157, 23);
            this.cmdData.TabIndex = 1;
            this.cmdData.Text = "Data";
            this.cmdData.UseVisualStyleBackColor = true;
            this.cmdData.Click += new System.EventHandler(this.cmdData_Click);
            // 
            // lnkSignOut
            // 
            this.lnkSignOut.AutoSize = true;
            this.lnkSignOut.Location = new System.Drawing.Point(103, 158);
            this.lnkSignOut.Name = "lnkSignOut";
            this.lnkSignOut.Size = new System.Drawing.Size(48, 13);
            this.lnkSignOut.TabIndex = 2;
            this.lnkSignOut.TabStop = true;
            this.lnkSignOut.Text = "Sign Out";
            this.lnkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignOut_LinkClicked);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lnkSignOut);
            this.Controls.Add(this.cmdData);
            this.Controls.Add(this.cmdRegister_Customer);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegister_Customer;
        private System.Windows.Forms.Button cmdData;
        private System.Windows.Forms.LinkLabel lnkSignOut;
    }
}