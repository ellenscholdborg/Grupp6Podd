using Affärslagret;
using Datalagret;
using Modeller;
using MongoDB.Driver;
using System.ComponentModel;
using System.Security.Policy;
using System.Linq;

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
            //listBoxAllaPoddfloden.Items.Clear();

            if (listBoxKategori.SelectedItem == null)
                return;

            var valdKategori = (Kategori)listBoxKategori.SelectedItem;
            textBoxAndraNamnKategori.Text = valdKategori.Namn;
           // List<Podd>
            var poddar = await mongo.HamtaPoddarForKategoriAsync(valdKategori.Id);

            allaPoddarBinding = new BindingList<Podd>(poddar);
            listBoxAllaPoddfloden.DataSource = allaPoddarBinding;
            listBoxAllaPoddfloden.DisplayMember = "Namn";

            textBoxAndraNamnKategori.Text = valdKategori.Namn;

            //foreach (var podd in poddar.Where(p => p != null))
            //{
            //    //string namn = string.IsNullOrWhiteSpace(podd.Namn) ? "(namn saknas)" : podd.Namn;
            //    listBoxAllaPoddfloden.Items.Add(podd);
            //    listBoxAllaPoddfloden.DisplayMember = "Namn";
            //}

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

            // Bind combobox to a separate copy of the categories so selecting in combobox
            // does not change the current position (selection) of listBoxKategori.
            var comboKategorier = new BindingList<Kategori>(allaKategorier.ToList());
            comboBoxBytKategori.DisplayMember = "Namn";
            comboBoxBytKategori.ValueMember = "Id";
            comboBoxBytKategori.DataSource = allaKategorierBinding;



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

            // Lägg till i UI: om listan är databunden, lägg till i BindingList annars i Items
            if (allaPoddarBinding != null && listBoxAllaPoddfloden.DataSource == allaPoddarBinding)
            {
                allaPoddarBinding.Add(nyPodd);
            }
            else
            {
                listBoxAllaPoddfloden.Items.Add(nyPodd);
            }

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
                        // If the listbox is bound to a BindingList, remove from that list so the UI updates
                        if (allaPoddarBinding != null && listBoxAllaPoddfloden.DataSource == allaPoddarBinding)
                        {
                            allaPoddarBinding.Remove(podd);
                        }
                        else
                        {
                            listBoxAllaPoddfloden.Items.Remove(podd);
                        }

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

        private async void btnSparaNyttNamn_Click(object sender, EventArgs e)
        {
            if (listBoxAllaPoddfloden.SelectedItem == null)
            {
                MessageBox.Show("Välj ett poddflöde att byta namn på.");
                return;
            }

            string nyttNamn = textBoxAngeNyttNamnPodd.Text.Trim();
            if (string.IsNullOrWhiteSpace(nyttNamn))
            {
                MessageBox.Show("Skriv in ett nytt poddnamn.");
                return;
            }

            var valdPodd = (Podd)listBoxAllaPoddfloden.SelectedItem;

            bool lyckades = await mongo.UppdateraPoddflodeNamnAsync(valdPodd.Id, nyttNamn);

            if (lyckades)
            {
                valdPodd.Namn = nyttNamn;

                listBoxAllaPoddfloden.DisplayMember = "";
                listBoxAllaPoddfloden.DisplayMember = "Namn";

                MessageBox.Show("Poddnamnet har uppdaterats!");
            }
            else
            {
                MessageBox.Show("Poddnamnet kunde inte uppdateras i databasen.");
            }

        }

        private void listBoxAllaPoddfloden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAllaPoddfloden.SelectedItem == null)

                return;

            var valdPodd = (Podd)listBoxAllaPoddfloden.SelectedItem;

            textBoxAngeNyttNamnPodd.Text = valdPodd.Namn;

        }

        private async void comboBoxBytKategori_SelectedIndexChanged(object sender, EventArgs e)

        {
            



        }

        private async void btnSparaBytKategori_Click(object sender, EventArgs e)
        {
            if (listBoxAllaPoddfloden.SelectedItem == null)
            {
                MessageBox.Show("Välj ett poddflöde först.");
                return;
            }

            // Kontroll: måste välja en ny kategori
            if (comboBoxBytKategori.SelectedItem == null)
            {
                MessageBox.Show("Välj en kategori i comboboxen.");
                return;
            }

            // Hämta vald podd och ny kategori
            var valdPodd = (Podd)listBoxAllaPoddfloden.SelectedItem;
            var nyKategori = (Kategori)comboBoxBytKategori.SelectedItem;

            // Om kategorin inte ändras: gör inget
            if (valdPodd.KategoriId == nyKategori.Id)
            {
                MessageBox.Show("Poddflödet tillhör redan denna kategori.");
                return;
            }

            // Uppdatera i MongoDB
            bool lyckades = await mongo.UppdateraPoddKategoriAsync(valdPodd.Id, nyKategori.Id);

            if (!lyckades)
            {
                MessageBox.Show("Kunde inte uppdatera kategorin i databasen.");
                return;
            }

            // Uppdatera objektet i minnet
            valdPodd.KategoriId = nyKategori.Id;

            // Ta bort podden ur lokalen listboxen
            if (allaPoddarBinding != null && allaPoddarBinding.Contains(valdPodd))
            {

                allaPoddarBinding.Remove(valdPodd);
            }
            else
            {
                listBoxAllaPoddfloden.Items.Remove(valdPodd);
    
            }

            MessageBox.Show($"Poddflödet '{valdPodd.Namn}' har bytt kategori till '{nyKategori.Namn}'.");
        }

    }
    }





    
           


       