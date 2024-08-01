namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Cities
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country? Country { get; set; }

        public virtual ICollection<Hostels> Hostels { get; set; } = new List<Hostels>();

        public virtual ICollection<Partners> Partners { get; set; } = new List<Partners>();
    }

}
