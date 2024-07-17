using System;
using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.UI.DataGridViewModel
{
    internal class DataGridPartnerViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int PhoneContact { get; set; }
        public string? Adress { get; set; }
        public string? CityName { get; set; }
        public string? HostelName { get; set; }
        public DateTime CreatedAt { get; set; }

        public static DataGridPartnerViewModel Create(Partners partner)
        {
            return new DataGridPartnerViewModel
            {
                Id = partner.Id,
                Name = partner.Name,
                LastName = partner.LastName,
                PhoneContact = partner.PhoneContact,
                Adress = partner.Adress,
                CityName = partner.City.Name,
                HostelName = partner.Hostel.Designation,
                CreatedAt = partner.CreatedAt
            };
        }
    }
}
