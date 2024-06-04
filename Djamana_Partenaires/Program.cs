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
            ServiceConfigurator.ConfigureServices(serviceCollection, "Your_Connection_String_Here");

            // Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Use the service provider to create the main form with dependencies
            var mainForm = serviceProvider.GetRequiredService<FrmDashboard>();
            Application.Run(mainForm);
        }
    }
}
