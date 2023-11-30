using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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
    public partial class UC_CustomerManagement : UserControl
    {
        private CustomerController customerController;
        public string email { get; set; }

        public UC_CustomerManagement()
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            this.customerController = App.ServiceProvider.GetRequiredService<CustomerController>();
            InitializeComponent();
        }

        private async void UC_CustomerManagement_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = await customerController.GetAllCustomer();
            foreach (Customer customer in customerList)
            {
                dgvCustomers.Rows.Add(customer.FullName, customer.PhoneNumber, customer.CustomerEmail, customer.Address, customer.Dob.Date.ToShortDateString());
            }
            disableInput(false);
            if (email != "admin@gmail.com")
            {
                HideAllButtons();
                return;
            }
        }

        private void HideAllButtons()
        {
            btnDelete.Visible = false;
            btnEdit.Visible = false;
        }
        private void disableInput(bool b)
        {
            btnDelete.Enabled = b;
            btnEdit.Enabled = b;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            List<Customer> searchResults = new List<Customer>();

            List<Customer> customerList = await customerController.GetAllCustomer();

            if (keyword.Length > 0)
            {
                foreach (Customer customer in customerList)
                {
                    if (customer.PhoneNumber.Contains(keyword) || customer.FullName.ToLower().Contains(keyword) || customer.Address.ToLower().Contains(keyword))
                    {
                        searchResults.Add(customer);
                    }
                }
                dgvCustomers.Rows.Clear();
                foreach (Customer customer in searchResults)
                {
                    dgvCustomers.Rows.Add(customer.FullName, customer.PhoneNumber, customer.CustomerEmail, customer.Address, customer.Dob.Date.ToShortDateString());
                }
            }
            else
            {
                dgvCustomers.Rows.Clear();
                foreach (Customer customer in customerList)
                {
                    dgvCustomers.Rows.Add(customer.FullName, customer.PhoneNumber, customer.CustomerEmail, customer.Address, customer.Dob.Date.ToShortDateString());
                }
            }
        }

        private void dgvCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCustomers.Rows[e.RowIndex];

                txtFullName.Text = selectedRow.Cells[0].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells[1].Value.ToString();
                txtEmail.Text = selectedRow.Cells[2].Value.ToString();
                txtAddress.Text = selectedRow.Cells[3].Value.ToString();
                dtpDob.Value = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                disableInput(true);
                btnAdd.Enabled = false;
            }
        }
        private bool validateInfo()
        {
            if (txtFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                return false;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email khách hàng");
                return false;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng");
                return false;
            }
            if (txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                return false;
            }
            if (dtpDob.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh khách hàng");
                return false;
            }
            return true;
        }
        private void EmtyField()
        {
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            dtpDob.Text = string.Empty;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                Customer existedCustomer = await customerController.GetCustomerByPhoneNumber(txtPhoneNumber.Text.Trim());
                if (existedCustomer == null)
                {
                    //Tạo Customer nếu chưa tồn tại
                    Customer newCustomer = new Customer { FullName = txtFullName.Text.ToString(), CustomerEmail = txtEmail.Text.ToString(), Address = txtAddress.Text.ToString(), PhoneNumber = txtPhoneNumber.Text.ToString(), Dob = dtpDob.Value };

                    await customerController.AddCustomer(newCustomer);
                    MessageBox.Show("Đã thêm khách hàng thành công");
                    EmtyField();
                    txtSearch_TextChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã tồn tại khách hàng sử dụng số điện thoại này");

                }

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string customerPhone = txtPhoneNumber.Text.Trim();
                Customer customeSelected = await customerController.GetCustomerByPhoneNumber(customerPhone);
                await customerController.DeleteCustomer(customeSelected);
                MessageBox.Show("Đã xóa khách hàng thành công");
                EmtyField();
                txtSearch_TextChanged(sender, e);
                disableInput(false);
                btnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Không thể cập nhật xóa khách hàng");
                return;

            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                string customerPhone = txtPhoneNumber.Text.Trim();
                Customer customeSelected = await customerController.GetCustomerByPhoneNumber(customerPhone);
                if (customeSelected != null)
                {
                    customeSelected.FullName = txtFullName.Text.Trim();
                    customeSelected.CustomerEmail = txtEmail.Text.Trim();
                    customeSelected.Address = txtAddress.Text.Trim();
                    customeSelected.Dob = dtpDob.Value;
                    await customerController.UpdateCustomer(customeSelected);
                    MessageBox.Show("Cập nhật khách hàng thành công");
                    EmtyField();
                    txtSearch_TextChanged(sender, e);
                    disableInput(false);
                    btnAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không thể thay đổi số điện thoại khách hàng");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Không thể cập nhật khách hàng");
                return;

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //thêm trang tính Customers
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Customers");

                worksheet.Cells[1, 1].Value = "Full Name";
                worksheet.Cells[1, 2].Value = "Phone Number";
                worksheet.Cells[1, 3].Value = "Email";
                worksheet.Cells[1, 4].Value = "Address";
                worksheet.Cells[1, 5].Value = "Date of Birth";

                for (int i = 0; i < dgvCustomers.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvCustomers.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvCustomers.Rows[i].Cells[j].Value;
                    }
                }
                //điều chỉnh độ rộng cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // lưu file Excel
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Lưu file excel";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);
                        MessageBox.Show("Xuất file excel thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xuất file!");
                    }
                }
            }
        }
    }
}
