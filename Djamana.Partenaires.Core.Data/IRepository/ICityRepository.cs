using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.Core.Data.IRepository
{
    public interface ICityRepository
    {
        Task<List<Cities>> GetAllCitiesAsync();

        Task<Cities> GetCityByIdAsync(int id);

        Task<Cities> GetAllCityAsync();

        Task AddCityAsync(Cities city);

        Task UpdateCityAsync(Cities city);

        Task DeleteCityAsync(int id);
    }
}
