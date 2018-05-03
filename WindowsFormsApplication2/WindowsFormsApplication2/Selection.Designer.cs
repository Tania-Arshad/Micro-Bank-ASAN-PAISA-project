namespace WindowsFormsApplication2
{
    partial class Selection
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
            this.cmdTransactionviapin = new System.Windows.Forms.Button();
            this.btnTrsactionviaaccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTransactionviapin
            // 
            this.cmdTransactionviapin.Location = new System.Drawing.Point(85, 39);
            this.cmdTransactionviapin.Name = "cmdTransactionviapin";
            this.cmdTransactionviapin.Size = new System.Drawing.Size(163, 23);
            this.cmdTransactionviapin.TabIndex = 0;
            this.cmdTransactionviapin.Text = "Transaction via Pin";
            this.cmdTransactionviapin.UseVisualStyleBackColor = true;
            this.cmdTransactionviapin.Click += new System.EventHandler(this.cmdTransactionviapin_Click);
            // 
            // btnTrsactionviaaccount
            // 
            this.btnTrsactionviaaccount.Location = new System.Drawing.Point(85, 120);
            this.btnTrsactionviaaccount.Name = "btnTrsactionviaaccount";
            this.btnTrsactionviaaccount.Size = new System.Drawing.Size(163, 23);
            this.btnTrsactionviaaccount.TabIndex = 1;
            this.btnTrsactionviaaccount.Text = "Transaction via Account";
            this.btnTrsactionviaaccount.UseVisualStyleBackColor = true;
            this.btnTrsactionviaaccount.Click += new System.EventHandler(this.btnTrsactionviaaccount_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.btnTrsactionviaaccount);
            this.Controls.Add(this.cmdTransactionviapin);
            this.Name = "Selection";
            this.Text = "Select Mode of Transaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdTransactionviapin;
        private System.Windows.Forms.Button btnTrsactionviaaccount;
    }
}