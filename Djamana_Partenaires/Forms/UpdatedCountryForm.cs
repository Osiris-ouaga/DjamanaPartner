using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class UpdatedCountryForm : Form
    {
        private int _countryId;

        private readonly AddingHostelPartner _addingHostelPartner;

        public UpdatedCountryForm(int countryId, string countryName, DateTime createdAt, AddingHostelPartner addingHostelPartner)
        {
            InitializeComponent();

            _countryId = countryId;

            textBoxCountryName.Text = countryName;

            dateTimePicker1.Value = createdAt;

            _addingHostelPartner = addingHostelPartner;
        }

        private async void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                // Valider les champs de saisie
                string countryName = textBoxCountryName.Text.Trim();
                if (string.IsNullOrEmpty(countryName))
                {
                    MessageBox.Show("Le nom du pays ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime createdAt = dateTimePicker1.Value;
                if (createdAt > DateTime.Now)
                {
                    MessageBox.Show("La date de création ne peut pas être dans le futur.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Créer un nouvel objet Country
                var newCountry = new Country
                {
                    Name = countryName,
                    CreatedAt = createdAt
                };

                // Ajouter le nouveau pays
                await _addingHostelPartner.UpdateCountryAsync(newCountry);
                MessageBox.Show("Country updated successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialiser les champs de saisie
                textBoxCountryName.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout du pays: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
            }
        }
    }
}
