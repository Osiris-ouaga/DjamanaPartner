using Djamana.Partenaires.Core.Data;
using Djamana.Partenaires.Core.Data.IRepository;
using Djamana.Partenaires.Core.Data.Repository;
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

            // Register the repositories
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IHostelRepository, HostelRepository>();
            services.AddTransient<IReferencesRepository, ReferencesRepository>();
            services.AddTransient<IHostelServicesRepository, HostelServicesRepository>();

            // Register the business logic services
            services.AddTransient<AddingData.AddingHostelPartner>();
            services.AddTransient<GettingData.GettingDjamanaPartner>();
            services.AddTransient<AddingData.CitiesManagingMethods>();
            services.AddTransient<AddingData.HostelDataManaging>();
            services.AddTransient<AddingData.ReferencesDataManage>();
            services.AddTransient<AddingData.HostelServicesDataManaging>();

        }
    }
}
