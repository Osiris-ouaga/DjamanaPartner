using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;

namespace Djamana.Partenaires.Core.Business.GettingData
{
    public class GettingDjamanaPartner
    {
        private readonly ICountryRepository _countryService;

        public GettingDjamanaPartner(ICountryRepository countryService)
        {
            _countryService = countryService;
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            return await _countryService.GetAllCountriesAsync();
        }
    }
}
