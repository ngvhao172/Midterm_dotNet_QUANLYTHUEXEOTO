using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Controller
{
    public class BookingController
    {
        private BookingCarDbContext dbContext;
        public BookingController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddBooking(Booking booking)
        {
            dbContext.Bookings.Add(booking);
            await dbContext.SaveChangesAsync();
        }
        public async Task<List<Booking>> GetAllBookingsRenting()
        {
            var bookings = await dbContext.Bookings.Where(b => b.Status == Model.Enum.BookingStatus.Renting).Include(c => c.Customer).Include(c => c.Car).ThenInclude(c => c.CarType).ToListAsync();
            return bookings;
        }
        public async Task<List<Booking>> GetAllBookingsPaid()
        {
            var bookings = await dbContext.Bookings.Where(b => b.Status == Model.Enum.BookingStatus.Paid).Include(c => c.Customer).Include(c => c.Car).ThenInclude(c => c.CarType).ToListAsync();
            return bookings;
        }
        public async Task<List<Booking>> GetAllBookings()
        {
            var bookings = await dbContext.Bookings.Include(c => c.Customer).Include(c => c.Car).ThenInclude(c => c.CarType).ToListAsync();
            return bookings;
        }

        public async Task<Booking> GetBookingById(int bookingId)
        {
            Booking booking = await dbContext.Bookings.Where(b => b.Id == bookingId).Include(c => c.Customer).Include(c => c.Car).ThenInclude(c => c.CarType).Include(f => f.Fuel).Include(f => f.Features).FirstOrDefaultAsync();
            return booking;
        }

        public async Task UpdateBooking(Booking booking)
        {
            dbContext.Bookings.Update(booking);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Booking>> GetBookingsByConditions(string manufacturer, string model, DateTime? from, DateTime? to)
        {
            var bookings = await dbContext.Bookings
                .Include(b => b.Car)
                .Where(b =>
                    (b.FromDate <= from && b.ToDate >= to) ||
                    (b.FromDate <= from && b.ToDate >= from) ||
                    (b.FromDate >= from && b.FromDate <= to))
                .Where(b =>
                    (string.IsNullOrEmpty(manufacturer) || b.Car != null && b.Car.Manufacturer == manufacturer) &&
                    (string.IsNullOrEmpty(model) || b.Car != null && b.Car.Model == model))
                .ToListAsync();

            return bookings;
        }

        public async Task<List<int>> GetNumberOfBookingsByCarTypesInMonths(string carType)
        {
            var noOfBookings = new List<int>();
            for (int i = 1; i<= DateTime.Now.Month; i++)
            {
                var bookings = await dbContext.Bookings
                .Include(b => b.Car)
                .Where(b => (b.Car.CarType.Name == carType) && (b.FromDate.Month == i || b.ToDate.Month == i))
                .ToListAsync();
                noOfBookings.Add(bookings.Count);    
            }

            return noOfBookings;
        }

        public async Task<List<double>> GetRevenueBookingsInMonths()
        {
            var revenueOfBookingsByMonths = new List<double>();
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                double total = 0;
                var bookings = await dbContext.Bookings
                .Where(b => b.FromDate.Month == i || b.ToDate.Month == i)
                .ToListAsync();
                foreach(Booking booking in bookings)
                {
                    total += booking.TotalPrice;
                }
                revenueOfBookingsByMonths.Add(total);
            }

            return revenueOfBookingsByMonths;
        }

        public async Task<List<int>> GetNumberOfBookingsByCarTypesInYears(string carType)
        {
            var noOfBookings = new List<int>();
            int fiveYearsAgo = DateTime.Now.Year - 5;
            for (int i = fiveYearsAgo; i <= DateTime.Now.Year; i++)
            {
                var bookings = await dbContext.Bookings
                .Include(b => b.Car)
                .Where(b => (b.Car.CarType.Name == carType) && (b.FromDate.Year == i || b.ToDate.Year == i))
                .ToListAsync();
                noOfBookings.Add(bookings.Count);
            }

            return noOfBookings;
        }
        public async Task<List<double>> GetRevenueBookingsInYears()
        {
            var revenueOfBookingsByMonths = new List<double>();
            int fiveYearsAgo = DateTime.Now.Year - 5;
            for (int i = fiveYearsAgo; i <= DateTime.Now.Year; i++)
            {
                double total = 0;
                var bookings = await dbContext.Bookings
                .Where(b => b.FromDate.Year == i || b.ToDate.Year == i)
                .ToListAsync();
                foreach (Booking booking in bookings)
                {
                    total += booking.TotalPrice;
                }
                revenueOfBookingsByMonths.Add(total);
            }

            return revenueOfBookingsByMonths;
        }

    }
}
