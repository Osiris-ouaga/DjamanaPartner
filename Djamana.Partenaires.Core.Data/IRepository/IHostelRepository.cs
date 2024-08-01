using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.Core.Data.IRepository
{
    public interface IHostelRepository
    {
        Task<List<Hostels>> GetAllHotelsAsync();

        Task<Hostels> GetHotelsByIdAsync(int id);

        //Task<Hostels> GetAllHotelsAsync();

        Task AddHotelsAsync(Hostels hostel);

        Task UpdateHotelsAsync(Hostels hostel);

        Task DeleteHotelsAsync(int id);

        Task<Dictionary<string, int>> GetHotelCountByCityAsync();
    }
}
