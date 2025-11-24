using MongoDB.Bson.Serialization.Attributes;
using System.Reflection.Metadata;

namespace Modeller
{
    public class Podd
    {

        [BsonId] 
        public string Id { get; set; }

        [BsonElement("Namn")]
        public string Namn { get; set; }
        public string Url { get; set; }
        public string KategoriId { get; set; }

        public Podd()
        {       
        }

    }
}
