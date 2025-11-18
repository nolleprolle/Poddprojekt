using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ModelsLayer
{
    [BsonIgnoreExtraElements]
    public class Podd
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        
        public string? Name { get; set; }
        public string? Url { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string? CategoryId { get; set; }
        public List<Episode>? Episodes { get; set; } = new();
    }
}
