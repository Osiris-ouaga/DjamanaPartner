namespace Djamana.Partenaires.UI.DataGridViewModel
{
    public class DataGridCountryViewModel
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public DateTime CreatedAt { get; set; }

       public static DataGridCountryViewModel Create(
           int countryId,
           string contryName,
           DateTime savingDate
           )
      
        {
            return new DataGridCountryViewModel
            {
                Id = countryId,
                Name = contryName,
                CreatedAt = savingDate
            };
        }

    }
}

