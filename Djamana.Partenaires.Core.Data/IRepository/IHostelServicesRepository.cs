using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.Core.Data.IRepository
{
    public interface IHostelServicesRepository
    {

        Task<List<HostelServices>> GetAllHostelServicesAsync();

        Task<HostelServices> GetHostelServicesByIdAsync(int id);

        //Task<References> GetAllReferencesAsync();
        Task AddHostelServicesAsync(HostelServices references);

        Task UpdateHostelServicesAsync(HostelServices references);

        Task DeleteHostelServicesAsync(int id);
    }

}
