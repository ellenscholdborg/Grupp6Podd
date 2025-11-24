using Modeller;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalagret
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Kategori> kategoriKollektion;
        private readonly IMongoCollection<Podd> poddKollektion;


        public MongoDBService()
        {

            var klient = new MongoClient("mongodb+srv://ellish100_db_user:PoddGrupp6@poddprojektgrupp6.jnfv6bw.mongodb.net/?retryWrites=true&w=majority&appName=PoddProjektGrupp6");
            var databas = klient.GetDatabase("PoddProjektGrupp6");
            kategoriKollektion = databas.GetCollection<Kategori>("Kategorier");
            poddKollektion = databas.GetCollection<Podd>("Poddar");
        }
        public async Task SparaKategori(Kategori kategori)
        {
            if (string.IsNullOrEmpty(kategori.Id))
                kategori.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();

            await kategoriKollektion.InsertOneAsync(kategori);
        }
        public async Task<List<Kategori>> HamtaAllaKategorierAsync()
        {
            var kategorier = await kategoriKollektion.Find(_ => true).ToListAsync();
            return kategorier;
        }
        public async Task<bool> TaBortKategoriAsync(string id)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, id);
            var resultat = await kategoriKollektion.DeleteOneAsync(filter);
            return resultat.DeletedCount > 0;
        }
        public async Task SparaPoddAsync(Podd podd)
        {
            if (string.IsNullOrEmpty(podd.Id))
                podd.Id = ObjectId.GenerateNewId().ToString();

            await poddKollektion.InsertOneAsync(podd);
        }

        public async Task<List<Podd>> HamtaPoddarForKategoriAsync(string kategoriId)
        {
            return await poddKollektion.Find(p => p.KategoriId == kategoriId).ToListAsync();
        }

    }
}
