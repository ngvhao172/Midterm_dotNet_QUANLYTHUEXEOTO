using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.Extensions.DependencyInjection;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using LiveChartsCore.SkiaSharpView.VisualElements;

namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    public partial class UC_ReportAndStatistic : UserControl
    {
        private CarTypesController cartypeController;
        private BookingController bookingController;
        private CarController carController;
        public UC_ReportAndStatistic()
        {
            InitializeComponent();
            this.cartypeController = App.ServiceProvider.GetRequiredService<CarTypesController>();
            this.bookingController = App.ServiceProvider.GetRequiredService<BookingController>();
            this.carController = App.ServiceProvider.GetRequiredService<CarController>();
        }

        private async void UC_ReportAndStatistic_Load(object sender, EventArgs e)
        {
       /*     var carTypesList = cartypeController.GetAllCarTypes();*/
            var bookings = await bookingController.GetAllBookings();
            double total = 0;
            foreach (var booking in bookings)
            {
                total += booking.TotalPrice;
            }
            txtRevenue.Text = total.ToString();
            txtNumberOfBooking.Text = bookings.Count.ToString();

            var cars = carController.GetAllCar();
            //add manufactures vào combobox
            var manufacturers = new HashSet<string>();
            foreach (var car in cars)
            {
                manufacturers.Add(car.Manufacturer.Trim().ToString());
            }
            foreach (var manufacture in manufacturers)
            {
                cbManufacturers.Items.Add(manufacture);
            }
            //add models vào combobox
            var models = new HashSet<string>();
            foreach (var car in cars)
            {
                models.Add(car.Model.Trim().ToString());
            }
            foreach (var model in models)
            {
                cbModels.Items.Add(model);
            }

            //CHART FOR CAR TYPE
            /*  chartForCarStatistic.DrawMarginFrame = new DrawMarginFrame
              {
                  Stroke = new SolidColorPaint(SKColors.Black, 2)
              };*/
            showChartDataByMonths();
        }

        private async void showChartDataByMonths()
        {
            List<LineSeries<int>> listOfCarTypeStatistic = new List<LineSeries<int>>();
            var listOfCartype = await cartypeController.GetAllCarTypes();
            foreach (CarType cartype in listOfCartype)
            {
                List<int> noOfBookings = await bookingController.GetNumberOfBookingsByCarTypesInMonths(cartype.Name);
                listOfCarTypeStatistic.Add(
                    new LineSeries<int>
                    {
                        Name = cartype.Name,
                        Values = noOfBookings
                    }
                );
            }

            ISeries[] Series = new ISeries[listOfCarTypeStatistic.Count];
            for (int i = 0; i < listOfCarTypeStatistic.Count; i++)
            {
                Series[i] = listOfCarTypeStatistic[i];
            }
            chartForCarStatistic.Title = new LabelVisual
            {
                Text = "Biểu đồ phân bố xe ô tô theo loại",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            chartForCarStatistic.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
            chartForCarStatistic.Series = Series; /*new ISeries[]
            {
                listOfCarTypeStatistic
               *//* new LineSeries<int>
                {
                    Name = "Tesla",
                    Values = new int[] { 4, 6, 5, 3, -3, -1, 2 }
                },
                 new LineSeries<int>
                {
                    Name = "Vinfast",
                    Values = new int[] { 0, 12, 5, 3, -3, -1, 5 }
                },*//*
            };*/

            chartForCarStatistic.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            chartForCarStatistic.XAxes = new List<Axis>
            {
                new Axis
                {
                    //Cac thang trong nam
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
                }
            };

            chartForCarStatistic.YAxes = new List<Axis>
            {
                new Axis
                {
                    MinLimit = -1
                }
            };

            //Biểu đổ doanh thu
            chartForRevenue.Title = new LabelVisual
            {
                Text = "Biểu đồ doanh thu",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            chartForRevenue.XAxes = new List<Axis>
            {
                new Axis
                {
                    //Cac thang trong nam
                    Labels = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
                }
            };

            chartForRevenue.YAxes = new List<Axis>
            {
                new Axis
                {
                    MinLimit = -10000
                }
            };
            chartForRevenue.Series = new ISeries[]
            {
                 new LineSeries<double>
                {
                    Name = "Revenue",
                    Values = await bookingController.GetRevenueBookingsInMonths()
                }
            };
            chartForRevenue.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            chartForRevenue.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
        }
        private async void showChartDataByYears()
        {
            List<LineSeries<int>> listOfCarTypeStatistic = new List<LineSeries<int>>();
            var listOfCartype = await cartypeController.GetAllCarTypes();
            foreach (CarType cartype in listOfCartype)
            {
                List<int> noOfBookings = await bookingController.GetNumberOfBookingsByCarTypesInYears(cartype.Name);
                listOfCarTypeStatistic.Add(
                    new LineSeries<int>
                    {
                        Name = cartype.Name,
                        Values = noOfBookings
                    }
                );
            }

            ISeries[] Series = new ISeries[listOfCarTypeStatistic.Count];
            for (int i = 0; i < listOfCarTypeStatistic.Count; i++)
            {
                Series[i] = listOfCarTypeStatistic[i];
            }
            chartForCarStatistic.Title = new LabelVisual
            {
                Text = "Biểu đồ phân bố xe ô tô theo loại",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            chartForCarStatistic.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
            chartForCarStatistic.Series = Series; /*new ISeries[]
            {
                listOfCarTypeStatistic
               *//* new LineSeries<int>
                {
                    Name = "Tesla",
                    Values = new int[] { 4, 6, 5, 3, -3, -1, 2 }
                },
                 new LineSeries<int>
                {
                    Name = "Vinfast",
                    Values = new int[] { 0, 12, 5, 3, -3, -1, 5 }
                },*//*
            };*/
            //Lấy 5 năm gần nhất
            List<string> years = new List<string>();
            int currentYear = DateTime.Now.Year - 5;

            for (int i = currentYear; i <= DateTime.Now.Year; i++)
            {
                years.Add(i.ToString());
            }
            chartForCarStatistic.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            chartForCarStatistic.XAxes = new List<Axis>
            {
                new Axis
                {
                    //5 nam gan nhat
                    Labels = years
                }
            };

            chartForCarStatistic.YAxes = new List<Axis>
            {
                new Axis
                {
                    MinLimit = -1
                }
            };

            //Biểu đổ doanh thu
            chartForRevenue.Title = new LabelVisual
            {
                Text = "Biểu đồ doanh thu",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
            chartForRevenue.XAxes = new List<Axis>
            {
                new Axis
                {
                    //5 nam gan nhat
                    Labels = years
                }
            };

            chartForRevenue.YAxes = new List<Axis>
            {
                new Axis
                {
                    MinLimit = -10000
                }
            };
            chartForRevenue.Series = new ISeries[]
            {
                 new LineSeries<double>
                {
                    Name = "Revenue",
                    Values = await bookingController.GetRevenueBookingsInYears()
                }
            };
            chartForRevenue.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
            chartForRevenue.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
        }

        private async void btnGetStatistic_Click(object sender, EventArgs e)
        {
            string manufacturer = cbManufacturers.Text.Trim().ToString();
            string model = cbModels.Text.Trim().ToString();

            DateTime from = dtpDateFrom.Value;
            DateTime to = dtpDateTo.Value;

            var bookings = await bookingController.GetBookingsByConditions(manufacturer, model, from, to);
            double total = 0;
            foreach (var booking in bookings)
            {
                total += booking.TotalPrice;
            }
            txtRevenue.Text = total.ToString();
            txtNumberOfBooking.Text = bookings.Count.ToString();

        }
        //Ngăn chặn người dùng thay đổi input
        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbTime.SelectedItem.ToString();
            if(selectedValue == "Tháng")
            {
                showChartDataByMonths();
            }
            else
            {
                showChartDataByYears();
            }
        }
    }
}
