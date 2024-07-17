using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class HostelForm : Form
    {
        private readonly CitiesManagingMethods _citiesManagingMethods;

        private readonly HostelDataManaging _hostelDataManagingMethods;

        public HostelForm(CitiesManagingMethods citiesManagingMethods, HostelDataManaging hostelDataManagingMethods)
        {
            _citiesManagingMethods = citiesManagingMethods;

            InitializeComponent();

            _hostelDataManagingMethods = hostelDataManagingMethods;
        }

        private async Task FillComboBoxWithCountries()
        {
            List<Cities> countries = await _citiesManagingMethods.GetAllCityAsync();

            comboBoxCity.DisplayMember = "Name";
            comboBoxCity.ValueMember = "Id";

            comboBoxCity.DataSource = countries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HostelServicesForm hostelServicesForm = new();
            hostelServicesForm.ShowDialog();
        }

        private void buttonHostelRoom_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new();
            roomForm.ShowDialog();
        }

        private async void HostelForm_Load(object sender, EventArgs e)
        {
            await FillComboBoxWithCountries();
            await FillDataGridViewAsync();
        }

        private async void buttonValidate_Click(object sender, EventArgs e)
        {
            // Récupérer l'objet Cities sélectionné dans le comboBox
            var selectedCity = comboBoxCity.SelectedItem as Cities;

            var newHostel = new Hostels
            {
                Designation = textBoxName.Text,
                City = selectedCity,
                Adress = textBoxAdress.Text,
                Phone = int.TryParse(textBoxPhoneNumber.Text, out var phoneNumber) ? phoneNumber : (int?)null,
                CreatedAt = dateTimePickerReferences.Value.Date,
            };

            await _hostelDataManagingMethods.AddHostelAsync(newHostel);
            MessageBox.Show("Hostel added successfully");
        }

        private async Task FillDataGridViewAsync()
        {
            // Récupérer les données des auberges
            List<Hostels> hostels = await _hostelDataManagingMethods.GetAllHotelsAsync();

            // Mapper les données vers le ViewModel
            List<DataGridHostelViewModel> hostelViewModels = hostels.Select(h => new DataGridHostelViewModel
            {
                Id = h.Id,
                Designation = h.Designation,
                CityName = h.City.Name, // Assurez-vous que la propriété `Name` de la ville est chargée
                Adress = h.Adress,
                Phone = h.Phone,
                CreatedAt = h.CreatedAt
            }).ToList();

            // Lier la liste à la DataGridView
            dataGridViewHostel.DataSource = hostelViewModels;

            // Masquer la colonne Id
            if (dataGridViewHostel.Columns["Id"] != null)
            {
                dataGridViewHostel.Columns["Id"].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewHostel.Columns["Designation"] != null)
            {
                dataGridViewHostel.Columns["Designation"].HeaderText = "Désignation";
            }

            if (dataGridViewHostel.Columns["CityName"] != null)
            {
                dataGridViewHostel.Columns["CityName"].HeaderText = "Ville";
            }

            if (dataGridViewHostel.Columns["Adress"] != null)
            {
                dataGridViewHostel.Columns["Adress"].HeaderText = "Adresse";
            }

            if (dataGridViewHostel.Columns["Phone"] != null)
            {
                dataGridViewHostel.Columns["Phone"].HeaderText = "Téléphone";
            }

            if (dataGridViewHostel.Columns["CreatedAt"] != null)
            {
                dataGridViewHostel.Columns["CreatedAt"].HeaderText = "Date de création";
            }
        }

    }
}
