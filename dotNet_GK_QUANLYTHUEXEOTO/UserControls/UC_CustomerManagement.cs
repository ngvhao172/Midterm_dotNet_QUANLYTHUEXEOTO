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
    public partial class UC_CustomerManagement : UserControl
    {
        private CustomerController customerController;
        public UC_CustomerManagement()
        {
            this.customerController = App.ServiceProvider.GetRequiredService<CustomerController>();
            InitializeComponent();
        }

        private void UC_CustomerManagement_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = customerController.GetAllCustomer();
            foreach (Customer customer in customerList)
            {
                dgvCustomers.Rows.Add(customer.FullName, customer.PhoneNumber, customer.CustomerEmail, customer.Address, customer.Dob.Date.ToShortDateString());
            }
            disableInput(false);
        }
        private void disableInput(bool b)
        {
            txtFullName.Enabled = b;
            txtAddress.Enabled = b;
            txtEmail.Enabled = b;
            txtPhoneNumber.Enabled = b;
            dtpDob.Enabled = b;
            btnAdd.Enabled = b;
            btnDelete.Enabled = b;
            btnEdit.Enabled = b;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            List<Customer> searchResults = new List<Customer>();

            List<Customer> customerList = customerController.GetAllCustomer();

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
            }
        }
    }
}
