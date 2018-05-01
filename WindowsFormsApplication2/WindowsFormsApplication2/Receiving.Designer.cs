namespace WindowsFormsApplication2
{
    partial class Receiving
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAmount = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(131, 23);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(136, 20);
            this.txtPin.TabIndex = 0;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(45, 23);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(22, 13);
            this.lblPin.TabIndex = 4;
            this.lblPin.Text = "Pin";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(131, 128);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnAmount
            // 
            this.btnAmount.Location = new System.Drawing.Point(166, 71);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(101, 23);
            this.btnAmount.TabIndex = 7;
            this.btnAmount.Text = "Get Amount";
            this.btnAmount.UseVisualStyleBackColor = true;
            this.btnAmount.Click += new System.EventHandler(this.btnAmount_Click);
            // 
            // btncomplete
            // 
            this.btncomplete.Location = new System.Drawing.Point(73, 200);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(141, 23);
            this.btncomplete.TabIndex = 8;
            this.btncomplete.Text = "Complete Transaction";
            this.btncomplete.UseVisualStyleBackColor = true;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            // 
            // Receiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtPin);
            this.Name = "Receiving";
            this.Text = "Receiving Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAmount;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.Label label1;
    }
}