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
                listBoxAvsnitt.DisplayMember = "Rubrik";
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
            richTextBox1.Clear();
            rtbGaTillAvsnitt.Clear();

            if (listBoxAvsnitt.SelectedItem is Avsnitt valtAvsnitt)
            {
                richTextBox1.AppendText($"Titel: {valtAvsnitt.Rubrik}");

                richTextBox1.AppendText($"Publicerad: {valtAvsnitt.Publiceringsdatum.DateTime.ToShortDateString()}");

                richTextBox1.AppendText("---------------------------------");

                if (!string.IsNullOrWhiteSpace(valtAvsnitt.Sammanfattning))
                {
                    string kortSammanfattning = valtAvsnitt.Sammanfattning.Length > 150
                                              ? valtAvsnitt.Sammanfattning.Substring(0, 150) + "..."
                                              : valtAvsnitt.Sammanfattning;
                    richTextBox1.AppendText($"Sammanfattning: {kortSammanfattning}");
                }
                if (!string.IsNullOrWhiteSpace(valtAvsnitt.Beskrivning))
                {
                    string kortBeskrivning = valtAvsnitt.Beskrivning.Length > 150
                                           ? valtAvsnitt.Beskrivning.Substring(0, 150) + "..."
                                           : valtAvsnitt.Beskrivning;

                    richTextBox1.AppendText($"Beskrivning (start): {kortBeskrivning}");
                }
                if (!string.IsNullOrWhiteSpace(valtAvsnitt.Lank))
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
                richTextBox1.Clear();
                rtbGaTillAvsnitt.Clear();
            }
        }

        
    }
}

    
           


       