using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInforms_netframework_Hotelmngmentsys
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            movingPanel.Left = btnAddroom.Left+6;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCustomerdet.Left +30;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnEmployee.Left + 14;
        }

        private void btnCustomerreg_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCustomerreg.Left+30;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCheckout.Left+4;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible=false;

            btnAddroom.PerformClick();
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void uC_AddRoom1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
