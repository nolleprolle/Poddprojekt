using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Poddprojektet
{
    internal class MongoDBService
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoDBService()
        {
            const string connectionUri = "mongodb+srv://OruMongoDBAdmin:lsoc123@orumongodb.ffbxjkj.mongodb.net/?appName=OruMongoDB";

            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);

            _client = new MongoClient(settings);
            _database = _client.GetDatabase("admin"); // använd "admin" eller er databas
        }

        public bool TestConnection()
        {
            try
            {
                var result = _database.RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Ping OK – MongoDB är ansluten!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid anslutning: {ex.Message}");
                return false;
            }
        }

        public IMongoDatabase GetDatabase() => _database;
    }
}
