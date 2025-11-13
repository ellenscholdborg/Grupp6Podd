using MongoDB.Bson.Serialization.Attributes;
using System.Reflection.Metadata;

namespace Modeller
{
    public class Podd
    {

        [BsonId] // anger att detta är dokumentents unika _id
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        public Podd (string nyttId, string NyttName)
        {
            Id = nyttId;
            Name = NyttName;
        }

    }
}
