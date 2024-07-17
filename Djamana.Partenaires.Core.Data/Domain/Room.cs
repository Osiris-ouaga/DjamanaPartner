using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Room
    {
        public int Id { get; set; }

        public string? TypeRoom { get; set; }

        public string? TypeBed { get; set; }

        public int BedRoom { get; set; }

        public virtual required Hostels HostelsRoom { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
