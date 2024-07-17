using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class CityForm : Form
    {
        private readonly CitiesManagingMethods _citiesManagingMethods;

        private readonly GettingDjamanaPartner _gettingDjamanaPartner;

        public CityForm(CitiesManagingMethods citiesManagingMethods, GettingDjamanaPartner gettingDjamanaPartner)
        {

            _gettingDjamanaPartner = gettingDjamanaPartner;

            _citiesManagingMethods = citiesManagingMethods;

            InitializeComponent();
        }

        private async Task FillComboBoxWithCountries()
        {
            List<Country> countries = await _gettingDjamanaPartner.GetAllCountriesAsync();

            comboBoxCountries.DisplayMember = "Name";
            comboBoxCountries.ValueMember = "Id";

            comboBoxCountries.DataSource = countries;
        }

        private async Task FillDataGridViewAsync()
        {
            // Récupérer les données des villes
            List<Cities> cities = await _citiesManagingMethods.GetAllCityAsync();

            // Mapper les données vers le ViewModel
            List<DataGridCityViewModel> cityViewModels = cities.Select(c => DataGridCityViewModel.Create(c)).ToList();

            // Lier la liste à la DataGridView
            dataGridViewCities.DataSource = cityViewModels;

            // Masquer la colonne Id
            if (dataGridViewCities.Columns["Id"] != null)
            {
                dataGridViewCities.Columns["Id"].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewCities.Columns["Name"] != null)
            {
                dataGridViewCities.Columns["Name"].HeaderText = "Nom de la Ville";
            }

            if (dataGridViewCities.Columns["CountryName"] != null)
            {
                dataGridViewCities.Columns["CountryName"].HeaderText = "Nom du Pays";
            }

            if (dataGridViewCities.Columns["HostelNames"] != null)
            {
                dataGridViewCities.Columns["HostelNames"].Visible = false;
            }
        }


        private async void Cities_Load(object sender, EventArgs e)
        {
            await FillComboBoxWithCountries();

            await FillDataGridViewAsync();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            var newCity = new Cities
            {
                Name = textBoxCitiesName.Text,
                CountryId = comboBoxCountries.SelectedIndex
            };
            await _citiesManagingMethods.AddCityAsync(newCity);
            MessageBox.Show("City added successfully");
        }

    }
}
