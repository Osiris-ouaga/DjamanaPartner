using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.Core.Data.IRepository
{
    public interface IReferencesRepository
    {
        Task<List<Partners>> GetAllReferencesAsync();

        Task<Partners> GetReferencesByIdAsync(int id);
        //Task<References> GetAllReferencesAsync();
        Task AddReferencesAsync(Partners references);

        Task UpdateReferencesAsync(Partners references);

        Task DeleteReferencesAsync(int id);
    }
}
