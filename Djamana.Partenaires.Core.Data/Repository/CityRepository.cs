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
            var existingCity = await _dataContext.City.FindAsync(city.Id);
            if (existingCity != null)
            {
                existingCity.Name = city.Name;
                existingCity.CountryId = city.CountryId;

                _dataContext.City.Update(existingCity);
                await _dataContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("City not found");
            }
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

        public async Task<Dictionary<string, int>> GetCityCountByCountryAsync()
        {
            // Cette méthode doit interagir avec votre base de données ou votre service pour obtenir les informations
            var result = await _dataContext.Countries
                .Include(c => c.Cities)
                .Select(c => new
                {
                    CountryName = c.Name,
                    CityCount = c.Cities.Count
                })
                .ToDictionaryAsync(c => c.CountryName, c => c.CityCount);

            return result;
        }
    }
}
