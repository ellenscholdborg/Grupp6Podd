using Modeller;
using MongoDB.Driver;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Datalagret
{
    public class PoddRSS
    {
        private HttpClient enHttpKlient;
        public PoddRSS(HttpClient enHttpKlient)
        {
            this.enHttpKlient = enHttpKlient;
        }
        public async Task<List<Avsnitt>> HamtaAvsnitt(string rssLank)
        {
            Stream dataStrom = await this.enHttpKlient.GetStreamAsync(rssLank); XmlReader minXMLlasare = XmlReader.Create(dataStrom);
            SyndicationFeed dataFlode = SyndicationFeed.Load(minXMLlasare);
            minXMLlasare.Dispose(); List<Avsnitt> avsnittLista = new List<Avsnitt>();
            foreach (SyndicationItem item in dataFlode.Items)
            {
                //Avsnitt ettAvsnitt = new Avsnitt(); ettAvsnitt.Id = item.Id.ToString();
                //ettAvsnitt.Rubrik = item.Title.Text; ettAvsnitt.Publiceringsdatum = item.PublishDate;
                //ettAvsnitt.Lank = item.Links.First().Uri.ToString();
                //avsnittLista.Add(ettAvsnitt);
                Avsnitt ettAvsnitt = new Avsnitt();
                ettAvsnitt.Id = item.Id.ToString();
                ettAvsnitt.Rubrik = item.Title.Text;
                ettAvsnitt.Publiceringsdatum = item.PublishDate;

                // NYTT: Hämta Sammanfattning (Summary)
                // Använd item.Summary?.Text för att hantera om fältet är tomt eller null
                ettAvsnitt.Sammanfattning = item.Summary?.Text ?? "";

                // NYTT: Hämta Beskrivning (Content/Description)
                // Content innehåller ofta den fullständiga beskrivningstexten
                if (item.Content is TextSyndicationContent textContent)
                {
                    ettAvsnitt.Beskrivning = textContent.Text ?? "";
                }
                else
                {
                    // Använd Summary som en fallback om Content saknas, men Sammanfattning fanns.
                    ettAvsnitt.Beskrivning = ettAvsnitt.Sammanfattning;
                }

                // LÄNK-HÄMTNING (Din befintliga kod)
                if (item.Links.Any())
                {
                    ettAvsnitt.Lank = item.Links.First().Uri.ToString();
                }
                else
                {
                    ettAvsnitt.Lank = "Länk saknas i RSS-flödet";

                }
                avsnittLista.Add(ettAvsnitt);
            }
            return avsnittLista;
        }
        
    }
    
}


