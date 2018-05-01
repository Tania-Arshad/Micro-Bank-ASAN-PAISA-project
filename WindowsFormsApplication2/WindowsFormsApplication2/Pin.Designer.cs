namespace WindowsFormsApplication2
{
    partial class Pin
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btncmplt = new System.Windows.Forms.Button();
            this.txtGetPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetPin = new System.Windows.Forms.Button();
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 29);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btncmplt
            // 
            this.btncmplt.Location = new System.Drawing.Point(68, 197);
            this.btncmplt.Name = "btncmplt";
            this.btncmplt.Size = new System.Drawing.Size(166, 23);
            this.btncmplt.TabIndex = 3;
            this.btncmplt.Text = "Complete Transaction";
            this.btncmplt.UseVisualStyleBackColor = true;
            this.btncmplt.Click += new System.EventHandler(this.btncmplt_Click);
            // 
            // txtGetPin
            // 
            this.txtGetPin.Location = new System.Drawing.Point(68, 116);
            this.txtGetPin.Name = "txtGetPin";
            this.txtGetPin.Size = new System.Drawing.Size(166, 20);
            this.txtGetPin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount Of Money";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGetPin
            // 
            this.btnGetPin.Location = new System.Drawing.Point(68, 68);
            this.btnGetPin.Name = "btnGetPin";
            this.btnGetPin.Size = new System.Drawing.Size(166, 23);
            this.btnGetPin.TabIndex = 2;
            this.btnGetPin.Text = "Get Pin";
            this.btnGetPin.UseVisualStyleBackColor = true;
            this.btnGetPin.Click += new System.EventHandler(this.btnGetPin_Click);
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.Location = new System.Drawing.Point(100, 155);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(49, 13);
            this.lnkGoBack.TabIndex = 6;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go Back";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.lnkGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGetPin);
            this.Controls.Add(this.btncmplt);
            this.Controls.Add(this.btnGetPin);
            this.Controls.Add(this.txtAmount);
            this.Name = "Pin";
            this.Text = "MakeTransaction via Pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btncmplt;
        private System.Windows.Forms.TextBox txtGetPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetPin;
        private System.Windows.Forms.LinkLabel lnkGoBack;
    }
}