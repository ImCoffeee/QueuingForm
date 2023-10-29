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
using static QueuingForm.QueuingForm;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
