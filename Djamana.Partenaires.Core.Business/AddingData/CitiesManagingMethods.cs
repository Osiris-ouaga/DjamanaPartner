using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Djamana.Partenaires.Core.Data.Repository;

namespace Djamana.Partenaires.Core.Business.AddingData
{
    public class CitiesManagingMethods
    {
        private readonly ICityRepository _cityService;

        public CitiesManagingMethods(ICityRepository cityService)
        {
            _cityService = cityService;
        }

        public async Task AddCityAsync(Cities city)
        {
            await _cityService.AddCityAsync(city);
        }

        public async Task<List<Cities>> GetAllCityAsync()
        {
            return await _cityService.GetAllCitiesAsync();
        }

        public async Task<Dictionary<string, int>> GetCityCountByCountryAsync()
        {
            return await _cityService.GetCityCountByCountryAsync();
        }

        public async Task UpdatingCityAsync(Cities city)
        {
            await _cityService.UpdateCityAsync (city);
        }

        public async Task DeletingCityAsync(int Id)
        {
            await _cityService.DeleteCityAsync(Id);
        }

    }
}
