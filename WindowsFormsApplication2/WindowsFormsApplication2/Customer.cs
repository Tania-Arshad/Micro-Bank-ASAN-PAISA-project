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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer_Login form = new Customer_Login();
            this.Hide();
            form.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selection form = new Selection();
            this.Hide();
            form.Show();
        }

        private void cmdMoney_Click(object sender, EventArgs e)
        {
            Receiving form = new Receiving();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewTransaction form = new viewTransaction();
            this.Hide();
            form.Show();
        }
    }
}
