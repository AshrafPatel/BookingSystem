using Microsoft.SemanticKernel;
using SemanticSearchDemo.Services.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticSearchDemo.Plugins
{
    public class CustomerPlugin
    {
        private readonly IChatbotService _chatbotService;

        public CustomerPlugin(IChatbotService chatbotService)
        {
            _chatbotService = chatbotService;
        }

        [KernelFunction("create_customer_from_user_input")]
        [Description("Creates a customer profile from user input")]
        public async Task<string> CreateCustomerFromUserInput(string userInput)
        {

        }
    }
}
