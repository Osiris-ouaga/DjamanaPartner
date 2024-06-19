using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Hostels
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public virtual required Cities City { get; set; }

        public string? Adress { get; set; }

        public int? PhoneNumber { get; set; }

        public virtual required References HostelsReferences { get; set; }


        public DateTime CreatedAt { get; set; }
    }
}
