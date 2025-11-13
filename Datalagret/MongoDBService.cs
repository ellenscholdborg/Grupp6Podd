using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Modeller;

namespace Datalagret
{
    internal class MongoDBService
    {
        private readonly IMongoCollection<Podd> poddKollektion;

        // Uppkoppling mot klustret, databasen och kollektionen
        public MongoDBService()
        {

            var klient = new MongoClient("mongodb+srv://ellish100_db_user:<orebroUniversitet1>@poddprojektgrupp6.jnfv6bw.mongodb.net/?appName=PoddProjektGrupp6");
            var databas = klient.GetDatabase("PoddProjektGrupp6");
            poddKollektion = databas.GetCollection<Podd>("Poddar");
        }
    }
}
