using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class UpdatingHostelForm : Form
    {
        private int _hostelId;
        private string _hostelDesignation;
        private string _cityName;
        private string? _hostelAdress;
        private int? _hostelPhone;
        private DateTime _hostelCreatedAt;

        private readonly CitiesManagingMethods _citiesManagingMethods;
        private readonly GettingDjamanaPartner _gettingDjamanaPartner;
        private readonly HostelDataManaging _hostelDataManaging;


        public UpdatingHostelForm(int hostelId, string hostelDesignation, string cityName, string? hostelAdress, int? hostelPhone, DateTime hostelCreatedAt,
            CitiesManagingMethods citiesManagingMethods, HostelDataManaging hostelDataManaging)
        {
            InitializeComponent();

            _hostelId = hostelId;
            _hostelDesignation = hostelDesignation;
            _cityName = cityName;
            _hostelAdress = hostelAdress;
            _hostelPhone = hostelPhone;
            _hostelCreatedAt = hostelCreatedAt;

            _citiesManagingMethods = citiesManagingMethods;
            _hostelDataManaging = hostelDataManaging;

            // Initialiser les champs avec les valeurs actuelles
            textBoxName.Text = _hostelDesignation;
            textBoxAdress.Text = _hostelAdress ?? string.Empty;
            textBoxPhoneNumber.Text = _hostelPhone.HasValue ? _hostelPhone.Value.ToString() : string.Empty;
            dateTimePickerReferences.Value = _hostelCreatedAt;

            // Charger les villes dans le comboBox
            LoadCitiesAsync();
        }

        private async Task LoadCitiesAsync()
        {
            var cities = await _citiesManagingMethods.GetAllCityAsync();
            comboBoxCity.DataSource = cities;
            comboBoxCity.DisplayMember = "Name";
            comboBoxCity.ValueMember = "Id";

            // Sélectionner la ville associée
            var selectedCity = cities.FirstOrDefault(c => c.Name == _cityName);
            if (selectedCity != null)
            {
                comboBoxCity.SelectedValue = selectedCity.Id;
            }
        }

        private async void buttonValidate_Click(object sender, EventArgs e)
        {
            // Vérifier les champs obligatoires
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdress.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) ||
                comboBoxCity.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérer les valeurs modifiées
            var updatedHostelDesignation = textBoxName.Text;
            var updatedHostelAdress = textBoxAdress.Text;
            var updatedHostelPhone = int.TryParse(textBoxPhoneNumber.Text, out var phone) ? (int?)phone : null;
            var updatedCityId = (int)comboBoxCity.SelectedValue;
            var updatedCreatedAt = dateTimePickerReferences.Value;

            // Créer un objet Hostels avec les nouvelles valeurs
            var updatedHostel = new Hostels
            {
                Id = _hostelId,
                Designation = updatedHostelDesignation,
                Adress = updatedHostelAdress,
                Phone = updatedHostelPhone,
                CreatedAt = updatedCreatedAt,
                CityId = updatedCityId
            };

            try
            {
                // Appeler la méthode pour mettre à jour l'hôtel
                await _hostelDataManaging.UpdatingHostelAsync(updatedHostel);

                MessageBox.Show("Hôtel mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermer le formulaire après la mise à jour
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour de l'hôtel: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
