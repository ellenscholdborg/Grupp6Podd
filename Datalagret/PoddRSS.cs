using Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using MongoDB.Driver;

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
            Stream dataStrom = await this.enHttpKlient.GetStreamAsync(rssLank);
            XmlReaderSettings settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Ignore,
                IgnoreWhitespace = true,
            };
            XmlReader minXMLlasare = XmlReader.Create(dataStrom, settings);

            SyndicationFeed dataFlode = SyndicationFeed.Load(minXMLlasare);

            minXMLlasare.Dispose();

            List<Avsnitt> avsnittLista = new List<Avsnitt>();

            foreach (SyndicationItem item in dataFlode.Items)
            {
                Avsnitt ettAvsnitt = new Avsnitt();
                ettAvsnitt.Id = item.Id;
                ettAvsnitt.Rubrik = item.Title.Text;
                ettAvsnitt.Publiceringsdatum = item.PublishDate;
                ettAvsnitt.Lank = null;

                var enclosureLink = item.Links.FirstOrDefault(l =>
            l.RelationshipType == "enclosure" && l.Uri != null);
                if (enclosureLink != null)
                {
                    ettAvsnitt.Lank = enclosureLink.Uri.ToString();
                }
                if (ettAvsnitt.Lank == null)
                {
                    foreach (var ext in item.ElementExtensions)
                    {
                        if (ext.OuterName == "content") ;
                    }
                }
                if (item.Links.Any())
                {
                    ettAvsnitt.Lank = item.Links.First().Uri.ToString();
                }
                enclosureLink = item.Links
                   .FirstOrDefault(l => l.RelationshipType == "enclosure");

                if (enclosureLink != null)
                {
                    ettAvsnitt.Lank = enclosureLink.Uri.ToString();
                }


                // 3. Sista utväg: leta efter enclosure via SyndicationItem explicit
                if (ettAvsnitt.Lank == null)
                {
                    foreach (var ext in item.ElementExtensions)
                    {
                        if (ext.OuterName == "content" && ext.OuterNamespace == "http://search.yahoo.com/mrss/")
                        {
                            try
                            {
                                var elem = ext.GetObject<XmlElement>();
                                var url = elem.GetAttribute("url");
                                if (!string.IsNullOrEmpty(url))
                                {
                                    ettAvsnitt.Lank = url;
                                    break;
                                }
                            }
                            catch { }
                        }
                        // 4. Sista chans: vissa RSS använder GUID som URL
                        if (ettAvsnitt.Lank == null && item.Id.StartsWith("http"))
                        {
                            ettAvsnitt.Lank = item.Id;
                        }
                        if (ettAvsnitt.Lank == null && item.Links.Any())
                        {
                            ettAvsnitt.Lank = item.Links.First().Uri.ToString();
                        }
                        if (string.IsNullOrEmpty(ettAvsnitt.Lank))
                        {
                            System.Diagnostics.Debug.WriteLine($"Länk saknas för avsnitt: {ettAvsnitt.Rubrik}");
                        }

                        
                    }
                    
                }
                avsnittLista.Add(ettAvsnitt);
            }
            return avsnittLista;
        }
    }
}
    





