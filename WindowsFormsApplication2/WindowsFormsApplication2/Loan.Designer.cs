namespace WindowsFormsApplication2
{
    partial class Loan
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
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(172, 23);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 0;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(172, 76);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // cmdenter
            // 
            this.cmdenter.Location = new System.Drawing.Point(172, 128);
            this.cmdenter.Name = "cmdenter";
            this.cmdenter.Size = new System.Drawing.Size(75, 23);
            this.cmdenter.TabIndex = 4;
            this.cmdenter.Text = "Enter";
            this.cmdenter.UseVisualStyleBackColor = true;
            this.cmdenter.Click += new System.EventHandler(this.cmdenter_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtamount);
            this.Name = "Loan";
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdenter;
    }
}