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

        public async Task<List<Cities>> GetAllCitiesAsync()
        {
            return await _dataContext.City
                 .Include(h => h.Country) // Inclure les villes associées
                 .ToListAsync();
        }

        public async Task<Cities> GetCityByIdAsync(int id)
        {
            return await _dataContext.City.FindAsync(id);
        }

        public async Task AddCityAsync(Cities city)
        {
            _dataContext.City.Add(city);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateCityAsync(Cities city)
        {
            _dataContext.City.Update(city);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteCityAsync(int id)
        {
            var city = await _dataContext.City.FindAsync(id);
            if (city != null)
            {
                _dataContext.City.Remove(city);
                await _dataContext.SaveChangesAsync();
            }
        }

        public Task<Cities> GetAllCityAsync()
        {
            throw new NotImplementedException();
        }
    }
}
