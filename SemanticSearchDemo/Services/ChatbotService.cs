using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticSearchDemo.Services
{
    public class ChatbotService
    {
        private readonly Kernel _kernel;
        public ChatbotService(Kernel kernel)
        {
            _kernel = kernel;
        }

        
    }
}
