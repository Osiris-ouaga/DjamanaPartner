using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.Core.Data.IRepository
{
    public interface ICityRepository
    {
        Task<List<Cities>> GetAllCountriesAsync();
        Task<Cities> GetCountryByIdAsync(int id);
        Task<Cities> GetAllCountryAsync();
        Task AddCountryAsync(Cities city);
        Task UpdateCountryAsync(Cities city);
        Task DeleteCountryAsync(int id);
    }
}
