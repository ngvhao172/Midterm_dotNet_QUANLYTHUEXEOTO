using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Imaging;

namespace dotNet_GK_QUANLYTHUEXEOTO.Model.Data
{
    public class BookingCarDbContext : DbContext
    {
        public BookingCarDbContext() :  base()
        {

        }

        public BookingCarDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ADMINISTRATOR\SQLEXPRESS;Database=QLTHUEXEOTO;Trusted_Connection=True;TrustServerCertificate=True; MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee { EmployeeId = 1, FullName = "Admin", EmployeeEmail = "admin@gmail.com", PhoneNumber = "0123456789", Address = "Hue" },
               new Employee { EmployeeId = 2, FullName = "User", EmployeeEmail = "user@gmail.com", PhoneNumber = "0987654321", Address = "Quang Nam" }
            );

            modelBuilder.Entity<Account>().HasData(
            new Account { EmployeeEmail = "admin@gmail.com", Password = "admin", EmployeeId = 1 },
            new Account { EmployeeEmail = "user@gmail.com", Password = "user", EmployeeId = 2 }
            );
            modelBuilder.Entity<CarType>().HasData(
                new CarType { Id = 1, Name = "4 chỗ (Mini)", RentPrice = 1000, CarImage = "../../../Resources/Images/CarTypes/MINI.png" },
                new CarType { Id = 2, Name = "4 chỗ (Sedan)", RentPrice = 1200, CarImage = "../../../Resources/Images/CarTypes/SEDAN.png" },
                new CarType { Id = 3, Name = "4 chỗ (Hatchback)", RentPrice = 1500, CarImage = "../../../Resources/Images/CarTypes/HATCHBACK.png" },
                new CarType { Id = 4, Name = "5 chỗ (CUV Gầm cao)", RentPrice = 2000, CarImage = "../../../Resources/Images/CarTypes/CUV.png" },
                new CarType { Id = 5, Name = "7 chỗ (SUV Gầm cao)", RentPrice = 4000, CarImage = "../../../Resources/Images/CarTypes/SUV.png" },
                new CarType { Id = 6, Name = "7 chỗ (MPV Gầm thấp)", RentPrice = 3000, CarImage = "../../../Resources/Images/CarTypes/MPV.png" },
                new CarType { Id = 7, Name = "Bán tải", RentPrice = 500, CarImage = "../../../Resources/Images/CarTypes/PICKUP.png" }
            );
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = "75H7777", Model = "2023", CarTypeId = 2, Manufacturer = "Tesla", Status = Enum.CarStatus.Available },
                new Car { Id = "92H1010", Model = "2023", CarTypeId = 1, Manufacturer = "Huynhdai", Status = Enum.CarStatus.Available },
                new Car { Id = "75H0123", Model = "2023", CarTypeId = 3, Manufacturer = "KIA", Status = Enum.CarStatus.Available },
                new Car { Id = "75H6789", Model = "2023", CarTypeId = 4, Manufacturer = "Tesla", Status = Enum.CarStatus.Available },
                new Car { Id = "92H0123", Model = "2023", CarTypeId = 5, Manufacturer = "Audi", Status = Enum.CarStatus.Available },
                new Car { Id = "92H6789", Model = "2023", CarTypeId = 6, Manufacturer = "Porsche", Status = Enum.CarStatus.Available },
                new Car { Id = "75H6666", Model = "2023", CarTypeId = 1, Manufacturer = "Vinfast", Status = Enum.CarStatus.Available },
                new Car { Id = "75H1111", Model = "2023", CarTypeId = 4, Manufacturer = "Mazda", Status = Enum.CarStatus.Available },
                new Car { Id = "92H1111", Model = "2023", CarTypeId = 5, Manufacturer = "Tesla", Status = Enum.CarStatus.Available },
                new Car { Id = "92H2222", Model = "2023", CarTypeId = 6, Manufacturer = "Vinfast", Status = Enum.CarStatus.Available },
                new Car { Id = "75H2222", Model = "2023", CarTypeId = 7, Manufacturer = "Huynhdai", Status = Enum.CarStatus.Available }
            );
            modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = 1, Name = "Bản đồ", Price = 1000},
                new Feature { Id = 2, Name = "Camera cập lề", Price = 1000 },
                new Feature { Id = 3, Name = "Cảm biến lốp", Price = 1000 },
                new Feature { Id = 4, Name = "Cửa số trời", Price = 1000 },
                new Feature { Id = 5, Name = "Khe cắm USB", Price = 1000 },
                new Feature { Id = 6, Name = "Nắp thùng xe bán tải", Price = 1000 },
                new Feature { Id = 7, Name = "Bluetooth", Price = 1000 },
                new Feature { Id = 8, Name = "Camera hành trình", Price = 1000 },
                new Feature { Id = 9, Name = "Cảm biến va chạm", Price = 1000 },
                new Feature { Id = 10, Name = "Định vị GPS", Price = 1000 },
                new Feature { Id = 11, Name = "Lốp dự phòng", Price = 1000 },
                new Feature { Id = 12, Name = "Camera 360", Price = 1000 },
                new Feature { Id = 13, Name = "Camera lùi", Price = 1000 },
                new Feature { Id = 14, Name = "Cảnh báo tốc độ", Price = 1000 }
            );
            modelBuilder.Entity<Fuel>().HasData(
                new Fuel { Id = 1, Name = "Xăng", Price = 1000 },
                new Fuel { Id = 2, Name = "Dầu Diesel", Price = 1500 },
                new Fuel { Id = 3, Name = "Điện", Price = 2000 }
            );

        }

       /* public byte[] ImageToByteArray(string location)
        {
            Image image = Image.FromFile(location);
            Bitmap bitmap = new Bitmap(image);
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }*/
    }
}
