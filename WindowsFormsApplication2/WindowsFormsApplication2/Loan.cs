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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {

        }

        private void cmdenter_Click(object sender, EventArgs e)
        {
            server.Service1 srvc = new server.Service1();
            srvc.Loan(txtamount.Text, txtdate.Text);
            MessageBox.Show("amount has been transfered to your account");
        }
    }
}
