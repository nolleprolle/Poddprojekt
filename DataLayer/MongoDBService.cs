using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using ModelsLayer;

namespace DataLayer
{
    public class MongoDBService
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoDBService()
        {
            const string connectionUri =
                "mongodb+srv://OruMongoDBAdmin:lsoc123@orumongodb.ffbxjkj.mongodb.net/?appName=OruMongoDB";

            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            _client = new MongoClient(settings);

            // Välj din databas
            _database = _client.GetDatabase("OruMongoDB");
        }

        public bool TestConnection()
        {
            try
            {
                _database.RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
