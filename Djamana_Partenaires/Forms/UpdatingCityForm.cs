using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class UpdatingCityForm : Form
    {
        private int _cityId;
        private string _cityName;
        private string _countryName;
        private readonly CitiesManagingMethods _citiesManagingMethods;
        private readonly GettingDjamanaPartner _gettingDjamanaPartner;

        public UpdatingCityForm(int cityId, string cityName, string countryName,
            CitiesManagingMethods citiesManagingMethods, GettingDjamanaPartner gettingDjamanaPartner)
        {
            InitializeComponent();

            _cityId = cityId;
            _cityName = cityName;
            _countryName = countryName;
            _citiesManagingMethods = citiesManagingMethods;
            _gettingDjamanaPartner = gettingDjamanaPartner;

            textBoxCitiesName.Text = _cityName;
            comboBoxCountries.Text = _countryName;

            LoadCountriesAsync().GetAwaiter().GetResult();
        }

        private async Task LoadCountriesAsync()
        {
            try
            {
                var countries = await _gettingDjamanaPartner.GetAllCountriesAsync();
                comboBoxCountries.DataSource = countries;
                comboBoxCountries.DisplayMember = "Name";
                comboBoxCountries.ValueMember = "Id";

                var selectedCountry = countries.FirstOrDefault(c => c.Name == _countryName);
                if (selectedCountry != null)
                {
                    comboBoxCountries.SelectedValue = selectedCountry.Id;
                }
                else
                {
                    MessageBox.Show("Le pays associé à cette ville n'a pas été trouvé dans la liste des pays.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors du chargement des pays : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedCityName = textBoxCitiesName.Text;
                if (string.IsNullOrWhiteSpace(updatedCityName))
                {
                    MessageBox.Show("Le nom de la ville ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBoxCountries.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un pays valide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedCountryId = (int)comboBoxCountries.SelectedValue;

                var updatedCity = new Cities
                {
                    Id = _cityId,
                    Name = updatedCityName,
                    CountryId = selectedCountryId
                };

                await _citiesManagingMethods.UpdatingCityAsync(updatedCity);

                MessageBox.Show("La ville a été mise à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors de la mise à jour de la ville : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
