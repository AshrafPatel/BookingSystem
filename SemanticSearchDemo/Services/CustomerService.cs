using Azure.Core;
using Microsoft.SemanticKernel;
using SemanticSearchDemo.Constants;
using SemanticSearchDemo.Models;
using SemanticSearchDemo.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticSearchDemo.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {
        }

        public async Task<Customer> CreateCustomerFromUserInput(CustomerProfile customerFromJson)
        {
            var service = customerFromJson.RecommendedService;

            if (string.IsNullOrWhiteSpace(service))
            {
                if (customerFromJson.Condition.Contains(Symptoms.COMA, StringComparison.OrdinalIgnoreCase) ||
                    customerFromJson.Condition.Contains(Symptoms.UNCONSCIOUSNESS, StringComparison.OrdinalIgnoreCase))
                {
                    service = Specialist.EMERGENCY;
                }
                else if (customerFromJson.Condition.Contains(Symptoms.CHEST_PAIN, StringComparison.OrdinalIgnoreCase) ||
                         customerFromJson.Condition.Contains(Symptoms.HEART_ATTACK, StringComparison.OrdinalIgnoreCase))
                {
                    service = Specialist.CARDIOLOGY;
                }
                else if (customerFromJson.Condition.Contains(Symptoms.FEVER, StringComparison.OrdinalIgnoreCase) ||
                         customerFromJson.Condition.Contains(Symptoms.INFECTION, StringComparison.OrdinalIgnoreCase))
                {
                    service = Specialist.INFECTIOUS_DISEASE;
                }
                else
                {
                    service = Specialist.GENERAL_PRACTITIONER;
                }
            }

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = customerFromJson.Name,
                Condition = customerFromJson.Condition,
                RecommendedService = service,
                PreferredTime = customerFromJson.PreferredTime
            };

            return customer;
        }
    }
}
