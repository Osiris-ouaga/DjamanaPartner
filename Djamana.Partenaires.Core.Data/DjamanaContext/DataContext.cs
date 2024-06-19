using Djamana.Partenaires.Core.Data.DjamanaContext.Configuration.DjamanaSettings;
using Djamana.Partenaires.Core.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Cities> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CountrySettings());
        }
    }
}
