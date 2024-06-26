using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using System;
using System.Windows.Forms;
using System.IO;
using EmployeeClock.DAL.Services;
using EmployeeClock.DAL;

namespace EmployeeClock
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Build the configuration
            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secrets.json", optional: true) // Add secrets.json
                .Build();

            // Read a value from the configuration
            string connString = builder["ConnectionString"];
            Console.WriteLine($"The secret value is: {connString}");

            // Initialize the database manager and seed service
            DatabaseManager dbManager = new DatabaseManager(connString);
            SeedService seedService = new SeedService(dbManager);

            // Ensure the database is set up and seeded
            seedService.EnsureDatabaseSetup();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormHandler formHandler = new FormHandler(dbManager);
            formHandler.ShowForm("LoginForm", false);
            Application.Run();
        }
    }
}
