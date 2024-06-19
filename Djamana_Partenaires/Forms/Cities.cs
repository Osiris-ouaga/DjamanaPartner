using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.Core.Data.Domain;

namespace Djamana.Partenaires.UI.Forms
{
    public partial class Cities : Form
    {
        private readonly GettingDjamanaPartner _gettingDjamanaPartner;

        public Cities(GettingDjamanaPartner gettingDjamanaPartner)
        {

            _gettingDjamanaPartner = gettingDjamanaPartner;
            InitializeComponent();
        }

        private async Task FillComboBoxWithCountries()
        {
            List<Country> countries = await _gettingDjamanaPartner.GetAllCountriesAsync();

            comboBoxCountries.DisplayMember = "Name"; 
            comboBoxCountries.ValueMember = "Id"; 

            comboBoxCountries.DataSource = countries;
        }

        private async void Cities_Load(object sender, EventArgs e)
        {
            await FillComboBoxWithCountries();
        }
    }
}
