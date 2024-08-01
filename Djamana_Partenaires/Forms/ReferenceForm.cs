using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using Djamana.Partenaires.UI.Helper;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class ReferenceForm : Form
    {
        private readonly CitiesManagingMethods _citiesManagingMethods;

        private readonly HostelDataManaging _hostelDataManaging;

        private readonly ReferencesDataManage _referencesDataManage;

        private DataPoint _previouslyHoveredDataPoint = null;


        public ReferenceForm(HostelDataManaging hostelDataManaging, CitiesManagingMethods citiesManagingMethods, ReferencesDataManage referencesDataManage)
        {
            InitializeComponent();
            _hostelDataManaging = hostelDataManaging;
            _citiesManagingMethods = citiesManagingMethods;
            _referencesDataManage = referencesDataManage;


        }

        private async Task FillComboBoxWithHostels()
        {
            List<Hostels> hostels = await _hostelDataManaging.GetAllHotelsAsync();

            this.comboBoxHostel.DisplayMember = "Designation";
            this.comboBoxHostel.ValueMember = "Id";

            this.comboBoxHostel.DataSource = hostels;
        }

        private async Task FillComboBoxWithCities()
        {
            List<Cities> cities = await _citiesManagingMethods.GetAllCityAsync();

            this.comboBoxCity.DisplayMember = "Name";
            this.comboBoxCity.ValueMember = "Id";

            this.comboBoxCity.DataSource = cities;
        }

        private async Task FillDataGridViewAsync()
        {
            // Récupérer les données des partenaires
            List<Partners> partners = await _referencesDataManage.GetAllReferenceAsync();

            // Mapper les données vers le ViewModel
            List<DataGridPartnerViewModel> partnerViewModels = partners.Select(p => DataGridPartnerViewModel.Create(p)).ToList();

            // Lier la liste à la DataGridView
            dataGridViewPartners.DataSource = partnerViewModels;

            // Appliquer le style à la DataGridView
            DataGridViewHelper.StyleDataGridView(dataGridViewPartners);

            // Masquer la colonne Id
            if (dataGridViewPartners.Columns["Id"] != null)
            {
                dataGridViewPartners.Columns["Id"].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewPartners.Columns["Name"] != null)
            {
                dataGridViewPartners.Columns["Name"].HeaderText = "Nom";
            }

            if (dataGridViewPartners.Columns["LastName"] != null)
            {
                dataGridViewPartners.Columns["LastName"].HeaderText = "Prénom";
            }

            if (dataGridViewPartners.Columns["PhoneContact"] != null)
            {
                dataGridViewPartners.Columns["PhoneContact"].HeaderText = "Téléphone";
            }

            if (dataGridViewPartners.Columns["Adress"] != null)
            {
                dataGridViewPartners.Columns["Adress"].HeaderText = "Adresse";
            }

            if (dataGridViewPartners.Columns["CityName"] != null)
            {
                dataGridViewPartners.Columns["CityName"].HeaderText = "Ville";
            }

            if (dataGridViewPartners.Columns["HostelName"] != null)
            {
                dataGridViewPartners.Columns["HostelName"].HeaderText = "Hôtel";
            }

            if (dataGridViewPartners.Columns["CreatedAt"] != null)
            {
                dataGridViewPartners.Columns["CreatedAt"].HeaderText = "Date";
            }
        }


        private async void ReferenceForm_LoadAsync(object sender, EventArgs e)
        {
            await FillComboBoxWithHostels();

            await FillComboBoxWithCities();

            await FillDataGridViewAsync();

            await FillChartAsync();
        }

        private async Task FillChartAsync()
        {
            var groupedReferences = await _referencesDataManage.GetReferencesGroupedByCityAsync();

            chartReference.Series.Clear();
            var series = new Series("Référents par ville")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (var entry in groupedReferences)
            {
                series.Points.AddXY(entry.Key.Name, entry.Value.Count);
            }

            chartReference.Series.Add(series);
            chartReference.ChartAreas[0].AxisX.Title = "Ville";
            chartReference.ChartAreas[0].AxisY.Title = "Nombre de Référents";
        }

        private async void buttonValidate_ClickAsync(object sender, EventArgs e)
        {
            // Récupérer l'objet Cities sélectionné dans le comboBox
            var selectedCity = comboBoxCity.SelectedItem as Cities;

            // Récupérer l'objet Hostels sélectionné dans le comboBox
            var selectedHostel = comboBoxHostel.SelectedItem as Hostels;

            if (selectedCity == null || selectedHostel == null)
            {
                MessageBox.Show("Veuillez sélectionner une ville et une auberge.");
                return;
            }

            if (!int.TryParse(textBoxPhoneNumber.Text, out var phoneNumber))
            {
                MessageBox.Show("Veuillez entrer un numéro de téléphone valide.");
                return;
            }

            var newReference = new Partners
            {
                Name = textBoxName.Text,
                LastName = textBoxLastName.Text,
                PhoneContact = phoneNumber,
                Adress = textBoxAdress.Text,
                City = selectedCity,
                Hostel = selectedHostel,
                CreatedAt = dateTimePickerReferences.Value.Date,
            };

            await _referencesDataManage.AddNewReferenceAsync(newReference);
            MessageBox.Show("Un nouveau référent a été ajoutée avec succès.");
        }

        private void chartReference_MouseMove(object sender, MouseEventArgs e)
        {
            // Récupérez les informations sur la position de la souris
            var hitTest = chartReference.HitTest(e.X, e.Y);

            // Vérifiez si la souris survole un DataPoint
            if (hitTest.ChartElementType == ChartElementType.DataPoint)
            {
                var dataPoint = hitTest.Series.Points[hitTest.PointIndex];

                // Si c'est un nouveau point survolé, mettez à jour son apparence
                if (_previouslyHoveredDataPoint != dataPoint)
                {
                    if (_previouslyHoveredDataPoint != null)
                    {
                        _previouslyHoveredDataPoint.MarkerSize = 5; // Réinitialisez l'ancien point survolé
                        _previouslyHoveredDataPoint.MarkerColor = Color.Blue; // Remettre la couleur d'origine
                    }

                    dataPoint.MarkerSize = 10; // Agrandir le point
                    dataPoint.MarkerColor = Color.Red; // Changez la couleur du point
                    _previouslyHoveredDataPoint = dataPoint;
                }
            }
            else
            {
                // Si la souris ne survole plus un DataPoint, réinitialisez le point précédemment survolé
                if (_previouslyHoveredDataPoint != null)
                {
                    _previouslyHoveredDataPoint.MarkerSize = 5;
                    _previouslyHoveredDataPoint.MarkerColor = Color.Blue;
                    _previouslyHoveredDataPoint = null;
                }
            }
        }

        private void chartReference_MouseLeave(object sender, EventArgs e)
        {
            // Réinitialisez le point précédemment survolé lorsque la souris quitte le graphique
            if (_previouslyHoveredDataPoint != null)
            {
                _previouslyHoveredDataPoint.MarkerSize = 5;
                _previouslyHoveredDataPoint.MarkerColor = Color.Blue;
                _previouslyHoveredDataPoint = null;
            }
        }
    }
}
