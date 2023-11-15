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
    public partial class UC_ConfirmPayment : UserControl
    {
        public int BookingId { get; set; }
        private BookingController bookingController;
        private CarController carController;
        public UC_ConfirmPayment()
        {
            InitializeComponent();
            this.bookingController = App.ServiceProvider.GetRequiredService<BookingController>();
            this.carController = App.ServiceProvider.GetRequiredService<CarController>();
        }
        private async void UC_ConfirmPayment_Load(object sender, EventArgs e)
        {
            Booking booking = await bookingController.GetBookingById(BookingId);

            txtCustomerFullName.Text = booking.Customer.FullName;
            txtPhoneNumber.Text = booking.Customer.PhoneNumber;
            txtCarId.Text = booking.CarId;
            txtCarType.Text = booking.Car.CarType.Name;



            //số ngày thuê
            var Duration = booking.ToDate.Date - booking.FromDate.Date;
            int daysDifference = (int)Duration.TotalDays + 1;
            //Tiền thuê xe = tiền xe * số ngày thuê
            dgvBookingDetail.Rows.Add(daysDifference + " ngày", booking.Car.CarType.RentPrice * daysDifference);
            //Nhiên liệu
            dgvBookingDetail.Rows.Add(booking.Fuel.Name, booking.Fuel.Price);
            //tính năng
            var features = booking.Features;
            foreach(var feature in features )
            {
                dgvBookingDetail.Rows.Add(feature.Name, feature.Price);
            }
            //Tổng tiền phải thanh toán
            double total = 0;
            foreach (DataGridViewRow row in dgvBookingDetail.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    total += Convert.ToDouble(row.Cells[1].Value);
                }
            }
            dgvBookingDetail.Rows.Add("Tổng cộng", total);

        }
         
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button clickedButon = sender as Button;

            if (clickedButon != null && clickedButon.Parent != null)
            {
                UserControl userControl = clickedButon.Parent as UserControl;
                if (userControl != null)
                {
                    Form formContaner = userControl.Parent as Form;
                    if (formContaner != null)
                    {
                        formContaner.Close();
                    }
                }
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                /* Booking.CustomerId = existedCustomer.CustomerId;
                 await bookingController.AddBooking(Booking);*/
                Booking booking = await bookingController.GetBookingById(BookingId);
                Car carBooked = booking.Car;
                carBooked.Status = Model.Enum.CarStatus.Available;
                await carController.UpdateCar(carBooked);

                booking.Status = Model.Enum.BookingStatus.Paid;
                await bookingController.UpdateBooking(booking);

                MessageBox.Show("Thanh toán thành công.");
                Button clickedButon = sender as Button;

                if (clickedButon != null && clickedButon.Parent != null)
                {
                    UserControl userControl = clickedButon.Parent as UserControl;
                    if (userControl != null)
                    {
                        Form formContaner = userControl.Parent as Form;
                        if (formContaner != null)
                        {
                            formContaner.Close();
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }
        //Ngăn chặn người dùng thay đổi input
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
