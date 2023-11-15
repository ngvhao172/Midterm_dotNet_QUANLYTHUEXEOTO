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
    public partial class UC_CarBookingsManagement : UserControl
    {
        private BookingController bookingController;
        public UC_CarBookingsManagement()
        {
            InitializeComponent();
            this.bookingController = App.ServiceProvider.GetRequiredService<BookingController>();
        }
        
        private void UC_CarBookingsManagement_Load(object sender, EventArgs e)
        {
            
            var bookingList = bookingController.GetAllBookings();

            foreach (var booking in bookingList)
            {
                dgvBookings.Rows.Add(booking.Id, booking.Customer.FullName, booking.Customer.PhoneNumber, booking.Customer.CustomerEmail, booking.Customer.Address, booking.Car.CarType.Name, booking.CarId, booking.FromDate.ToShortDateString(), booking.ToDate.ToShortDateString());
            }
            /*disableInput(false);*/
        }
        private void disableInput(bool b)
        {
            txtFullName.Enabled= b;
            txtAddress.Enabled= b;
            txtEmail.Enabled= b;
            txtCarId.Enabled= b;
            txtPhoneNumber.Enabled= b;
            txtToDate.Enabled= b;
            txtFromDate.Enabled= b;
            txtCarType.Enabled= b;
     /*       btnAdd.Enabled= b;
            btnDelete.Enabled= b;
            btnEdit.Enabled= b;*/
        }
        private void dgvBookings_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBookings.Rows[e.RowIndex];

                txtFullName.Text = selectedRow.Cells[1].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells[2].Value.ToString();
                txtEmail.Text = selectedRow.Cells[3].Value.ToString();
                txtAddress.Text = selectedRow.Cells[4].Value.ToString();
                txtCarType.Text = selectedRow.Cells[5].Value.ToString();
                txtCarId.Text = selectedRow.Cells[6].Value.ToString();
                txtFromDate.Text = selectedRow.Cells[7].Value.ToString();
                txtToDate.Text = selectedRow.Cells[8].Value.ToString();
            }
        }

        private void txtPhoneNumberSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPhoneNumberSearch.Text.Trim().ToLower();
            List<Booking> searchResults = new List<Booking>();

            var bookingList = bookingController.GetAllBookings();

            if (keyword.Length > 0)
            {
                foreach (Booking booking in bookingList)
                {
                    if (booking.Customer.PhoneNumber.Contains(keyword) || booking.Customer.FullName.ToLower().Contains(keyword) || booking.CarId.ToLower().Contains(keyword))
                    {
                        searchResults.Add(booking);
                    }
                }
                dgvBookings.Rows.Clear();
                foreach (var booking in searchResults)
                {
                    dgvBookings.Rows.Add(booking.Id, booking.Customer.FullName, booking.Customer.PhoneNumber, booking.Customer.CustomerEmail, booking.Customer.Address, booking.Car.CarType.Name, booking.CarId, booking.FromDate.ToShortDateString(), booking.ToDate.ToShortDateString());
                }
            }
            else
            {
                dgvBookings.Rows.Clear();
                foreach (var booking in bookingList)
                {
                    dgvBookings.Rows.Add(booking.Id, booking.Customer.FullName, booking.Customer.PhoneNumber, booking.Customer.CustomerEmail, booking.Customer.Address, booking.Car.CarType.Name, booking.CarId, booking.FromDate.ToShortDateString(), booking.ToDate.ToShortDateString());
                }
            }
        }
        //Ngăn chặn người dùng thay đổi input
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
