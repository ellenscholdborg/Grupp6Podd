
using Modeller;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Datalagret
{
    public class PoddRepository : IPoddRepository
    {
        private readonly IMongoCollection<Podd> poddKollektion;

        public PoddRepository(IMongoDatabase databas)
        {
            poddKollektion = databas.GetCollection<Podd>("Poddar");
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

        public async Task<bool> TaBortPoddAsync(Podd podd)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, podd.Id);
            var resultat = await poddKollektion.DeleteOneAsync(filter);
            return resultat.DeletedCount > 0;
        }

        public async Task<bool> UppdateraPoddNamnAsync(Podd podd, string nyttNamn)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, podd.Id);
            var update = Builders<Podd>.Update.Set(p => p.Namn, nyttNamn);
            var resultat = await poddKollektion.UpdateOneAsync(filter, update);
            return resultat.ModifiedCount > 0;
        }

        public async Task<bool> UppdateraPoddKategoriAsync(Podd podd, string nyKategoriId)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, podd.Id);
            var update = Builders<Podd>.Update.Set(p => p.KategoriId, nyKategoriId);
            var resultat = await poddKollektion.UpdateOneAsync(filter, update);
            return resultat.ModifiedCount > 0;
        }

    }
}


