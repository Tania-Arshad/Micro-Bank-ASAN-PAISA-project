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
    public partial class View_Customer_Info : Form
    {
        public View_Customer_Info()
        {
            InitializeComponent();
        }

        private void cmdView_Click(object sender, EventArgs e)
        {
            server.Service1 myservice = new server.Service1();
            BindingSource source = new BindingSource();
            List<server.Customer> s = myservice.ListOfCustomers().ToList();
            source.DataSource = s;
            dataGridView2.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
