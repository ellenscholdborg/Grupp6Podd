using MongoDB.Bson.Serialization.Attributes;
using System.Reflection.Metadata;

namespace Modeller
{
    public class Podd
    {

        [BsonId] // anger att detta är dokumentents unika _id
        public string Id { get; set; }

        [BsonElement("Namn")]
        public string Namn { get; set; }

        public Podd (string nyttId, string NyttNamn)
        {
            Id = nyttId;
            Namn = NyttNamn;
        }

    }
}
