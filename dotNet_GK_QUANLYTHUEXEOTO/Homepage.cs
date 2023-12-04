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
        public string FullName { get; set; }
        public string Email { get; set; }

        private Button buttonClicked { get; set; }

        private void setClickEvent(Button b)
        {
            b.ForeColor = Color.Snow;
            b.BackColor = Color.DarkRed;
            b.Enabled = false;
        }
        private void resetClickEvent(Button b)
        {
            if (b != null)
            {
                b.BackColor = Color.White;
                b.Enabled = true;
                b.ForeColor = Color.Black;
            }
        }
        private void clickEvent(Button b)
        {
            resetClickEvent(buttonClicked);
            buttonClicked = b;
            setClickEvent(buttonClicked);
        }

        public Homepage()
        {
            InitializeComponent();
            UC_Homepage uc = new UC_Homepage();
            addUserControl(uc);
        }
        public void UpdateFullNameLabel()
        {
            txtName.Text = "Xin chào, " + FullName;
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
            clickEvent(btnHomepage);

            UC_Homepage uc = new UC_Homepage();
            addUserControl(uc);
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            clickEvent(btnRentCar);

            UC_CarTypeSelection uc = new UC_CarTypeSelection();
            addUserControl(uc);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            clickEvent(btnSchedule);

            UC_ScheduleManagement uc = new UC_ScheduleManagement();
            addUserControl(uc);
        }

        private void btnCarOrders_Click(object sender, EventArgs e)
        {
            clickEvent(btnCarOrders);

            UC_CarBookingsManagement uc = new UC_CarBookingsManagement();
            addUserControl(uc);
        }

        private void btnCarManagement_Click(object sender, EventArgs e)
        {
            clickEvent(btnCarManagement);

            UC_CarManagement uc = new UC_CarManagement();
            uc.email = Email;
            addUserControl(uc);
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            clickEvent(btnCustomerManagement);

            UC_CustomerManagement uc = new UC_CustomerManagement();
            uc.email = Email;
            addUserControl(uc);
        }

        private void btnReportAndStatistic_Click(object sender, EventArgs e)
        {
            clickEvent(btnReportAndStatistic);

            UC_ReportAndStatistic uc = new UC_ReportAndStatistic();
            addUserControl(uc);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            /*            using (var dbContext = new BookingCarDbContext())
                        {
                            dbContext.Database.EnsureCreated();

                            dbContext.SaveChanges();
                        }*/

        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            clickEvent(btnInvoices);

            UC_Invoice uc = new UC_Invoice();
            addUserControl(uc);
        }
    }
}
