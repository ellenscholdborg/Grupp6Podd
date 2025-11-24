using Affärslagret;
using Datalagret;
using Modeller;
using MongoDB.Driver;
using System.ComponentModel;
using System.Security.Policy;

namespace Presentationslagret
{
    public partial class Form1 : Form
    {
        private PoddService enPoddService;
        private List<Avsnitt> allaAvsnitt;
        private MongoDBService mongo;
        private BindingList<Kategori> allaKategorierBinding;
        private BindingList<Podd> allaPoddarBinding;

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

        private async void listBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAllaPoddfloden.Items.Clear();

            if (listBoxKategori.SelectedItem == null)
                return;

            var valdKategori = (Kategori)listBoxKategori.SelectedItem;
            textBoxAndraNamnKategori.Text = valdKategori.Namn;
            List<Podd> poddar = await mongo.HamtaPoddarForKategoriAsync(valdKategori.Id);

            foreach (var podd in poddar.Where(p => p != null))
            {
                string namn = string.IsNullOrWhiteSpace(podd.Namn) ? "(namn saknas)" : podd.Namn;
                listBoxAllaPoddfloden.Items.Add(namn);
            }
        }

        private async void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (listBoxKategori.SelectedItem == null)
            {
                MessageBox.Show("Välj en kategori att ta bort.");
                return;
            }

            var kategori = (Kategori)listBoxKategori.SelectedItem;

            DialogResult resultat = MessageBox.Show(
                $"Är du säker på att du vill ta bort kategorin '{kategori.Namn}'?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultat == DialogResult.Yes)
            {
                try
                {
                    bool lyckades = await mongo.TaBortKategoriAsync(kategori.Id);

                    if (lyckades)

                    {
                        allaKategorierBinding.Remove(kategori);
                        MessageBox.Show($"Kategorin '{kategori.Namn}' har tagits bort.");
                    }
                    else
                    {
                        MessageBox.Show($"Kunde inte hitta kategorin '{kategori.Namn}' i databasen.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel uppstod vid borttagning: {ex.Message}");
                }
            }
        }


        private async void btnLaggTillNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategoriNamn = textBoxAngeNyKategori.Text.Trim();

            if (string.IsNullOrEmpty(nyKategoriNamn))
            {
                MessageBox.Show("Skriv in ett kategorinamn först.");
                return;
            }

            var nyKategori = new Kategori { Namn = nyKategoriNamn };

            await mongo.SparaKategori(nyKategori);

            allaKategorierBinding.Add(nyKategori);

            textBoxAngeNyKategori.Text = "";

            MessageBox.Show($"Kategorin '{nyKategoriNamn}' har lagts till!");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var allaKategorier = await mongo.HamtaAllaKategorierAsync();
            allaKategorierBinding = new BindingList<Kategori>(allaKategorier);

            listBoxKategori.DisplayMember = "Namn";
            listBoxKategori.ValueMember = "Id";
            listBoxKategori.DataSource = allaKategorierBinding;
            listBoxAllaPoddfloden.DisplayMember = "Namn";

        }

        private async void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            if (listBoxKategori.SelectedItem == null)
            {
                MessageBox.Show("Välj en kategori först.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxRssLank.Text))
            {
                MessageBox.Show("Skriv in en RSS-länk.");
                return;
            }

            var valdKategori = (Kategori)listBoxKategori.SelectedItem;
            string rss = textBoxRssLank.Text.Trim();

            // Hämta poddens titel
            string poddNamn = await enPoddService.HamtaPoddTitel(rss);

            // Om ingen titel hittades → använd URL som fallback
            if (string.IsNullOrEmpty(poddNamn))
                poddNamn = rss;

            var nyPodd = new Podd
            {
                Namn = poddNamn,
                Url = rss,
                KategoriId = valdKategori.Id
            };

            await mongo.SparaPoddAsync(nyPodd);

            listBoxAllaPoddfloden.Items.Add(nyPodd);
            textBoxRssLank.Text = "";

            MessageBox.Show("Podd tillagd!");
        }

        private async void btnTaBortPoddflode_Click(object sender, EventArgs e)
        {
            if (listBoxAllaPoddfloden.SelectedItem == null)
            {
                MessageBox.Show("Välj ett poddflöde att ta bort.");
                return;
            }

            var podd = (Podd)listBoxAllaPoddfloden.SelectedItem;

            DialogResult resultat = MessageBox.Show(
                $"Är du säker på att du vill ta bort poddflödet '{podd.Namn}'?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultat == DialogResult.Yes)
            {
                try
                {
                    bool lyckades = await mongo.TaBortPoddflodeAsync(podd.Id);

                    if (lyckades)

                    {
                        listBoxAllaPoddfloden.Items.Remove(podd);
                        MessageBox.Show($"Poddflödet '{podd.Namn}' har tagits bort.");
                    }
                    else
                    {
                        MessageBox.Show($"Kunde inte hitta poddflödet '{podd.Namn}' i databasen.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel uppstod vid borttagning: {ex.Message}");
                }
            }
        }

        private async void btnSparaNyKategori_Click(object sender, EventArgs e)
        {
            if (listBoxKategori.SelectedItem == null)
            {
                MessageBox.Show("Välj en kategori att byta namn på.");
                return;
            }

            string nyttNamn = textBoxAndraNamnKategori.Text.Trim();
            if (string.IsNullOrWhiteSpace(nyttNamn))
            {
                MessageBox.Show("Skriv in ett nytt kategorinamn.");
                return;
            }

            var valdKategori = (Kategori)listBoxKategori.SelectedItem;

            bool lyckades = await mongo.UppdateraKategoriNamnAsync(valdKategori.Id, nyttNamn);

            if (lyckades)
            {
                valdKategori.Namn = nyttNamn;

                listBoxKategori.DisplayMember = "";
                listBoxKategori.DisplayMember = "Namn";

                MessageBox.Show("Kategorinamnet har uppdaterats!");
            }
            else
            {
                MessageBox.Show("Kategorin kunde inte uppdateras i databasen.");
            }
        }
    }

}



    
           


       