using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeller
{
    public class Avsnitt
    {
        [BsonId] 
        public string Id { get; set; }

        [BsonElement("Rubrik")]
        public string Rubrik { get; set; }
        public DateTimeOffset Publiceringsdatum { get; set; }
        public string Lank { get; set; }
        public string? KällaReferens { get; set; }

        public string Beskrivning { get; set; }
        public string Sammanfattning { get; set; }
        public Avsnitt()
        {
            
        }

    }
} 

