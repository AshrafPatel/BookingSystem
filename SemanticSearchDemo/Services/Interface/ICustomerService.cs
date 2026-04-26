using SemanticSearchDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticSearchDemo.Services.Interface
{
    public interface ICustomerService
    {
        Task<Customer> CreateCustomerFromUserInput(CustomerProfile customerFromJson);
    }
}
