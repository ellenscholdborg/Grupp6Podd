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

        public MongoClient Klient { get; }

        public MongoDBService()
        {

             Klient = new MongoClient("mongodb+srv://ellish100_db_user:PoddGrupp6@poddprojektgrupp6.jnfv6bw.mongodb.net/?retryWrites=true&w=majority&appName=PoddProjektGrupp6");
             this.databas = Klient.GetDatabase("PoddProjektGrupp6");
            kategoriKollektion = this.databas.GetCollection<Kategori>("Kategorier");
            poddKollektion = this.databas.GetCollection<Podd>("Poddar");
        }
        public IMongoDatabase GetDatabase()
        {
            return databas;
        }

    }
}
