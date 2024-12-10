
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WindowsCRUD_UsingEF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a service collection
            var serviceCollection = new ServiceCollection();

            // Configure services
            ConfigureServices(serviceCollection);

            // Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve the form from the service provider and run the application
            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);




        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Register the DbContext
            services.AddDbContext<MyDogsContext>();

            // Register the repository as a service
            services.AddScoped<IRepository<Dog>, DogRepository>();

            // Register the form, with dependency injection for IRepository<Dog>
            services.AddScoped<Form1>();
        }
    }
}