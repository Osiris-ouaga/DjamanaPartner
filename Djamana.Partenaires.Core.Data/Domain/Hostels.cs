namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Hostels
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public int CityId { get; set; }  // Ensure this property exists
        public string Adress { get; set; }
        public int? Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Cities City { get; set; }
        public virtual ICollection<HostelServices> HostelServices { get; set; } = new List<HostelServices>();
    }
}
