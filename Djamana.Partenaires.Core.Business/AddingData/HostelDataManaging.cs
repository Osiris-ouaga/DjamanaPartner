using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Djamana.Partenaires.Core.Data.Repository;

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

        public async Task<Hostels> GetHotelsByIdAsync(int id)
        {
            return await _hostelsService.GetHotelsByIdAsync(id);
        }

        public async Task<List<Hostels>> GetAllHotelsAsync()
        {
            return await _hostelsService.GetAllHotelsAsync();
        }

        public async Task<Dictionary<string, int>> GetHotelCountByCityAsync()
        {
            return await _hostelsService.GetHotelCountByCityAsync();
        }

        public async Task UpdatingHostelAsync(Hostels hostel)
        {
            await _hostelsService.UpdateHotelsAsync(hostel);
        }
    }
}
