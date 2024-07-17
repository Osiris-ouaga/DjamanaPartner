using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.UI.DataGridViewModel
{
    internal class DataGridHostelViewModel
    {
        public int Id { get; set; }
        public required string Designation { get; set; }
        public required string CityName { get; set; }
        public string? Adress { get; set; }
        public int? Phone { get; set; }
        public DateTime CreatedAt { get; set; }

        public static DataGridHostelViewModel Create(
            int hostelId,
            string designation,
            string cityName,
            string? address,
            int? phone,
            DateTime createdAt
        )
        {
            return new DataGridHostelViewModel
            {
                Id = hostelId,
                Designation = designation,
                CityName = cityName,
                Adress = address,
                Phone = phone,
                CreatedAt = createdAt
            };
        }
    }
}
