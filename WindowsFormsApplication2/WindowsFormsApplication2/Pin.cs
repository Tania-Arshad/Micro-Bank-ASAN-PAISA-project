using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetPin_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int number = rndm.Next(1000,9999);
            txtGetPin.Text = number.ToString();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncmplt_Click(object sender, EventArgs e)
        {
            server.Service1 srvc = new server.Service1();
            srvc.make_transaction(txtGetPin.Text, txtAmount.Text);
            MessageBox.Show("Transaction Completed");
        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Selection form = new Selection();
            this.Hide();
            form.Show();
        }
    }
}
