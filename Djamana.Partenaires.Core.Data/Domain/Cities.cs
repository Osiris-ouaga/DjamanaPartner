namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Cities
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public virtual required Country Countries { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
