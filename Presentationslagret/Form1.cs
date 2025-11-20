using System.Security.Policy;
using Modeller;
using Affärslagret;
using Datalagret;
using MongoDB.Driver;

namespace Presentationslagret
{
    public partial class Form1 : Form
    {
        private PoddService enPoddService;
        private List<Avsnitt> allaAvsnitt;
        private MongoDBService mongo;

        public Form1(PoddService enPoddService)
        {
            this.enPoddService = enPoddService;
            mongo = new MongoDBService();
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
            rtbOmAvsnitt.Clear();
            rtbGaTillAvsnitt.Clear();

            if (listBoxAvsnitt.SelectedItem is Avsnitt valtAvsnitt)
            {
                rtbOmAvsnitt.AppendText($"Titel: {valtAvsnitt.Rubrik}");

                rtbOmAvsnitt.AppendText($"Publicerad: {valtAvsnitt.Publiceringsdatum.DateTime.ToShortDateString()}");

                rtbOmAvsnitt.AppendText("---------------------------------");

                if (!string.IsNullOrWhiteSpace(valtAvsnitt.Sammanfattning))
                {
                    string kortSammanfattning = valtAvsnitt.Sammanfattning.Length > 150
                                              ? valtAvsnitt.Sammanfattning.Substring(0, 150) + "..."
                                              : valtAvsnitt.Sammanfattning;
                    rtbOmAvsnitt.AppendText($"Sammanfattning: {kortSammanfattning}");
                }
                if (!string.IsNullOrWhiteSpace(valtAvsnitt.Beskrivning))
                {
                    string kortBeskrivning = valtAvsnitt.Beskrivning.Length > 150
                                           ? valtAvsnitt.Beskrivning.Substring(0, 150) + "..."
                                           : valtAvsnitt.Beskrivning;

                    rtbOmAvsnitt.AppendText($"Beskrivning (start): {kortBeskrivning}");
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
                rtbOmAvsnitt.Clear();
                rtbGaTillAvsnitt.Clear();
            }
        }

        private void listBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (listBoxKategori.SelectedItem == null)
            {
                MessageBox.Show("Välj en kategori att ta bort.");
                return;
            }

            string kategori = listBoxKategori.SelectedItem.ToString();

            DialogResult resultat = MessageBox.Show(
                $"Är du säker på att du vill ta bort kategorin '{kategori}'?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultat == DialogResult.Yes)
            {
                listBoxKategori.Items.Remove(kategori);
                MessageBox.Show($"Kategorin '{kategori}' har tagits bort.");
            }
        }

        private void btnLaggTillNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = textBoxAngeNyKategori.Text.Trim();

            if (string.IsNullOrEmpty(nyKategori))
            {
                MessageBox.Show("Skriv in ett kategorinamn först.");
                return;
            }

            listBoxKategori.Items.Add(nyKategori);

            mongo.SparaKategori(nyKategori);

            textBoxAngeNyKategori.Text = "";

            MessageBox.Show($"Kategorin '{nyKategori}' har lagts till!");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var allaKategorier = await mongo.HamtaAllaKategorierAsync();
            listBoxKategori.Items.Clear();
            foreach (var kategori in allaKategorier)
            {
                listBoxKategori.Items.Add(kategori.Namn);
            }
        }
    }
}



    
           


       