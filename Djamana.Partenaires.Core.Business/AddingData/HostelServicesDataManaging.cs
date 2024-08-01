using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.Core.Data.IRepository;
using Djamana.Partenaires.Core.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.Core.Business.AddingData
{
    public class HostelServicesDataManaging
    {
        private readonly IHostelServicesRepository _hostelService;

        public HostelServicesDataManaging(IHostelServicesRepository hostelsService)
        {
            _hostelService = hostelsService;
        }

        public async Task AddHostelServicesAsync(HostelServices services)
        {
            await _hostelService.AddHostelServicesAsync(services);
        }

        public async Task<HostelServices> GetHostelServicesByIdAsync(int id)
        {
            return await _hostelService.GetHostelServicesByIdAsync(id);
        }

        public async Task<List<HostelServices>> GetAllHostelServicesAsync()
        {
            return await _hostelService.GetAllHostelServicesAsync();
        }
    }
}
