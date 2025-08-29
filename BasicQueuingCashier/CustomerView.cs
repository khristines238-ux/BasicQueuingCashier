using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView: Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }
        public void UpdateServing(string number)
        {
            label2.Text = number;
        }
        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
    }
}
