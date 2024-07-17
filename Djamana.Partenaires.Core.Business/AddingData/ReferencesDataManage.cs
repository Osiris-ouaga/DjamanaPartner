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
        // Other methods to interact with CountryService can be added here
    }
}

