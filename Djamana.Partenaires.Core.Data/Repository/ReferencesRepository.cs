using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.Core.Data.Repository
{
    public class ReferencesRepository : IReferencesRepository
    {
        private readonly DataContext _dataContext;

        public ReferencesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Partners>> GetAllReferencesAsync()
        {
            return await _dataContext.Reference
                                     .Include(r => r.City)
                                     .Include(r => r.Hostel)
                                     .ToListAsync();
        }

        public async Task<Partners> GetReferencesByIdAsync(int id)
        {
            return await _dataContext.Reference.FindAsync(id);
        }

        public async Task AddReferencesAsync(Partners partner)
        {
            _dataContext.Reference.Add(partner);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateReferencesAsync(Partners partner)
        {
            _dataContext.Reference.Update(partner);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteReferencesAsync(int id)
        {
            var partners = await _dataContext.Reference.FindAsync(id);
            if (partners != null)
            {
                _dataContext.Reference.Remove(partners);
                await _dataContext.SaveChangesAsync();
            }
        }


    }
}
