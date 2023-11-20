using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
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
        private CarTypesController cartypeController;

        public UC_CarManagement()
        {
            this.carController = App.ServiceProvider.GetRequiredService<CarController>();
            this.cartypeController = App.ServiceProvider.GetRequiredService<CarTypesController>();
            InitializeComponent();
        }

        private async void UC_CarManagement_Load(object sender, EventArgs e)
        {
            List<Car> carList = carController.GetAllCar();
            foreach (Car car in carList)
            {
                dgvCars.Rows.Add(car.Id, car.CarType.Name, car.Manufacturer, car.Model, car.CarType.RentPrice, car.Status);
            }

            var cartypes = await cartypeController.GetAllCarTypes();

            //add models vào combobox
            var models = new HashSet<string>();
            foreach (var cartype in cartypes)
            {
                models.Add(cartype.Name.Trim().ToString());
            }
            foreach (var model in models)
            {
                cbCarType.Items.Add(model);
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
            btnDelete.Enabled = b;
            btnEdit.Enabled = b;
            txtRentPrice.Enabled = b;
        }

        private void dgvCars_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCars.Rows[e.RowIndex];

                txtCarId.Text = selectedRow.Cells[0].Value.ToString();
                cbCarType.Text = selectedRow.Cells[1].Value.ToString();
                txtManufacturer.Text = selectedRow.Cells[2].Value.ToString();
                txtModel.Text = selectedRow.Cells[3].Value.ToString();
                txtRentPrice.Text = selectedRow.Cells[4].Value.ToString();
                disableInput(true);
                btnAdd.Enabled = false;
                txtRentPrice.Enabled = false;

            }
        }
        private bool validateInfo()
        {
            if (txtCarId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng biển số xe");
                return false;
            }
            if (cbCarType.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập email khách hàng");
                return false;
            }
            if (txtManufacturer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập nhà sản xuất");
                return false;
            }
            if (txtModel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập năm sản xuất");
                return false;
            }
            return true;
        }

        private void cbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCarTypeName = cbCarType.SelectedItem.ToString();
            CarType selectedCarType = cartypeController.GetCarTypeByName(selectedCarTypeName);
            txtRentPrice.Text = selectedCarType.RentPrice.ToString();
        }
        private void EmtyField()
        {
            txtCarId.Text = string.Empty;
            cbCarType.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtRentPrice.Text = string.Empty;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                Car existedCar = await carController.GetCarById(txtCarId.Text.Trim());
                if (existedCar == null)
                {
                    var cartypes = cartypeController.GetCarTypeByName(cbCarType.Text.Trim());

                    Car newCar = new Car { Id = txtCarId.Text.ToString(), Model = txtModel.Text.ToString(), CarTypeId = cartypes.Id, Manufacturer = txtManufacturer.Text.ToString(), Status = 0 };
                    await carController.AddCar(newCar);
                    MessageBox.Show("Đã thêm xe thành công");
                    EmtyField();
                    txtCarIdSearch_TextChanged(sender,e);
                }
                else
                {
                    MessageBox.Show("Xe đã được thêm trước đó");
                    return;
                }

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string carId = txtCarId.Text.Trim();
            Car carSelected = await carController.GetCarById(carId);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa xe này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Car carDelete= await carController.DeleteCar(carSelected);
                if (carDelete != null)
                {
                    MessageBox.Show("Đã xóa xe thành công");

                }
                else
                {
                    MessageBox.Show("Xe đã có đơn đặt");

                }
                EmtyField();
                txtCarIdSearch_TextChanged(sender, e);
                disableInput(false);
                btnAdd.Enabled = true;
            }
            else
            {
                return;

            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {

            if (validateInfo())
            {
                string carId = txtCarId.Text.Trim();
                Car carSelected = await carController.GetCarById(carId);
                if (carSelected != null)
                {
                    if (carSelected.Status == 0){
                        carSelected.Model = txtModel.Text.Trim();
                        carSelected.Manufacturer = txtManufacturer.Text.Trim();
                        carSelected.CarTypeId = cartypeController.GetCarTypeByName(cbCarType.Text.Trim()).Id;
                        await carController.UpdateCar(carSelected);
                        MessageBox.Show("Cập nhật xe thành công");
                        EmtyField();
                        txtCarIdSearch_TextChanged(sender, e);
                        disableInput(false);
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Xe đang được thuê không thể cập nhật");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thay đổi biển số xe");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Không thể cập nhật xe");
                return;

            }

        }
        private async void ImportCarsFromExcel(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Giả sử dữ liệu ở trang tính đầu tiên

                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) // Bắt đầu từ hàng thứ 2 để tránh tiêu đề
                    {
                        string carId = worksheet.Cells[row, 1].Text;
                        string carTypeName = worksheet.Cells[row, 2].Text;
                        string manufacturer = worksheet.Cells[row, 3].Text;
                        string model = worksheet.Cells[row, 4].Text;

                        // Nếu thông tin cần thiết (carId, carTypeName) không rỗng, thêm xe vào danh sách
                        if (!string.IsNullOrEmpty(carId) && !string.IsNullOrEmpty(carTypeName))
                        {
                            CarType carType = cartypeController.GetCarTypeByName(carTypeName);
                            if (carType != null)
                            {
                                Car newCar = new Car
                                {
                                    Id = carId,
                                    Model = model,
                                    CarTypeId = carType.Id,
                                    Manufacturer = manufacturer,
                                    Status = 0 
                                };

                                await carController.AddCar(newCar);
                            }
                        }
                    }

                    // Cập nhật lại danh sách hiển thị trên giao diện
                    List<Car> updatedCarList = carController.GetAllCar();
                    UpdateDataGridView(updatedCarList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi nhập từ Excel: {ex.Message}");
            }
        }
        private void UpdateDataGridView(List<Car> cars)
        {
            dgvCars.Rows.Clear();

            foreach (Car car in cars)
            {
                dgvCars.Rows.Add(car.Id, car.CarType.Name, car.Manufacturer, car.Model, car.CarType.RentPrice, car.Status);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //mở file excel
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                openFileDialog.Title = "Chọn file Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    ImportCarsFromExcel(filePath);
                }
            }
        }
    }
}
