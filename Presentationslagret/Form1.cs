using System.Security.Policy;
using Modeller;
using Affärslagret;

namespace Presentationslagret
{
    public partial class Form1 : Form
    {
        private PoddService enPoddService;
        private List<Avsnitt> allaAvsnitt;

        public Form1(PoddService enPoddService)
        {
            this.enPoddService = enPoddService;
            InitializeComponent();
        }

        private async void btnHamtaAvsnitt_Click_1(object sender, EventArgs e)

        {
            try
            {
                var källa = new Podd();
                källa.Id = Guid.NewGuid().ToString();
                källa.Url = textBoxRssLank.Text;

                allaAvsnitt = await enPoddService.LasInAllaAvsnitt(källa);

                listBoxAvsnitt.DataSource = null;
                listBoxAvsnitt.DisplayMember="Rubrik";
                listBoxAvsnitt.DataSource = allaAvsnitt;
                rtbGaTillAvsnitt.Clear();              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte hämta avsnitt: " + ex.Message);
            }
        }
        private void listBoxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (listBoxAvsnitt.SelectedItem is Avsnitt valtAvsnitt)
            {              
                if (valtAvsnitt.Lank != null)
                {
                    rtbGaTillAvsnitt.Text = valtAvsnitt.Lank;
                }
                else
                {
                    rtbGaTillAvsnitt.Text = "Länk saknas för detta avsnitt.";
                }
            }
            else
            {
                rtbGaTillAvsnitt.Clear();
            }

        }
        
    }
}
    
           


       