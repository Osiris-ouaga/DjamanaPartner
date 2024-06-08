using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.Core.Data.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _dataContext;

        public CountryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await _dataContext.Countries.ToListAsync();
        }

        public async Task<Country> GetCountryByIdAsync(int id)
        {
            return await _dataContext.Countries.FindAsync(id);
        }

        public async Task AddCountryAsync(Country country)
        {
            _dataContext.Countries.Add(country);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateCountryAsync(Country country)
        {
            _dataContext.Countries.Update(country);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteCountryAsync(int id)
        {
            var country = await _dataContext.Countries.FindAsync(id);
            if (country != null)
            {
                _dataContext.Countries.Remove(country);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
