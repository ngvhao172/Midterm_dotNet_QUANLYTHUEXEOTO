using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.EntityFrameworkCore;
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
    public partial class UC_RentCar : UserControl
    {
        private CarTypesController carTypesController;

        private CarController carController;

        private FeatureController featureController;

        private FuelController fuelController;
        public string CarType { get; set; }

        private List<Feature> featuresList { get; set; }
        public UC_RentCar()
        {
            this.carTypesController = App.ServiceProvider.GetRequiredService<CarTypesController>();
            this.carController = App.ServiceProvider.GetRequiredService<CarController>();
            this.featureController = App.ServiceProvider.GetRequiredService<FeatureController>();
            this.fuelController = App.ServiceProvider.GetRequiredService<FuelController>();
            InitializeComponent(); 
        }
       
        private void UC_RentCar_Load(object sender, EventArgs e)
        {
            featuresList = new List<Feature>();
            var CarTypeObject = carTypesController.GetCarTypeByName(CarType);
            byte[] imageData = CarTypeObject.CarImage;
            //Hiển thị ảnh xe đã chọn
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Bitmap bitmap = new Bitmap(ms);
                pBCarImage.Image = bitmap;
            }
            lbCarName.Text = CarTypeObject.Name;
            //Căn giữa tên xe
            lbCarName.Location = new Point((lbCarName.Parent.Width - lbCarName.Width) / 2, lbCarName.Top);


            //Get tất cả xe có sẵn để thuê
            var carsAvailable = carController.GetAllCarsAvailabelByCarTypeId(CarTypeObject.Id);

            foreach (var item in carsAvailable)
            {
                dgvCarForRent.Rows.Add(item.Id, item.Status);
            }

            dtpFrom.MinDate = DateTime.Today;
            //Get tất cả các tính năng

            List<Feature> features = featureController.GetAllFeature();
            foreach (Feature item in features)
            {
                checkListBox.Items.Add(item.Name);
            }
            /*   dgvFee.Rows.Add(CarTypeObject.Name, CarTypeObject.RentPrice);*/

            var Duration = dtpTo.Value.Date - dtpFrom.Value.Date;
            int daysDifference = (int)Duration.TotalDays + 1;

            dgvFee.Rows.Add(daysDifference + "ngày", CarTypeObject.RentPrice * daysDifference);
            UpdateTotalRow();
        }
        private void addUserControl(UserControl userControl, Control panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
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
                        UC_CarTypeSelection uc = new UC_CarTypeSelection();
                        addUserControl(uc, panelContaner);
                    }
                }
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<Feature> features = featureController.GetAllFeature();
            if (e.NewValue == CheckState.Checked)
            {
                Feature selectedItem = features[e.Index];
                dgvFee.Rows.Add(selectedItem.Name, selectedItem.Price);
                //Lưu lại Id của feature
                featuresList.Add(selectedItem);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                Feature selectedItem = features[e.Index];
                for (int i = featuresList.Count - 1; i >= 0; i--)
                {
                    if (featuresList[i].Name == selectedItem.Name)
                    {
                        featuresList.RemoveAt(i);
                        break;
                    }
                }
                for (int i = dgvFee.Rows.Count - 1; i >= 0; i--)
                {
                    if (dgvFee.Rows[i].Cells[0].Value != null && dgvFee.Rows[i].Cells[0].Value.ToString() == selectedItem.Name)
                    {
                        dgvFee.Rows.RemoveAt(i);
                        break;
                    }
                }
            }
            UpdateTotalRow();
        }
        private void UpdateTotalRow()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvFee.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    total += Convert.ToInt32(row.Cells[1].Value);
                }
            }
            DataGridViewRow totalRow = dgvFee.Rows.Cast<DataGridViewRow>().LastOrDefault();
            if (totalRow != null)
            {
                total -= Convert.ToInt32(totalRow.Cells[1].Value);
                totalRow.Cells[0].Value = "Tổng cộng";
                totalRow.Cells[1].Value = total;
            }
            else
            {
                dgvFee.Rows.Add("Tổng cộng", total);
            }
        }

        private async void btnRent_Click(object sender, EventArgs e)
        {
            //Validate
            if(!rdElectric.Checked && !rdGas.Checked && !rdOil.Checked)
            {
                MessageBox.Show("Vui lòng chọn nhiên liệu");
            }
            else if (dgvCarForRent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn xe để thuê");
            }
            else if(dtpTo.Value.Date < dtpFrom.Value.Date)
            {
                MessageBox.Show("Ngày thuê xe không được bé hơn ngày trả xe");
            }
            else
            {
                //Lấy ra id của nhiên liệu
                string fuelType = string.Empty;

                if (rdElectric.Checked)
                {
                    fuelType = rdElectric.Text;
                }
                else if (rdGas.Checked)
                {
                    fuelType = rdGas.Text;
                }
                else if (rdOil.Checked)
                {
                    fuelType = rdOil.Text;
                }
               
                Fuel fuelPicker = await fuelController.GetFuelByName(fuelType);

                //Tạo booking ở đây rồi truyền sang userInfo
                DataGridViewRow totalRow = dgvFee.Rows.Cast<DataGridViewRow>().LastOrDefault();
                var newBooking = new Booking { CarId = dgvCarForRent.SelectedRows[0].Cells[0].Value.ToString(), FuelId = fuelPicker.Id, TotalPrice = int.Parse(totalRow.Cells[1].Value.ToString()), Features = featuresList, FromDate = dtpFrom.Value, ToDate = dtpTo.Value };

                Button clickedButon = sender as Button;

                if (clickedButon != null && clickedButon.Parent != null)
                {
                    UserControl userControl = clickedButon.Parent as UserControl;
                    if (userControl != null)
                    {
                        Panel panelContaner = userControl.Parent as Panel;
                        if (panelContaner != null)
                        {
                            UC_UserInfo uc = new UC_UserInfo();
                            uc.Booking = newBooking;
                            uc.CarType = CarType;
                            addUserControl(uc, panelContaner);
                        }
                    }
                }
            }

            
        }
        private void rdBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;

            if (rd.Checked)
            {
                if(rd.Text == "Xăng")
                {
                    dgvFee.Rows.Add(rd.Text, 1000);
                }
                else if(rd.Text == "Điện")
                {
                    dgvFee.Rows.Add(rd.Text, 2000);
                }
                else
                {
                    dgvFee.Rows.Add(rd.Text, 1500);
                }
                
                UpdateTotalRow();
            }
            else
            {
                RemoveDataFromDataGridView(rd.Text);
            }
        }
        private void RemoveDataFromDataGridView(string data)
        {
            foreach (DataGridViewRow row in dgvFee.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == data)
                {
                    dgvFee.Rows.Remove(row);
                    return;
                }
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            var CarTypeObject = carTypesController.GetCarTypeByName(CarType);

            var Duration = dtpTo.Value.Date - dtpFrom.Value.Date;
            int daysDifference = (int)Duration.TotalDays + 1;

            DataGridViewRow selectedRow = dgvFee.Rows[0];

            selectedRow.Cells[0].Value = daysDifference + " ngày";

            selectedRow.Cells[1].Value = CarTypeObject.RentPrice * daysDifference;

            UpdateTotalRow();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            var CarTypeObject = carTypesController.GetCarTypeByName(CarType);

            var Duration = dtpTo.Value.Date - dtpFrom.Value.Date;
            int daysDifference = (int)Duration.TotalDays + 1;

            DataGridViewRow selectedRow = dgvFee.Rows[0];

            selectedRow.Cells[0].Value = daysDifference + " ngày";

            selectedRow.Cells[1].Value = CarTypeObject.RentPrice * daysDifference;

            UpdateTotalRow();
        }
    }
}
