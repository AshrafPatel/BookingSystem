using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
using SemanticSearchDemo.Plugins;
using SemanticSearchDemo.Services;
using SemanticSearchDemo.Services.Interface;

namespace SemanticSearchDemo
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            var apiKey = config["AI:ApiKey"];
            var model = config["AI:Model"];

            var builder = Kernel.CreateBuilder();

            try
            {
                if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(model))
                {
                    throw new Exception("API key or model is not configured. Please check your user secrets.");
                }
                //SETUP
                builder.Services.AddSingleton<ICustomerService, CustomerService>();
                builder.Services.AddSingleton<CustomerPlugin>();
                builder.AddOpenAIChatCompletion(model, apiKey);
                var kernel = builder.Build();

                //START SERVICE
                Console.WriteLine("AI Booking Assistant (type 'exit' to quit)\n");
                string input = string.Empty;
                input = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("> ");

                    if (string.IsNullOrWhiteSpace(input))
                        continue;

                    if (input?.ToLower() == "exit")
                        break;
                }

                //INVOKE PROMPT
                var prompt = $@"
                    You are an AI assistant for a booking system.

                    If the user is trying to create a customer profile,
                    call the function 'create_customer_from_user_input'.

                    User input:
                    {input}
                ";

                var result = await kernel.InvokePromptAsync(prompt).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Initialize file service and set file path
            var fileService = new FileService();
            string filePath = "output.txt";
        }
    }
}
