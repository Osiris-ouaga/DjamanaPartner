namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Hostels
    {
        public int Id { get; set; }

        public required string Designation { get; set; }

        public virtual required Cities City { get; set; }

        public string? Adress { get; set; }

        public int? Phone { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
