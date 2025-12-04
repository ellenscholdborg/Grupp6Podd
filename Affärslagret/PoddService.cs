using Datalagret;
using Modeller;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Affärslagret    
{
    public class PoddService : IPoddService
    {
        private readonly PoddRSS poddKlient;
        private readonly IPoddRepository poddRepo;

        public PoddService(PoddRSS klient, IPoddRepository poddRepo)
        {
            this.poddKlient = klient;
            this.poddRepo = poddRepo;
        }

        public async Task<List<Avsnitt>> LasInAllaAvsnitt(Podd källa)
        {
            var avsnitt = await poddKlient.HamtaAvsnitt(källa.Url);

            foreach (var a in avsnitt)
            {
                a.KällaReferens = källa.Id;
                a.Id = källa.Id + "-->" + a.Id;
            }

            return avsnitt;
        }

        
        public async Task<string> HamtaPoddTitel(string rssUrl)
        {
            try
            {
                using var httpClient = new HttpClient();
                var xmlData = await httpClient.GetStringAsync(rssUrl); 

                using var stringReader = new StringReader(xmlData);
                using var xmlReader = XmlReader.Create(stringReader);

                var feed = SyndicationFeed.Load(xmlReader);
                return feed?.Title?.Text;
            }
            catch
            {
                return null;
            }
        }

        public Task SparaPoddAsync(Podd podd) => poddRepo.SparaPoddAsync(podd);

        public Task<List<Podd>> HamtaPoddarForKategoriAsync(string kategoriId)
            => poddRepo.HamtaPoddarForKategoriAsync(kategoriId);

        public Task<bool> TaBortPoddflodeAsync(Podd podd)
            => poddRepo.TaBortPoddAsync(podd);

        public Task<bool> UppdateraPoddflodeNamnAsync(Podd podd, string nyttNamn)
            => poddRepo.UppdateraPoddNamnAsync(podd, nyttNamn);

        public Task<bool> UppdateraPoddKategoriAsync(Podd podd, string nyKategoriId)
            => poddRepo.UppdateraPoddKategoriAsync(podd, nyKategoriId);

        }
    }


