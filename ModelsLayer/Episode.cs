using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ModelsLayer
{
    [BsonIgnoreExtraElements]
    public class Episode
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } 
        public DateTime? AirDate { get; set; }
        public string? Link { get; set; }

        //Pekar på podcast
        [BsonRepresentation(BsonType.ObjectId)]
        public string? PoddReference { get; set; }
    }
}
