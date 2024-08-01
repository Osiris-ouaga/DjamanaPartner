using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.Core.Data.Repository
{
    public class HostelServicesRepository : IHostelServicesRepository
    {
        private readonly DataContext _dataContext;

        public HostelServicesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<HostelServices>> GetAllHostelServicesAsync()
        {
            return await _dataContext.HostelServices
                                     .Include(hs => hs.Hostel) // Inclure les informations sur l'hôtel
                                     .ToListAsync();
        }

        public async Task<HostelServices> GetHostelServicesByIdAsync(int id)
        {
            return await _dataContext.HostelServices.FindAsync(id);
        }

        public async Task AddHostelServicesAsync(HostelServices hostelServices)
        {
            _dataContext.HostelServices.Add(hostelServices);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateHostelServicesAsync(HostelServices hostelServices)
        {
            _dataContext.HostelServices.Update(hostelServices);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteHostelServicesAsync(int id)
        {
            var hostelServices = await _dataContext.HostelServices.FindAsync(id);
            if (hostelServices != null)
            {
                _dataContext.HostelServices.Remove(hostelServices);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
