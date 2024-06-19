using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Room
    {
        public double Price { get; set; }

        public string? HostelRoom { get; set; }

        public int BedRoom { get; set; }

        public virtual required Hostels HostelsRoom { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
