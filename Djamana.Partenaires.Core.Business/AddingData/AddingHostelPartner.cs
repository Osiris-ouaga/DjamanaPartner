﻿using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;

namespace Djamana.Partenaires.Core.Business.AddingData
{
    public class AddingHostelPartner
    {
        private readonly ICountryRepository _countryService;

        public AddingHostelPartner(ICountryRepository countryService)
        {
            _countryService = countryService;
        }

        public async Task AddCountryAsync(Country country)
        {
            await _countryService.AddCountryAsync(country);
        }

        public async Task UpdateCountryAsync(Country country)
        {
            await _countryService.UpdateCountryAsync(country);
        }


        public async Task DeleteCountryAsync(int Id)
        {
            await _countryService.DeleteCountryAsync(Id);
        }

    }
}
