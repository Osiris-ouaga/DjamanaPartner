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

        // Nouvelle méthode pour obtenir les référents classés par ville
        Task<Dictionary<Cities, List<Partners>>> GetReferencesGroupedByCityAsync();

        // Nouvelle méthode pour obtenir les référents d'une ville spécifique
        Task<List<Partners>> GetReferencesByCityIdAsync(int cityId);
    }
}
