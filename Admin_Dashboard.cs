using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders_New
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //== Slide selected highlight command == //
            pnlSelected.Height = btnDashboard.Height;
            pnlSelected.Top = btnDashboard.Top;
        }

        

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //== Slide selected highlight command == //
            pnlSelected.Height = btnCustomer.Height;
            pnlSelected.Top = btnCustomer.Top;
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            //== Slide selected highlight command == //
            pnlSelected.Height = btnCarParts.Height;
            pnlSelected.Top = btnCarParts.Top;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            //== Slide selected highlight command == //
            pnlSelected.Height = btnServices.Height;
            pnlSelected.Top = btnServices.Top;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //== Slide selected highlight command == //
            pnlSelected.Height = btnOrders.Height;
            pnlSelected.Top = btnOrders.Top;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //== Slide selected highlight command == //
            pnlSelected.Height = btnReports.Height;
            pnlSelected.Top = btnReports.Top;
        }
    }
}
