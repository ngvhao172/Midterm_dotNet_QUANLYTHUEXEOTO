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
    public class BookingController
    {
        private BookingCarDbContext dbContext;
        public BookingController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddBooking(Booking booking)
        {
            await dbContext.Bookings.AddAsync(booking);
            await dbContext.SaveChangesAsync();
        }
        public List<Booking> GetAllBookings()
        {
            var bookings = dbContext.Bookings.Include(c => c.Customer).Include(c => c.Car).ThenInclude(c => c.CarType).ToList();
            return bookings;
        }
    }
}
