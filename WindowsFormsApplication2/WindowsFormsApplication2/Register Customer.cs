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
    public partial class Register_Customer : Form
    {
        public Register_Customer()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            server.registerUser(txtUserName.Text, txtPassword.Text, txtCNIC.Text, txtContactNo.Text);
            MessageBox.Show("user registered");

        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Login form = new Customer_Login();
            this.Hide();
            form.Show();
        }
    }
}
