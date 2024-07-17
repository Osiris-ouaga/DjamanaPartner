using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.Core.Data.Repository
{
    public class HostelRepository : IHostelRepository
    {
        private readonly DataContext _dataContext;

        public HostelRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Hostels>> GetAllHotelsAsync()
        {
            return await _dataContext.Hostels
                                     .Include(h => h.City) // Inclure les villes associées
                                     .ToListAsync();
        }

        public async Task<Hostels> GetHotelsByIdAsync(int id)
        {
            return await _dataContext.Hostels.FindAsync(id);
        }

        public async Task AddHotelsAsync(Hostels hostel)
        {
            try
            {
                _dataContext.Hostels.Add(hostel);
                await _dataContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Affichez les détails de l'exception interne
                Console.WriteLine($"Erreur lors de l'enregistrement: {ex.InnerException?.Message}");
                throw;
            }
        }


        public async Task UpdateHotelsAsync(Hostels hostel)
        {
            _dataContext.Hostels.Update(hostel);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteHotelsAsync(int id)
        {
            var hostel = await _dataContext.Hostels.FindAsync(id);
            if (hostel != null)
            {
                _dataContext.Hostels.Remove(hostel);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
