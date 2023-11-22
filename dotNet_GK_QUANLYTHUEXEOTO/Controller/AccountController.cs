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
    public class AccountController
    {
        private BookingCarDbContext dbContext;

        public AccountController(BookingCarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<(bool IsSuccessful, string FullName, string email)> Login(string email, string password)
        {
            var user = await dbContext.Accounts
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(c => c.EmployeeEmail == email && c.Password == password);

            if (user != null)
            {
                return (true, user.Employee.FullName, email);
            }
            else
            {
                return (false, null, email);
            }
        }

    }

}
