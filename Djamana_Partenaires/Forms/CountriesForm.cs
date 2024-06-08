using Djamana.Partenaires.Core.Business.AddingData;
using Djamana.Partenaires.Core.Data.Domain;
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
    public partial class CountriesForm : Form
    {
        private readonly AddingHostelPartner _addingHostelPartner;

      
        public CountriesForm(AddingHostelPartner addingHostelPartner)
        {
            _addingHostelPartner = addingHostelPartner;
            InitializeComponent();
        }

        private async void btnValidate_ClickAsync(object sender, EventArgs e)
        {

            var newCountry = new Country
            {
                Name = "New Country",
                CreatedAt = DateTime.Now
            };
            await _addingHostelPartner.AddCountryAsync(newCountry);
            MessageBox.Show("Country added successfully");
        }
    }
}
