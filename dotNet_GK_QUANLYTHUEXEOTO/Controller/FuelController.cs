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
    public class FuelController
    {
        private BookingCarDbContext dbContext;
        public FuelController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Fuel GetFuelByName(string fuelName)
        {
            var car = dbContext.Fuels.Where(c => c.Name == fuelName).FirstOrDefault();
            return car;
        }
    }
}
