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
    public partial class Receiving : Form
    {
        public Receiving()
        {
            InitializeComponent();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAmount_Click(object sender, EventArgs e)
        {
            server.Service1 srvc = new server.Service1();
            txtAmount.Text = srvc.recieve_money_via_pin(txtPin.Text);
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "not valid pin")
            {
                MessageBox.Show("recieve respective money from shop");
            }
            else
            {
                MessageBox.Show("transaction unsuccessfull");
            }
        }

        private void Receiving_Load(object sender, EventArgs e)
        {

        }
    }
}
