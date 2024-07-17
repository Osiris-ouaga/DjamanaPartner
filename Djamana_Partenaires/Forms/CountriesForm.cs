﻿using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using System.Data;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class CountriesForm : Form
    {
        private readonly AddingHostelPartner _addingHostelPartner;

        private readonly GettingDjamanaPartner _gettingDjamanaPartner;


        public CountriesForm(AddingHostelPartner addingHostelPartner, GettingDjamanaPartner gettingDjamanaPartner)
        {
            _addingHostelPartner = addingHostelPartner;
            _gettingDjamanaPartner = gettingDjamanaPartner;
            InitializeComponent();
        }

        private async void btnValidate_ClickAsync(object sender, EventArgs e)
        {

            var newCountry = new Country
            {
                Name = textBoxCountryName.Text,
                CreatedAt = dateTimePicker1.Value
            };
            await _addingHostelPartner.AddCountryAsync(newCountry);
            MessageBox.Show("Country added successfully");
        }

        private async void CountriesForm_Load(object sender, EventArgs e)
        {
           await  FillDataGridViewAsync();
        }

        private async Task FillDataGridViewAsync()
        {
            // Récupérer les données des pays
            List<Country> countries = await _gettingDjamanaPartner.GetAllCountriesAsync();

            // Mapper les données vers le ViewModel
            List<DataGridCountryViewModel> countryViewModels = countries.Select(c => new DataGridCountryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedAt = c.CreatedAt
            }).ToList();

            // Lier la liste à la DataGridView
            dataGridViewCountry.DataSource = countryViewModels;

            // Masquer la colonne Id
            if (dataGridViewCountry.Columns["Id"] != null)
            {
                dataGridViewCountry.Columns["Id"].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewCountry.Columns["Name"] != null)
            {
                dataGridViewCountry.Columns["Name"].HeaderText = "Désignation";
            }

            if (dataGridViewCountry.Columns["CreatedAt"] != null)
            {
                dataGridViewCountry.Columns["CreatedAt"].HeaderText = "Date d'enregistrement";
            }
        }
    }
}
