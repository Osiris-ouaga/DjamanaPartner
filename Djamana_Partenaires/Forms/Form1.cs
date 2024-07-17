using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.UI.Forms;

namespace Djamana_Partenaires
{
    public partial class FrmDashboard : Form
    {
        private readonly AddingHostelPartner _addingHostelPartner;

        private readonly CitiesManagingMethods _citiesManagingMethods;

        private readonly GettingDjamanaPartner _gettingDjamanaPartner;

        private readonly HostelDataManaging _hostelDataManagingMethods;

        private readonly ReferencesDataManage _referencesDataManage;

        private int imageNumber = 1;


        public FrmDashboard(CitiesManagingMethods citiesManagingMethods, AddingHostelPartner addingHostelPartner, 
            GettingDjamanaPartner gettingDjamanaPartner, HostelDataManaging hostelDataManagingMethods, 
            ReferencesDataManage referencesDataManage)
        {
            _addingHostelPartner = addingHostelPartner;

            _gettingDjamanaPartner = gettingDjamanaPartner;

            _citiesManagingMethods = citiesManagingMethods;

            InitializeComponent();

            _hostelDataManagingMethods = hostelDataManagingMethods;

            _referencesDataManage = referencesDataManage;
        }

        private void slideFiveUserControl1_Load(object sender, EventArgs e)
        {
            //_addingHostelPartner.AddPartnerAsync
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReferenceForm referenceForm = new(_hostelDataManagingMethods, _citiesManagingMethods, 
                _referencesDataManage);
            referenceForm.ShowDialog();
        }

        private void BtnCountry_Click(object sender, EventArgs e)
        {
            CountriesForm countriesForm = new(_addingHostelPartner, _gettingDjamanaPartner);
            countriesForm.ShowDialog();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadNextImage()
        {
            if (imageNumber == 11)
            {
                imageNumber = 1;
            }

            slidePictureBox.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);

            imageNumber++;
        }

        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new(_citiesManagingMethods, _gettingDjamanaPartner);
            cityForm.ShowDialog();
        }

        private void btnHostel_Click(object sender, EventArgs e)
        {
            HostelForm hostelForm = new(_citiesManagingMethods, _hostelDataManagingMethods);
            hostelForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new();
            selectForm.ShowDialog();
        }
    }
}
