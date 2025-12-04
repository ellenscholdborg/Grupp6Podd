using Modeller;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datalagret
{
    public class KategoriRepository : IKategoriRepository
    {
        private readonly IMongoCollection<Kategori> kategoriKollektion;

        private readonly MongoDBService context;


        public KategoriRepository(MongoDBService context)
        {
            this.context = context;
            kategoriKollektion = context.kategoriKollektion;
        }

        public async Task SparaKategoriAsync(Kategori kategori)
        {
            using var session = await context.Klient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriKollektion.InsertOneAsync(session, kategori);
                await session.CommitTransactionAsync();
            }

            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
            //if (string.IsNullOrEmpty(kategori.Id))

            //    kategori.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();

            //await kategoriKollektion.InsertOneAsync(kategori);
        }

        public async Task<List<Kategori>> HamtaAllaKategorierAsync()
        {
            return await kategoriKollektion.Find(_ => true).ToListAsync();
        }

        public async Task<bool> TaBortKategoriAsync(Kategori kategori)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategori.Id);
            var resultat = await kategoriKollektion.DeleteOneAsync(filter);
            return resultat.DeletedCount > 0;
        }

        public async Task<bool> UppdateraKategoriNamnAsync(Kategori kategori, string nyttNamn)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategori.Id);
            var update = Builders<Kategori>.Update.Set(k => k.Namn, nyttNamn);
            var resultat = await kategoriKollektion.UpdateOneAsync(filter, update);
            return resultat.ModifiedCount > 0;
        }
    }
}

