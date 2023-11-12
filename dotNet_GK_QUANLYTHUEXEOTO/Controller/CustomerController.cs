using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_GK_QUANLYTHUEXEOTO.Controller
{
    public class CustomerController
    {
        private BookingCarDbContext dbContext;
        public CustomerController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Customer> GetAllCustomer()
        {
            var customers = dbContext.Customers.ToList();
            return customers;
        }
        public async Task AddCustomer(Customer customer)
        {
            await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();
        }
    }
}
