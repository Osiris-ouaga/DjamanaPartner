using Djamana.Partenaires.Core.Business;
using Microsoft.Extensions.DependencyInjection;

namespace Djamana_Partenaires
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Set up application configuration
            ApplicationConfiguration.Initialize();

            // Configure services
            var serviceCollection = new ServiceCollection();
            ServiceConfigurator.ConfigureServices(serviceCollection, "Server=DESKTOP-LBN9HF5\\SQLEXPRESS; Database=DjamaPartner; Trusted_Connection=true; TrustServerCertificate=true;");

            // Register the form in the WinForms project
            serviceCollection.AddTransient<FrmDashboard>();

            // Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Use the service provider to create the main form with dependencies
            var mainForm = serviceProvider.GetRequiredService<FrmDashboard>();
            Application.Run(mainForm);

            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrmDashboard());
        }
    }
}
