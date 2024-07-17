using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;

namespace Djamana.Partenaires.Core.Business.AddingData
{
    public class HostelDataManaging
    {
        private readonly IHostelRepository _hostelsService;

        public HostelDataManaging(IHostelRepository hostelsService)
        {
            _hostelsService = hostelsService;
        }

        public async Task AddHostelAsync(Hostels hostels)
        {
            await _hostelsService.AddHotelsAsync(hostels);
        }

        public async Task<List<Hostels>> GetAllHotelsAsync()
        {
            return await _hostelsService.GetAllHotelsAsync();
        }
    }
}
