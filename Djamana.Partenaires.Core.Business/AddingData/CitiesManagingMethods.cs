using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;

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
    }
}
