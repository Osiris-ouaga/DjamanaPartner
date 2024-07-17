using System;
using System.Collections.Generic;
using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.UI.DataGridViewModel
{
    public class DataGridCityViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? CountryName { get; set; }
        public List<string>? HostelNames { get; set; }

        public static DataGridCityViewModel Create(Cities city)
        {
            return new DataGridCityViewModel
            {
                Id = city.Id,
                Name = city.Name,
                CountryName = city.Country.Name,
                HostelNames = city.Hostels?.Select(h => h.Designation).ToList()!
            };
        }
    }
}
