using System.Collections.Generic;
using System.Threading.Tasks;
using OnBoarding.Models;

namespace OnBoarding.Services
{
    public interface ICredentialsService
    {
        Task CreateCredentials(Customer customer);
        IEnumerable<Customer> GetAllSignUp();
        Task<Customer> GetSignUp(int id);
    }
}