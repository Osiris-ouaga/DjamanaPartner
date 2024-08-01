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

        public async Task<List<Country>> GetAllCountriesAsync()
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
            // Récupérer le pays à supprimer
            var country = await _dataContext.Countries
                .Include(c => c.Cities)
                    .ThenInclude(city => city.Hostels)
                        .ThenInclude(hostel => hostel.HostelServices)
                .Include(c => c.Cities)
                    .ThenInclude(city => city.Partners)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (country != null)
            {
                // Supprimer les partenaires associés
                foreach (var city in country.Cities)
                {
                    _dataContext.Reference.RemoveRange(city.Partners);
                }

                // Supprimer les services d'hôtel associés
                foreach (var city in country.Cities)
                {
                    foreach (var hostel in city.Hostels)
                    {
                        _dataContext.HostelServices.RemoveRange(hostel.HostelServices);
                    }
                }

                // Supprimer les hôtels associés
                foreach (var city in country.Cities)
                {
                    _dataContext.Hostels.RemoveRange(city.Hostels);
                }

                // Supprimer les villes associées
                _dataContext.City.RemoveRange(country.Cities);

                // Supprimer le pays
                _dataContext.Countries.Remove(country);

                // Sauvegarder les changements
                await _dataContext.SaveChangesAsync();
            }
        }


        public Task<Country> GetAllCountryAsync()
        {
            throw new NotImplementedException();
        }
    }
}
