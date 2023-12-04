using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    public partial class UC_InvoiceDetail : UserControl
    {
        public int BookingId { get; set; }

        private BookingController bookingController;

        public UC_InvoiceDetail()
        {
            InitializeComponent();
            this.bookingController = App.ServiceProvider.GetRequiredService<BookingController>();
        }

        private async void UC_InvoiceDetail_Load(object sender, EventArgs e)
        {
            Booking booking = await bookingController.GetBookingById(BookingId);

            txtCustomerFullName.Text = booking.Customer.FullName;
            txtPhoneNumber.Text = booking.Customer.PhoneNumber;
            txtCarId.Text = booking.CarId;
            txtCarType.Text = booking.Car.CarType.Name;

            txtRentDay.Text = booking.FromDate.ToString();
            txtPaidDay.Text = booking.ToDate.ToString();

            txtEmployee.Text = "User";
            txtCreate.Text = DateTime.Now.ToString();


            //số ngày thuê
            var Duration = booking.ToDate.Date - booking.FromDate.Date;
            int daysDifference = (int)Duration.TotalDays + 1;
            //Tiền thuê xe = tiền xe * số ngày thuê
            dgvInvoiceDetail.Rows.Add(1, daysDifference + " ngày", booking.Car.CarType.RentPrice * daysDifference);
            //Nhiên liệu
            dgvInvoiceDetail.Rows.Add(2, booking.Fuel.Name, booking.Fuel.Price);
            //tính năng
            var features = booking.Features;
            int count = 2;
            foreach (var feature in features)
            {
                count += 1;
                dgvInvoiceDetail.Rows.Add(count, feature.Name, feature.Price);
            }
            //Tổng tiền phải thanh toán
            double total = 0;
            foreach (DataGridViewRow row in dgvInvoiceDetail.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    total += Convert.ToDouble(row.Cells[2].Value);
                }
            }
            dgvInvoiceDetail.Rows.Add("","Tổng cộng", total);

            DataGridViewCell totalCell = dgvInvoiceDetail.Rows[dgvInvoiceDetail.Rows.Count - 1].Cells[2];

            DataGridViewCell totalCell2 = dgvInvoiceDetail.Rows[dgvInvoiceDetail.Rows.Count - 1].Cells[1];

            totalCell.Style.Font = new Font(dgvInvoiceDetail.Font, FontStyle.Bold);
            totalCell2.Style.Font = new Font(dgvInvoiceDetail.Font, FontStyle.Bold);
        }
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
