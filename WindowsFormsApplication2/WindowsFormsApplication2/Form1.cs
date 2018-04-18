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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            bool isvalid;
            bool isvalidaccess;
            server.IsValid(txtusername.Text, txtpassword.Text, out isvalid, out isvalidaccess);
            if (isvalid)
            {
                Admin admin = new Admin();
                this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("invalid user");
            }
        }
    }
}
