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
    public partial class UC_CarManagement : UserControl
    {
        private CarController carController;
        public UC_CarManagement()
        {
            this.carController = App.ServiceProvider.GetRequiredService<CarController>();
            InitializeComponent();
        }

        private void UC_CarManagement_Load(object sender, EventArgs e)
        {
            List<Car> carList = carController.GetAllCar();
            foreach (Car car in carList)
            {
                dgvCars.Rows.Add(car.Id, car.CarType.Name, car.Manufacturer, car.Model, car.CarType.RentPrice, car.Status);
            }
            disableInput(false);
        }

        private void txtCarIdSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCarIdSearch.Text.Trim().ToLower();

            List<Car> searchResults = new List<Car>();

            List<Car> carList = carController.GetAllCar();

            if (keyword.Length > 0)
            {
                foreach (Car car in carList)
                {
                    if (car.Id.ToLower().Contains(keyword) || car.CarType.Name.ToLower().Contains(keyword) || car.Manufacturer.ToLower().Contains(keyword) || car.Model.Contains(keyword))
                    {
                        searchResults.Add(car);
                    }
                }
                dgvCars.Rows.Clear();
                foreach (Car car in searchResults)
                {
                    dgvCars.Rows.Add(car.Id, car.CarType.Name, car.Manufacturer, car.Model, car.CarType.RentPrice, car.Status);
                }
            }
            else
            {
                dgvCars.Rows.Clear();
                foreach (Car car in carList)
                {
                    dgvCars.Rows.Add(car.Id, car.CarType.Name, car.Manufacturer, car.Model, car.CarType.RentPrice, car.Status);
                }
            }
        }
        private void disableInput(bool b)
        {
            txtCarId.Enabled = b;
            txtCarType.Enabled = b;
            txtManufacturer.Enabled = b;
            txtModel.Enabled = b;
            txtRentPrice.Enabled = b;
            btnAdd.Enabled = b;
            btnDelete.Enabled = b;
            btnEdit.Enabled = b;
        }

        private void dgvCars_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCars.Rows[e.RowIndex];

                txtCarId.Text = selectedRow.Cells[0].Value.ToString();
                txtCarType.Text = selectedRow.Cells[1].Value.ToString();
                txtManufacturer.Text = selectedRow.Cells[2].Value.ToString();
                txtModel.Text = selectedRow.Cells[3].Value.ToString();
                txtRentPrice.Text = selectedRow.Cells[4].Value.ToString();
            }
        }
    }
}
