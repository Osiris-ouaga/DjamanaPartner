namespace Djamana.Partenaires.Core.Data.Domain
{
    public class HostelServices
    {
        public int Id { get; set; }

        public string ServicesName { get; set; }

        public double Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public int HostelId { get; set; }  // Foreign key for Hostels

        public virtual Hostels Hostel { get; set; }
    }

}
