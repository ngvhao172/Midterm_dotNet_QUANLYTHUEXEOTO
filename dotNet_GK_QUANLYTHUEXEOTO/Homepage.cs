using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_GK_QUANLYTHUEXEOTO
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            UC_Homepage uc = new UC_Homepage();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            UC_Homepage uc = new UC_Homepage();
            addUserControl(uc);
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            UC_CarTypeSelection uc = new UC_CarTypeSelection();
            addUserControl(uc);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            UC_ScheduleManagement uc = new UC_ScheduleManagement();
            addUserControl(uc);
        }

        private void btnCarOrders_Click(object sender, EventArgs e)
        {
            UC_CarBookingsManagement uc = new UC_CarBookingsManagement();
            addUserControl(uc);
        }

        private void btnCarManagement_Click(object sender, EventArgs e)
        {
            UC_CarManagement uc = new UC_CarManagement();
            addUserControl(uc);
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            UC_CustomerManagement uc = new UC_CustomerManagement();
            addUserControl(uc);
        }

        private void btnReportAndStatistic_Click(object sender, EventArgs e)
        {
            UC_ReportAndStatistic uc = new UC_ReportAndStatistic();
            addUserControl(uc);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            using (var dbContext = new BookingCarDbContext())
            {
                dbContext.Database.EnsureCreated();

                dbContext.SaveChanges();
            }

        }
    }
}
