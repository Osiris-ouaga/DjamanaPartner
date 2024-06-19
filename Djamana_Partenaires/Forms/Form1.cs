using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Business.GettingData;
using Djamana.Partenaires.UI.Forms;

namespace Djamana_Partenaires
{
    public partial class FrmDashboard : Form
    {
        private readonly AddingHostelPartner _addingHostelPartner;

        private readonly GettingDjamanaPartner _gettingDjamanaPartner;

        private int imageNumber = 1;


        public FrmDashboard(AddingHostelPartner addingHostelPartner, GettingDjamanaPartner gettingDjamanaPartner)
        {
            _addingHostelPartner = addingHostelPartner;
            _gettingDjamanaPartner = gettingDjamanaPartner;
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
            Cities cityForm = new(_gettingDjamanaPartner);
            cityForm.ShowDialog();
        }
    }
}
