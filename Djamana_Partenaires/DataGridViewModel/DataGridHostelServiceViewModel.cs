using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.UI.DataGridViewModel
{
    public class DataGridHostelServiceViewModel
    {
        public int Id { get; set; }

        public required string Designation { get; set; }

        public required string Price { get; set; }

        public string? HostelName { get; set; }

        public DateTime CreatedAt { get; set; }

        public static DataGridHostelServiceViewModel Create(
            int hostelId,
            string designation,
            string price,
            string? hostelName,
            DateTime createdAt
        )
        {
            return new DataGridHostelServiceViewModel
            {
                Id = hostelId,
                Designation = designation,
                Price = price,
                HostelName = hostelName,
                CreatedAt = createdAt
            };
        }
    }
}
