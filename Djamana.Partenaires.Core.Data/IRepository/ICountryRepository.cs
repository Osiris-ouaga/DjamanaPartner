using Djamana.Partenaires.Core.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.Core.Data.IRepository
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountriesAsync();
        Task<Country> GetCountryByIdAsync(int id);
        Task AddCountryAsync(Country country);
        Task UpdateCountryAsync(Country country);
        Task DeleteCountryAsync(int id);
    }
}
