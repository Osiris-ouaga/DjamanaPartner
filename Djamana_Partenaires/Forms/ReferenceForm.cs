using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class ReferenceForm : Form
    {
        private readonly CitiesManagingMethods _citiesManagingMethods;

        private readonly HostelDataManaging _hostelDataManaging;

        private readonly ReferencesDataManage _referencesDataManage;

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

    }
}
