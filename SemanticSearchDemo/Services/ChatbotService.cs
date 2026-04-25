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
    public class ChatbotService : IChatbotService
    {
        private readonly Kernel _kernel;
        public ChatbotService(Kernel kernel)
        {
            _kernel = kernel;
        }

        public Task<string> CreateCustomerFromUserInput(CustomerProfile customerFromJson)
        {
            var service = customerFromJson.RecommendedService;

            if (string.IsNullOrWhiteSpace(service))
            {
                if (customerFromJson.Condition.Contains(Symptoms.COMA, StringComparison.OrdinalIgnoreCase) ||
                    customerFromJson.Condition.Contains(Symptoms.UNCONSCIOUSNESS, StringComparison.OrdinalIgnoreCase))
                {
                    service = Services.EMERGENCY;
                }
                else if (customerFromJson.Condition.Contains(Symptoms.CHEST_PAIN, StringComparison.OrdinalIgnoreCase) ||
                         customerFromJson.Condition.Contains(Symptoms.HEART_ATTACK, StringComparison.OrdinalIgnoreCase))
                {
                    service = Services.CARDIOLOGY;
                }
                else if (customerFromJson.Condition.Contains(Symptoms.FEVER, StringComparison.OrdinalIgnoreCase) ||
                         customerFromJson.Condition.Contains(Symptoms.INFECTION, StringComparison.OrdinalIgnoreCase))
                {
                    service = Services.INFECTIOUS_DISEASE;
                }
                else
                {
                    service = Services.GENERAL_PRACTITIONER;
                }
            }
        }
    }
}
