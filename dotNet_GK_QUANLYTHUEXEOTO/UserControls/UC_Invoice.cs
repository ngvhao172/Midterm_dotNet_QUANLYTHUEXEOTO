using dotNet_GK_QUANLYTHUEXEOTO.Controller;
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
using static OfficeOpenXml.ExcelErrorValue;

namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    public partial class UC_Invoice : UserControl
    {
        private BookingController bookingController;
        public UC_Invoice()
        {
            InitializeComponent();
            this.bookingController = App.ServiceProvider.GetRequiredService<BookingController>();
        }

        private async void UC_Invoice_Load(object sender, EventArgs e)
        {
            var bookingList = await bookingController.GetAllBookingsPaid();

            foreach (var booking in bookingList)
            {
                dgvInvoices.Rows.Add(booking.Id, booking.Customer.FullName, booking.Customer.PhoneNumber, booking.Customer.CustomerEmail, booking.Customer.Address, booking.Car.CarType.Name, booking.CarId, booking.FromDate.ToShortDateString(), booking.ToDate.ToShortDateString(), booking.TotalPrice);
            }
        }

        private void dgvInvoices_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvInvoices.Rows[e.RowIndex];

                txtFullName.Text = selectedRow.Cells[1].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells[2].Value.ToString();
                txtEmail.Text = selectedRow.Cells[3].Value.ToString();
                txtAddress.Text = selectedRow.Cells[4].Value.ToString();
                txtCarType.Text = selectedRow.Cells[5].Value.ToString();
                txtCarId.Text = selectedRow.Cells[6].Value.ToString();
                txtFromDate.Text = selectedRow.Cells[7].Value.ToString();
                txtToDate.Text = selectedRow.Cells[8].Value.ToString();
                txtAmount.Text = selectedRow.Cells[9].Value.ToString();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết");
            }
            else
            {
                int bookingId = int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString());

                UC_InvoiceDetail uc = new UC_InvoiceDetail();
                uc.BookingId = bookingId;
                TemporaryForm temporaryForm = new TemporaryForm(uc);
                temporaryForm.Height = 774;
                temporaryForm.Width = 810;
                temporaryForm.ShowDialog();
            }
        }
        public class TemporaryForm : Form
        {
            public TemporaryForm(UserControl userControl)
            {
                this.Text = "Invoice Detail";
                this.Size = new System.Drawing.Size(720, 650);
                this.Controls.Add(userControl);
            }
        }
    }
}
