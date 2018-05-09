namespace WindowsFormsApplication2
{
    partial class Transaction_via_account
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
            this.txtDAccount = new System.Windows.Forms.TextBox();
            this.txtCAccount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtDAccount
            // 
            this.txtDAccount.Location = new System.Drawing.Point(153, 26);
            this.txtDAccount.Name = "txtDAccount";
            this.txtDAccount.Size = new System.Drawing.Size(100, 20);
            this.txtDAccount.TabIndex = 0;
            // 
            // txtCAccount
            // 
            this.txtCAccount.Location = new System.Drawing.Point(153, 76);
            this.txtCAccount.Name = "txtCAccount";
            this.txtCAccount.Size = new System.Drawing.Size(100, 20);
            this.txtCAccount.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(153, 130);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // cmdEnter
            // 
            this.cmdEnter.Location = new System.Drawing.Point(129, 184);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(124, 23);
            this.cmdEnter.TabIndex = 3;
            this.cmdEnter.Text = "Complete Transaction";
            this.cmdEnter.UseVisualStyleBackColor = true;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Debitor Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Creditor Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Amount";
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.Location = new System.Drawing.Point(13, 193);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(49, 13);
            this.lnkGoBack.TabIndex = 7;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go Back";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // Transaction_via_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lnkGoBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEnter);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCAccount);
            this.Controls.Add(this.txtDAccount);
            this.Name = "Transaction_via_account";
            this.Text = "Transaction_via_account";
            this.Load += new System.EventHandler(this.Transaction_via_account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDAccount;
        private System.Windows.Forms.TextBox txtCAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkGoBack;
    }
}