using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using Djamana.Partenaires.UI.Helper;
using Microsoft.EntityFrameworkCore;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class HostelServicesForm : Form
    {
        private readonly HostelDataManaging _hostelDataManagingMethods;

        private readonly HostelServicesDataManaging _hostelServicesDataManagingMethods;

       
        public HostelServicesForm(HostelDataManaging hostelDataManagingMethods,
            HostelServicesDataManaging hostelServicesDataManagingMethods)
        {
            InitializeComponent();

            _hostelDataManagingMethods = hostelDataManagingMethods;

            _hostelServicesDataManagingMethods = hostelServicesDataManagingMethods;

        }

        private async Task FillComboBoxWithCountries()
        {
            List<Hostels> countries = await _hostelDataManagingMethods.GetAllHotelsAsync();

            comboBoxHostel.DisplayMember = "Designation";
            comboBoxHostel.ValueMember = "Id";

            comboBoxHostel.DataSource = countries;
        }

        private async void HostelServicesForm_LoadAsync(object sender, EventArgs e)
        {
           
            await FillComboBoxWithCountries();

            await FillDataGridViewAsync();

        }

        private async Task FillDataGridViewAsync()
        {
            // Récupérer les données des services d'hôtel
            List<HostelServices> hostelServices = await _hostelServicesDataManagingMethods.GetAllHostelServicesAsync();

            // Vérifiez le nombre d'éléments récupérés
            MessageBox.Show($"Number of HostelServices retrieved: {hostelServices.Count}");

            // Affichez les détails de chaque service d'hôtel récupéré
            foreach (var service in hostelServices)
            {
                MessageBox.Show($"Id: {service.Id}, ServicesName: {service.ServicesName}, Price: {service.Price}, HostelId: {service.HostelId}, CreatedAt: {service.CreatedAt}");
                if (service.Hostel != null)
                {
                    Console.WriteLine($"Hostel Name: {service.Hostel.Designation}");
                }
                else
                {
                    Console.WriteLine("Hostel is null.");
                }
            }

            // Mapper les données vers le ViewModel
            List<DataGridHostelServiceViewModel> serviceViewModels = hostelServices.Select(c => new DataGridHostelServiceViewModel
            {
                Id = c.Id,
                Designation = c.ServicesName,
                Price = c.Price.ToString("F2"),
                HostelName = c.Hostel?.Designation ?? "Unknown", // Assurez-vous que la propriété 'Designation' est le nom de l'hôtel
                CreatedAt = c.CreatedAt
            }).ToList();

            // Vérifiez le nombre d'éléments après le mappage
            Console.WriteLine($"Number of ViewModel items: {serviceViewModels.Count}");

            // Affichez les détails de chaque ViewModel
            foreach (var viewModel in serviceViewModels)
            {
                MessageBox.Show($"Id: {viewModel.Id}, Designation: {viewModel.Designation}, Price: {viewModel.Price}, HostelName: {viewModel.HostelName}, CreatedAt: {viewModel.CreatedAt}");
            }

            // Lier la liste à la DataGridView en dehors de la boucle
            dataGridViewHostel.DataSource = serviceViewModels;

            // Appliquer le style à la DataGridView
            DataGridViewHelper.StyleDataGridView(dataGridViewHostel);

            // Vérifiez que la DataSource a été assignée
            if (dataGridViewHostel.DataSource != null)
            {
                Console.WriteLine("DataGridView DataSource has been set.");
            }

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

            if (dataGridViewHostel.Columns["Price"] != null)
            {
                dataGridViewHostel.Columns["Price"].HeaderText = "Prix";
            }

            if (dataGridViewHostel.Columns["HostelName"] != null)
            {
                dataGridViewHostel.Columns["HostelName"].HeaderText = "Nom de l'hôtel";
            }

            if (dataGridViewHostel.Columns["CreatedAt"] != null)
            {
                dataGridViewHostel.Columns["CreatedAt"].HeaderText = "Date d'enregistrement";
            }
        }

        private async void btnValidate_ClickAsync(object sender, EventArgs e)
        {
            if (comboBoxHostel.SelectedItem != null)
            {
                int selectedHostelId = (int)comboBoxHostel.SelectedValue;

                var newHostelService = new HostelServices
                {
                    ServicesName = textBoxDesignation.Text,
                    Price = double.Parse(textBoxPrice.Text),
                    CreatedAt = DateTime.Now,
                    HostelId = selectedHostelId
                };

                try
                {
                    await _hostelServicesDataManagingMethods.AddHostelServicesAsync(newHostelService);
                    MessageBox.Show("Service added successfully.");
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Error adding service: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Inner exception: {ex.InnerException.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a hostel.");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelHostels_Click(object sender, EventArgs e)
        {

        }
    }
}
