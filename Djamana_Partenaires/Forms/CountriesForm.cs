using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.DataGridViewModel;
using Djamana.Partenaires.UI.Helper;
using System.Data;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class CountriesForm : Form
    {
        private const string ContryId = "Id";

        private const string ContryName = "Name";

        private const string ContryDate = "CreatedAt";

        private const string HeaderDesignationText = "Désignation";

        private const string HeaderDateText = "Date";

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
            try
            {
                // Valider les champs de saisie
                string countryName = textBoxCountryName.Text.Trim();
                if (string.IsNullOrEmpty(countryName))
                {
                    MessageBox.Show("Le nom du pays ne peut pas être vide.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime createdAt = dateTimePicker1.Value;
                if (createdAt > DateTime.Now)
                {
                    MessageBox.Show("La date de création ne peut pas être dans le futur.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Créer un nouvel objet Country
                var newCountry = new Country
                {
                    Name = countryName,
                    CreatedAt = createdAt
                };

                // Ajouter le nouveau pays
                await _addingHostelPartner.AddCountryAsync(newCountry);
                MessageBox.Show("Country added successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                await ReloadFormAsync();

                // Réinitialiser les champs de saisie
                textBoxCountryName.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                // Gérer les exceptions
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout du pays: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
            }
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
            textBoxCountryName.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;

            // Recharger les données dans les DataGridViews
            await LoadDataAsync();

            await FillDataGridViewAsync();
        }

        private async void CountriesForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();

            await FillDataGridViewAsync();
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

            // Appliquer le style à la DataGridView
            DataGridViewHelper.StyleDataGridView(dataGridViewCountry);

            // Masquer la colonne Id
            if (dataGridViewCountry.Columns[ContryId] != null)
            {
                dataGridViewCountry.Columns[ContryId].Visible = false;
            }

            // Renommer les colonnes
            if (dataGridViewCountry.Columns[ContryName] != null)
            {
                dataGridViewCountry.Columns[ContryName].HeaderText = HeaderDesignationText;
            }

            if (dataGridViewCountry.Columns[ContryDate] != null)
            {
                dataGridViewCountry.Columns[ContryDate].HeaderText = HeaderDateText;
            }
        }

        private void toolStripMenuItemUpdateCountry_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountry.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCountry.SelectedRows[0];
                var countryId = (int)selectedRow.Cells[ContryId].Value;
                var countryName = (string)selectedRow.Cells[ContryName].Value;
                var createdAt = (DateTime)selectedRow.Cells[ContryDate].Value;

                // Créer et afficher le formulaire de mise à jour avec les données sélectionnées
                UpdatedCountryForm updatedCountryForm = new UpdatedCountryForm(countryId, countryName,
                    createdAt, _addingHostelPartner);
                updatedCountryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
        }

        private async void toolStripMenuItemDeleteCountry_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountry.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCountry.SelectedRows[0];
                var countryId = (int)selectedRow.Cells[ContryId].Value;
                var countryName = (string)selectedRow.Cells[ContryName].Value;
                var createdAt = (DateTime)selectedRow.Cells[ContryDate].Value;

                // Ajouter le nouveau pays
                await _addingHostelPartner.DeleteCountryAsync(countryId);
                MessageBox.Show("Country deleted successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
           
        }
    }
}
