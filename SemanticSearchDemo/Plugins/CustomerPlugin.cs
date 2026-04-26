using Microsoft.SemanticKernel;
using SemanticSearchDemo.Models;
using SemanticSearchDemo.Services.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SemanticSearchDemo.Plugins
{
    public class CustomerPlugin
    {
        private readonly ICustomerService _customerService;

        public CustomerPlugin(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [KernelFunction("create_customer_from_user_input")]
        [Description("Creates a customer profile from user input")]
        public async Task<string> CreateCustomerFromUserInput(
            [Description("User input from which to create the customer profile")] string userInput,
            Kernel kernel)
        {
            var prompt = $@"
                You are a medical booking assistant.
                Available Services:
                    -Cardiology
                    -Emergency
                    -Infectious Disease
                    -General Practitioner
                Create a customer profile from the following user input: {userInput}
                The profile should include the:
                    -Customer's condition, 
                    -Recommended service
                    -Preferred time.

                Format the output as JSON.
                Select the MOST appropriate service.
                Return ONLY one value from the list.
                
                return JSON only like:
                {{
                    ""Name"": """",
                    ""Condition"": """",
                    ""RecommendedService"": """",
                    ""PreferredTime"": """"
                }}
             ";

            var result = await kernel.InvokePromptAsync(prompt).ConfigureAwait(false);
            var customerFromJson = JsonSerializer.Deserialize<CustomerProfile>(result.ToString());
            var customer = _customerService.CreateCustomerFromUserInput(customerFromJson);
            return $"Customer created with ID {customer.Id}";

        }
    }
}
