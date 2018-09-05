using OnBoarding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoarding.Services
{
    public class CredentialsService : ICredentialsService
    {
        private readonly OnBoardingContext _context;

        public CredentialsService(OnBoardingContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetAllSignUp()
        {
            return _context.Customer;
        }
        public async Task<Customer> GetSignUp(int id)
        {
            return await _context.Customer.FindAsync(id);
        }

        public async Task CreateCredentials(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();
        }
    }
}
