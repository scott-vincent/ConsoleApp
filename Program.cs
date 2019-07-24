using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var dbSection = configuration.GetSection("DynamoDB");
            var accountSection = configuration.GetSection("Account");

            Console.WriteLine("AccessKey: " + dbSection["AccessKey"]);
            Console.WriteLine("Secret: " + dbSection["Secret"]);
            Console.WriteLine("Location: " + dbSection["Location"]);

            Console.WriteLine("Environment: " + accountSection["Environment"]);
            Console.WriteLine("userId: " + accountSection["UserId"]);
        }
    }
}