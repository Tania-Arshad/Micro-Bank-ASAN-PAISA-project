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
    public partial class Transaction_via_account : Form
    {
        public Transaction_via_account()
        {
            InitializeComponent();
        }

        private void cmdEnter_Click(object sender, EventArgs e)
        {
            server.Service1 srvc = new server.Service1();
            srvc.TransactionViaAccount(txtDAccount.Text, txtCAccount.Text, txtAmount.Text);
            MessageBox.Show("completed");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_via_account_Load(object sender, EventArgs e)
        {

        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer form = new Customer();
            this.Hide();
            form.Show();
        }
    }
}
