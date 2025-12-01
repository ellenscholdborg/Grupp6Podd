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
        private readonly IMongoDatabase databas;
        public IMongoCollection<Kategori> kategoriKollektion { get; }
        public IMongoCollection<Podd> poddKollektion { get; }

        public MongoDBService()
        {

            var klient = new MongoClient("mongodb+srv://ellish100_db_user:PoddGrupp6@poddprojektgrupp6.jnfv6bw.mongodb.net/?retryWrites=true&w=majority&appName=PoddProjektGrupp6");
            databas = klient.GetDatabase("PoddProjektGrupp6");
            kategoriKollektion = databas.GetCollection<Kategori>("Kategorier");
            poddKollektion = databas.GetCollection<Podd>("Poddar");
        }
        public IMongoDatabase GetDatabase()
        {
            return databas;
        }

    }
}
