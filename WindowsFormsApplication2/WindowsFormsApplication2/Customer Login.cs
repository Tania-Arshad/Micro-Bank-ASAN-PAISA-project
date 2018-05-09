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
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool IsValid;
            bool IsValidaccess;
            server.IsValidCustomer(txtUserName.Text, txtPassword.Text, out IsValid, out IsValidaccess);
                if(IsValid)
                {
                    Customer form = new Customer();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show ("InValid Customer");
                }
        }

        private void Customer_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
