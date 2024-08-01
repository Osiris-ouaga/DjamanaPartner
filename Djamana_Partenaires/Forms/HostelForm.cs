using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using Djamana.Partenaires.UI.Helper;
using System.Windows.Forms.DataVisualization.Charting;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class HostelForm : Form
    {
        private const string DataGridIdColumn = "Id";

        private const string DataGridDesignationColumn = "Designation";

        private const string DataGridCityNameColumn = "CityName";

        private const string DataGridAdressColumn = "Adress";

        private const string DataGridPhoneColumn = "Phone";

        private const string DataGridCreatedAtColumn = "CreatedAt";

        private const string DataGridDesignationHeaderColumn = "Désignation";

        private const string DataGridCityHeaderColumn = "Ville";

        private const string DataGridAdressHeaderColumn = "Adresse";

        private const string DataGridPhoneHeaderColumn = "Téléphone";

        private const string DataGridCreatedAtHeaderColumn = "Date";

        private readonly CitiesManagingMethods _citiesManagingMethods;

        private readonly HostelDataManaging _hostelDataManagingMethods;

        private readonly HostelServicesDataManaging _hostelServicesDataManagingMethods;


        public HostelForm(CitiesManagingMethods citiesManagingMethods, HostelDataManaging hostelDataManagingMethods,
            HostelServicesDataManaging hostelServicesDataManaging)
        {
            _citiesManagingMethods = citiesManagingMethods;

            InitializeComponent();

            _hostelDataManagingMethods = hostelDataManagingMethods;

            _hostelServicesDataManagingMethods = hostelServicesDataManaging;

        }

        private async Task FillComboBoxWithCountries()
        {
            List<Cities> countries = await _citiesManagingMethods.GetAllCityAsync();

            // Ajouter un élément par défaut
            countries.Insert(0, new Cities { Id = 0, Name = "Sélectionner" });

            comboBoxCity.DisplayMember = "Name";
            comboBoxCity.ValueMember = "Id";

            comboBoxCity.DataSource = countries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HostelServicesForm hostelServicesForm = new(_hostelDataManagingMethods,
                _hostelServicesDataManagingMethods);
            hostelServicesForm.ShowDialog();
        }

        private async void HostelForm_Load(object sender, EventArgs e)
        {
            await FillComboBoxWithCountries();
            await FillDataGridViewAsync();
            await FillChartAsync();
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

            // Recharger le formulaire
            await ReloadFormAsync();
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

            // Appliquer le style à la DataGridView
            DataGridViewHelper.StyleDataGridView(dataGridViewHostel);

            // Masquer la colonne Id
            if (dataGridViewHostel.Columns[DataGridIdColumn] != null)
            {
                dataGridViewHostel.Columns[DataGridIdColumn].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewHostel.Columns[DataGridDesignationColumn] != null)
            {
                dataGridViewHostel.Columns[DataGridDesignationColumn].HeaderText = DataGridDesignationHeaderColumn;
            }

            if (dataGridViewHostel.Columns[DataGridCityNameColumn] != null)
            {
                dataGridViewHostel.Columns[DataGridCityNameColumn].HeaderText = DataGridCityHeaderColumn;
            }

            if (dataGridViewHostel.Columns[DataGridAdressColumn] != null)
            {
                dataGridViewHostel.Columns[DataGridAdressColumn].HeaderText = DataGridAdressHeaderColumn;
            }

            if (dataGridViewHostel.Columns[DataGridPhoneColumn] != null)
            {
                dataGridViewHostel.Columns[DataGridPhoneColumn].HeaderText = DataGridPhoneHeaderColumn;
            }

            if (dataGridViewHostel.Columns[DataGridCreatedAtColumn] != null)
            {
                dataGridViewHostel.Columns[DataGridCreatedAtColumn].HeaderText = DataGridCreatedAtHeaderColumn;
            }
        }

        private async Task ReloadFormAsync()
        {
            // Réinitialiser les contrôles de saisie
            textBoxAdress.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxPhoneNumber.Text = string.Empty;
            comboBoxCity.Text = "Sélectionner";

            // Recharger les données dans les DataGridViews
            await LoadDataAsync();

            await FillDataGridViewAsync();

            await FillChartAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Désactiver les contrôles pendant le chargement des données
                this.SetEnabled(false);

                // Charger les données
                await FillDataGridViewAsync();
            }
            finally
            {
                // Réactiver les contrôles après le chargement des données
                this.SetEnabled(true);
            }
        }

        private async Task FillChartAsync()
        {
            // Récupérer les données de nombre de villes par pays
            var groupedReferences = await _hostelDataManagingMethods.GetHotelCountByCityAsync();

            // Nettoyer les séries existantes dans le graphique
            chartHostel.Series.Clear();

            // Créer une nouvelle série pour le graphique
            var series = new Series("Hôtels par ville")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            // Ajouter les données à la série
            foreach (var entry in groupedReferences)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            // Ajouter la série au graphique
            chartHostel.Series.Add(series);

            // Ajouter les titres aux axes (non applicable pour un graphique en camembert)
            // Les titres des axes sont souvent plus pertinents pour des graphiques de type Bar ou Line
            // Mais vous pouvez toujours les définir si vous changez le type de graphique ultérieurement
            chartHostel.ChartAreas[0].AxisX.Title = "Ville";
            chartHostel.ChartAreas[0].AxisY.Title = "Nombre d'hôtels";

            // Optionnel : personnaliser le graphique
            chartHostel.Titles.Clear();
            chartHostel.Titles.Add("Nombre d'hôtels par ville");
        }

        private async void modifierLhôtelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewHostel.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewHostel.SelectedRows[0];
                var viewModel = (DataGridHostelViewModel)selectedRow.DataBoundItem;

                var hostelId = viewModel.Id;
                var hostelDesignation = viewModel.Designation;
                var cityName = viewModel.CityName;
                var hostelAdress = viewModel.Adress;
                var hostelPhone = viewModel.Phone.HasValue ? viewModel.Phone.Value : (int?)null;
                var hostelDate = viewModel.CreatedAt;

                // Créer et afficher le formulaire de mise à jour avec les données sélectionnées
                UpdatingHostelForm updatingHostelForm = new UpdatingHostelForm(hostelId, hostelDesignation!,
                    cityName!, hostelAdress, hostelPhone, hostelDate,
                    _citiesManagingMethods, _hostelDataManagingMethods);

                if (updatingHostelForm.ShowDialog() == DialogResult.OK)
                {
                    // Rafraîchir les données du DataGridView après mise à jour
                    await ReloadFormAsync();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
        }


    }
}
