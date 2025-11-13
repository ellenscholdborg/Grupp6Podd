using MongoDB.Bson.Serialization.Attributes;
using System.Reflection.Metadata;

namespace Modeller
{
    public class Podd
    {

        [BsonId] // anger att detta är dokumentents unika _id
        public int Id { get; set; }

        [BsonElement("Namn")]
        public string Namn { get; set; }

        public Podd (int nyttId, string NyttNamn)
        {
            Id = nyttId;
            Namn = NyttNamn;
        }

    }
}
