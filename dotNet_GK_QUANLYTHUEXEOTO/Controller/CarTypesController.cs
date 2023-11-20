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
    public class CarTypesController
    {
        private BookingCarDbContext dbContext;
        public CarTypesController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<CarType>> GetAllCarTypes()
        {
            var carTypes = await dbContext.CarTypes.ToListAsync();
            return carTypes;
        }
        public CarType GetCarTypeByName(string name)
        {
            var carTypes = dbContext.CarTypes.Where(c => c.Name == name).FirstOrDefault();
            return carTypes;
        }
    }
}
