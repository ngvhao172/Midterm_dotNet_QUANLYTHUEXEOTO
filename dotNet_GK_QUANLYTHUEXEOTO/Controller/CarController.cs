using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Controller
{
    public class CarController
    {
        private BookingCarDbContext dbContext;
        public CarController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Car> GetAllCar()
        {
            var cars = dbContext.Cars.Include(c => c.CarType).ToList();
            return cars;
        }
        public List<Car> GetAllCarsByCarTypeId(int carType)
        {
            var cars = dbContext.Cars.Where(c => c.CarTypeId == carType).ToList();
            return cars;
        }
        public List<Car> GetAllCarsAvailabelByCarTypeId(int carType)
        {
            var cars = dbContext.Cars.Where(c => c.CarTypeId == carType && c.Status == Model.Enum.CarStatus.Available).ToList();
            return cars;
        }

        public async Task<Car> GetCarById(string carId)
        {
            var car = await dbContext.Cars.Where(c => c.Id == carId).FirstOrDefaultAsync();
            return car;
        }

        public async Task UpdateCar(Car car)
        {
            dbContext.Cars.Update(car);
            await dbContext.SaveChangesAsync();
        }
        public async Task<Car> DeleteCar(Car car)
        {
            var existedBooking = await dbContext.Bookings.Where(c => c.CarId == car.Id).FirstOrDefaultAsync();
            if (existedBooking==null)
            {
                dbContext.Cars.Remove(car);
                await dbContext.SaveChangesAsync();
                return car;
            }
            return null;
        }
        public async Task<Car> AddCar(Car car)
        {
            var existedCar = await dbContext.Cars.Where(c => c.Id == car.Id).FirstOrDefaultAsync();
            if (existedCar == null)
            {
                await dbContext.Cars.AddAsync(car);
                await dbContext.SaveChangesAsync();
                return car;
            }
            return null;

        }


    }
}
