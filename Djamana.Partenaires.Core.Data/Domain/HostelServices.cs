using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.Core.Data.Domain
{
    public class HostelServices
    {
        public int Id { get; set; }

        public  string? ServicesName { get; set; }

        public double Price { get; set; }   

        public virtual required Hostels HostelsServices { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
