namespace Djamana.Partenaires.Core.Data.Domain
{
    public class Partners
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string LastName { get; set; }

        public required int  PhoneContact { get; set; }

        public required string Adress { get; set; }

        public virtual required Cities City { get; set; }

        public virtual required Hostels Hostel { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
