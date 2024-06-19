using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.Core.Data.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _dataContext;

        public CityRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Cities>> GetAllCountriesAsync()
        {
            return await _dataContext.City.ToListAsync();
        }

        public async Task<Cities> GetCountryByIdAsync(int id)
        {
            return await _dataContext.City.FindAsync(id);
        }

        public async Task AddCountryAsync(Cities city)
        {
            _dataContext.City.Add(city);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateCountryAsync(Cities city)
        {
            _dataContext.City.Update(city);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteCountryAsync(int id)
        {
            var city = await _dataContext.City.FindAsync(id);
            if (city != null)
            {
                _dataContext.City.Remove(city);
                await _dataContext.SaveChangesAsync();
            }
        }

        public Task<Cities> GetAllCountryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
