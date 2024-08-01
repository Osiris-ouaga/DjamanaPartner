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
            try
            {
                // Récupérer l'entité existante
                var existingHostel = await _dataContext.Hostels.FindAsync(hostel.Id);
                if (existingHostel != null)
                {
                    // Mettre à jour les propriétés de l'entité existante
                    _dataContext.Entry(existingHostel).CurrentValues.SetValues(hostel);
                    await _dataContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Hostel not found");
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Erreur lors de la mise à jour: {ex.InnerException?.Message}");
                throw;
            }
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

        public async Task<Dictionary<string, int>> GetHotelCountByCityAsync()
        {
            return await _dataContext.Hostels
                .Where(h => h.City != null && h.City.Name != null)
                .GroupBy(h => h.City!.Name!)
                .Select(g => new
                {
                    CityName = g.Key,
                    HotelCount = g.Count()
                })
                .ToDictionaryAsync(g => g.CityName, g => g.HotelCount);
        }
    }
}
