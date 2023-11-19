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
    public class CustomerController
    {
        private BookingCarDbContext dbContext;
        public CustomerController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> customers = dbContext.Customers.ToList();
            return customers;
        }
        public async Task<Customer> AddCustomer(Customer customer)
        {
            var existedCustomer = await dbContext.Customers.Where(c => c.PhoneNumber == customer.PhoneNumber).FirstOrDefaultAsync();
            if (existedCustomer == null)
            {
                await dbContext.Customers.AddAsync(customer);
                await dbContext.SaveChangesAsync();

                return customer;
            }
            return null;

        }
        public async Task UpdateCustomer(Customer customer)
        {
            dbContext.Customers.Update(customer);
            await dbContext.SaveChangesAsync();
        }
        public async Task DeleteCustomer(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            await dbContext.SaveChangesAsync();
        }
        public async Task<Customer> GetCustomerByPhoneNumber(string phoneNumber)
        {
            var existedCustomer = await dbContext.Customers.Where(c => c.PhoneNumber == phoneNumber).FirstOrDefaultAsync();
            if (existedCustomer != null)
            {
                return existedCustomer;
            }
            return null;
        }
    }
}
