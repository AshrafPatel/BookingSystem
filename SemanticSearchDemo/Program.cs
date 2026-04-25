using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using SemanticSearchDemo.Services;

namespace SemanticSearchDemo
{
    public class Program
    {
        static void Main(string[] args)
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
                builder.AddOpenAIChatCompletion(model, apiKey);
                var kernel = builder.Build();
                var chatbot = new ChatbotService(kernel);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

           
            var fileService = new FileService();

            string filePath = "output.txt";
        }
    }
}
