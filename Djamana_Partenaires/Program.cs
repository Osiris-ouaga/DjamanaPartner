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

            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmDashboard());
        }
    }
}
