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
    public partial class LoanView : Form
    {
        public LoanView()
        {
            InitializeComponent();
            server.Service1 srvc = new server.Service1();
            List<server.Loan> l = srvc.View_Loan().ToList();
            BindingSource source = new BindingSource();
            source.DataSource = l;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
