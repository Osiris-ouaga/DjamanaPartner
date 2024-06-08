using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Data.Domain;
using Djamana.Partenaires.UI.Forms;

namespace Djamana_Partenaires
{
    public partial class FrmDashboard : Form
    {
        private readonly AddingHostelPartner _addingHostelPartner;

        public FrmDashboard(AddingHostelPartner addingHostelPartner)
        {
            _addingHostelPartner = addingHostelPartner;
            InitializeComponent();
        }

        private void slideFiveUserControl1_Load(object sender, EventArgs e)
        {
            //_addingHostelPartner.AddPartnerAsync
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCountry_Click(object sender, EventArgs e)
        {
            CountriesForm countriesForm = new(_addingHostelPartner);
            countriesForm.ShowDialog();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
