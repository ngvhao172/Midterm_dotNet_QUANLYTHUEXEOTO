using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    public partial class UC_UserInfo : UserControl
    {
        public string CarType { get; set; }
        public Booking Booking { get; set; }

        private CustomerController customerController;

        private BookingController bookingController;

        private CarController carController;
        public UC_UserInfo()
        {
            this.customerController = App.ServiceProvider.GetRequiredService<CustomerController>();
            this.bookingController = App.ServiceProvider.GetRequiredService<BookingController>();
            this.carController = App.ServiceProvider.GetRequiredService<CarController>();
            InitializeComponent();
        }
        private void UC_UserInfo_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = customerController.GetAllCustomer();
            /* foreach (Customer customer in customerList)
             {
                 dgvCustomers.Rows.Add(customer.FullName, customer.PhoneNumber, customer.CustomerEmail, customer.Address, customer.Dob.Date);
             }*/
            dgvCustomers.DataSource = customerList;

            txtCarId.Text = Booking.CarId;
            txtCarId.Enabled= false;
            txtCarType.Text = CarType.ToString();
            txtCarType.Enabled= false;
        }
        private void addUserControl(UserControl userControl, Control panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private bool validateInfo()
        {
            if(txtFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                return false;
            }
            if(txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email khách hàng");
                return false;
            }
            if(txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng");
                return false;
            }
            if (txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                return false;
            }
            if(dtpDob.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh khách hàng");
                return false;
            }
            return true;
        }
        private async void btnRentCar_Click(object sender, EventArgs e)
        {
            if(validateInfo())
            {
                Customer existedCustomer = await customerController.GetCustomerByPhoneNumber(txtPhoneNumber.Text.Trim());
                if(existedCustomer == null)
                {
                    //Tạo Customer nếu chưa tồn tại
                    Customer newCustomer = new Customer { FullName = txtFullName.Text.ToString(), CustomerEmail = txtEmail.Text.ToString(), Address = txtAddress.Text.ToString(), PhoneNumber = txtPhoneNumber.Text.ToString(), Dob = dtpDob.Value };

                    await customerController.AddCustomer(newCustomer);
                    //
                    Booking.CustomerId = newCustomer.CustomerId;
                    await bookingController.AddBooking(Booking);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Số điện thoại đã được đăng ký trước đó. Hệ thống sẽ lấy thông tin cũ của bạn. Bạn có chắc chắn muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Booking.CustomerId = existedCustomer.CustomerId;
                        await bookingController.AddBooking(Booking);
                    }
                    else
                    {
                        return;
                    }
                }
                Car carSelected = await carController.GetCarById(Booking.CarId);
                if (carSelected != null)
                {
                    carSelected.Status = Model.Enum.CarStatus.Busy;
                    carController.UpdateCar(carSelected);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra. Không thể cập nhật trạng thái xe");
                    return;
                }
                MessageBox.Show("Tạo đơn thuê xe thành công");

                Button clickedButon = sender as Button;

                if (clickedButon != null && clickedButon.Parent != null)
                {
                    UserControl userControl = clickedButon.Parent as UserControl;
                    if (userControl != null)
                    {
                        Panel panelContaner = userControl.Parent as Panel;
                        if (panelContaner != null)
                        {
                            UC_CarBookingsManagement uc = new UC_CarBookingsManagement();
                            addUserControl(uc, panelContaner);
                        }
                    }
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Button clickedButon = sender as Button;

            if (clickedButon != null && clickedButon.Parent != null)
            {
                UserControl userControl = clickedButon.Parent as UserControl;
                if (userControl != null)
                {
                    Panel panelContaner = userControl.Parent as Panel;
                    if (panelContaner != null)
                    {
                        UC_RentCar uc = new UC_RentCar();
                        uc.CarType = CarType;
                        addUserControl(uc, panelContaner);
                    }
                }
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCustomers.Rows[e.RowIndex];

                txtFullName.Text = selectedRow.Cells[2].Value.ToString() ;
                txtPhoneNumber.Text = selectedRow.Cells[3].Value.ToString();
                txtEmail.Text = selectedRow.Cells[1].Value.ToString();
                txtAddress.Text = selectedRow.Cells[4].Value.ToString();
                DateTime dateValue;
                if (DateTime.TryParseExact(selectedRow.Cells[5].Value.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                {
                    dtpDob.Value = dateValue;
                }
                else
                {
                    dtpDob.Value = new DateTime(2003, 07,12);
                }
            }
        }

        private void txtSearchPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchPhoneNumber.Text.Trim().ToLower();
            List<Customer> searchResults = new List<Customer>();

            List<Customer> customerList = customerController.GetAllCustomer();
            if(keyword.Length > 0)
            {
                foreach (Customer customer in customerList)
                {
                    if (customer.PhoneNumber.Contains(keyword) || customer.FullName.ToLower().Contains(keyword) || customer.Address.ToLower().Contains(keyword))
                    {
                        searchResults.Add(customer);
                    }
                }
                dgvCustomers.DataSource = searchResults;
            }
            else
            {
                dgvCustomers.DataSource = customerList;
            }
           
        }
    }
}
