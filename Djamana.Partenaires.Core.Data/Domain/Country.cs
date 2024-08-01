namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Country
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Cities> Cities { get; set; } = new List<Cities>();
    }

}
