using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using Djamana.Partenaires.UI.Helper;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class CityForm : Form
    {
        private const string CityId = "Id";

        private const string CityName = "Name";

        private const string ContryName = "CountryName";

        private const string HostelName = "HostelNames";

        private const string City = "Ville";

        private const string Country = "Pays";


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

            // Ajouter un élément par défaut
            countries.Insert(0, new Country { Id = 0, Name = "Sélectionner" });

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

            // Appliquer le style à la DataGridView
            DataGridViewHelper.StyleDataGridView(dataGridViewCities);

            // Masquer la colonne Id
            if (dataGridViewCities.Columns[CityId] != null)
            {
                dataGridViewCities.Columns[CityId].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewCities.Columns[CityName] != null)
            {
                dataGridViewCities.Columns[CityName].HeaderText = City;
            }

            if (dataGridViewCities.Columns[ContryName] != null)
            {
                dataGridViewCities.Columns[ContryName].HeaderText = Country;
            }

            if (dataGridViewCities.Columns[HostelName] != null)
            {
                dataGridViewCities.Columns[HostelName].Visible = false;
            }
        }

        private async void Cities_Load(object sender, EventArgs e)
        {
            await FillComboBoxWithCountries();

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

        private async Task ReloadFormAsync()
        {
            // Réinitialiser les contrôles de saisie
            textBoxCitiesName.Text = string.Empty;
            comboBoxCountries.Text = "Sélectionner";

            // Recharger les données dans les DataGridViews
            await LoadDataAsync();

            await FillDataGridViewAsync();

            await FillChartAsync();
        }

        private async Task FillChartAsync()
        {
            // Récupérer les données de nombre de villes par pays
            var groupedReferences = await _citiesManagingMethods.GetCityCountByCountryAsync();

            // Nettoyer les séries existantes dans le graphique
            chartCity.Series.Clear();

            // Créer une nouvelle série pour le graphique
            var series = new Series("Villes par pays")
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
            chartCity.Series.Add(series);

            // Ajouter les titres aux axes (non applicable pour un graphique en camembert)
            // Les titres des axes sont souvent plus pertinents pour des graphiques de type Bar ou Line
            // Mais vous pouvez toujours les définir si vous changez le type de graphique ultérieurement
            chartCity.ChartAreas[0].AxisX.Title = "Pays";
            chartCity.ChartAreas[0].AxisY.Title = "Nombre de Villes";

            // Optionnel : personnaliser le graphique
            chartCity.Titles.Clear();
            chartCity.Titles.Add("Nombre de Villes par Pays");
        }


        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Désactiver le bouton de sauvegarde pour éviter les clics multiples
                buttonSave.Enabled = false;

                // Vérification que le nom de la ville n'est pas vide
                if (string.IsNullOrWhiteSpace(textBoxCitiesName.Text))
                {
                    MessageBox.Show("Le nom de la ville ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Vérification que le pays est sélectionné
                if (comboBoxCountries.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner un pays.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Récupérer le CountryId à partir de la sélection
                int selectedCountryId = (int)comboBoxCountries.SelectedValue;

                // Créer la nouvelle ville
                var newCity = new Cities
                {
                    Name = textBoxCitiesName.Text,
                    CountryId = selectedCountryId
                };

                // Ajouter la nouvelle ville
                await _citiesManagingMethods.AddCityAsync(newCity);

                MessageBox.Show("City added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recharger le formulaire
                await ReloadFormAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout de la ville: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Réactiver le bouton de sauvegarde après l'opération
                buttonSave.Enabled = true;
            }
        }

        private void contextMenuStripCities_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private async void toolStripMenuItemUpdateCities_Click(object sender, EventArgs e)
        {
            if (dataGridViewCities.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCities.SelectedRows[0];
                var viewModel = (DataGridCityViewModel)selectedRow.DataBoundItem;

                var cityId = viewModel.Id;
                var cityName = viewModel.Name;
                var countryName = viewModel.CountryName;

                // Créer et afficher le formulaire de mise à jour avec les données sélectionnées
                UpdatingCityForm updatedCityForm = new UpdatingCityForm(cityId, cityName!, countryName!, 
                    _citiesManagingMethods, _gettingDjamanaPartner);
                if (updatedCityForm.ShowDialog() == DialogResult.OK)
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

        private async void toolStripMenuItemDeleteCities_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCities.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette ville ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var selectedRow = dataGridViewCities.SelectedRows[0];
                        var viewModel = selectedRow.DataBoundItem as DataGridCityViewModel;

                        if (viewModel != null)
                        {
                            var cityId = viewModel.Id;

                            // Supprimer la ville
                            await _citiesManagingMethods.DeletingCityAsync(cityId);

                            // Recharger les données après la suppression
                            await ReloadFormAsync();

                            MessageBox.Show("La ville a été supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La ligne sélectionnée ne contient pas de données valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors de la suppression de la ville : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
