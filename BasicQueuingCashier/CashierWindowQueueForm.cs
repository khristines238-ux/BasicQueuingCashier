using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

        }
        private void ListCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: leave empty or add logic if you want to do something when an item is selected
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string served = CashierClass.CashierQueue.Dequeue();
                MessageBox.Show("Now Serving: " + served);
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                MessageBox.Show("No more customers in queue!");
            }
        }

        public void DisplayCashierQueue(IEnumerable<string> cashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (string item in cashierList)
            {
                listCashierQueue.Items.Add(item);
            }
        }

        private Timer timer;

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            timer = new Timer { Interval = 1000};
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
