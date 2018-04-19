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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void lnkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminLogin form = new adminLogin();
            this.Hide();
            form.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            Register_Customer form1 = new Register_Customer();
            this.Hide();
            form1.Show();
        }
    }
}
