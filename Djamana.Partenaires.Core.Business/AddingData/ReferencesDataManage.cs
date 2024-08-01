using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;

namespace Djamana.Partenaires.Core.Business.AddingData
{
    public class ReferencesDataManage
    {
        private readonly IReferencesRepository _referencesService;

        public ReferencesDataManage(IReferencesRepository referencesService)
        {
            _referencesService = referencesService;
        }

        public async Task AddNewReferenceAsync(Partners references)
        {
            await _referencesService.AddReferencesAsync(references);
        }

        public async Task<List<Partners>> GetAllReferenceAsync()
        {
            return await _referencesService.GetAllReferencesAsync();
        }

        // Nouvelle méthode pour obtenir les référents classés par ville
        public async Task<Dictionary<Cities, List<Partners>>> GetReferencesGroupedByCityAsync()
        {
            return await _referencesService.GetReferencesGroupedByCityAsync();
        }

        // Nouvelle méthode pour obtenir les référents d'une ville spécifique
        public async Task<List<Partners>> GetReferencesByCityIdAsync(int cityId)
        {
            return await _referencesService.GetReferencesByCityIdAsync(cityId);
        }
    }
}

