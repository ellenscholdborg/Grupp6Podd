using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeller
{
    public class Kategori
    {
        [BsonId] // anger att detta är dokumentents unika _id
        public string Id { get; set; }

        [BsonElement("Namn")]
        public string Namn { get; set; }

        public Kategori()
        {
            
        }

    }
}

