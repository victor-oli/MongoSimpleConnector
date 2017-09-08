using MongoDB.Driver;

namespace MongoSimpleConnector
{
    public class MongoManager
    {
        private static string mongoDbConnection;
        private static string mongoDbName;
        private static IMongoClient _client;
        private static IMongoDatabase _db;

        public static void Config(string mongoDbConnection, string mongoDbName)
        {
            MongoManager.mongoDbConnection = mongoDbConnection;
            MongoManager.mongoDbName = mongoDbName;
        }

        public static IMongoCollection<T> open<T>(string collectionName) where T : class
        {
            _client = new MongoClient(mongoDbConnection);
            _db = _client.GetDatabase(mongoDbName);

            return _db.GetCollection<T>(collectionName);
        }
    }
}