using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Djamana.Partenaires.Core.Business
{
    public static class ServiceConfigurator
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            // Configure the DbContext with your connection string
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));

            
        }
    }
}
