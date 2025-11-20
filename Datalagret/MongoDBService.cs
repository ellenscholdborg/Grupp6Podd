using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Modeller;

namespace Datalagret
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Kategori> kategoriKollektion;

        
        public MongoDBService()
        {

            var klient = new MongoClient("mongodb+srv://ellish100_db_user:PoddGrupp6@poddprojektgrupp6.jnfv6bw.mongodb.net/?retryWrites=true&w=majority&appName=PoddProjektGrupp6");
            var databas = klient.GetDatabase("PoddProjektGrupp6");
            kategoriKollektion = databas.GetCollection<Kategori>("Kategorier");
        }
        public void SparaKategori(string namn)
        {
            var kategori = new Kategori { Namn = namn };
            kategoriKollektion.InsertOne(kategori);
        }
        public async Task<List<Kategori>> HamtaAllaKategorierAsync()
        {
            var kategorier = await kategoriKollektion.Find(_ => true).ToListAsync();
            return kategorier;
        }

    }
}
