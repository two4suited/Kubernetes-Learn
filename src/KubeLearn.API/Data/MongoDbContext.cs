using KubeLearn.API.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KubeLearn.API.Data;

public class MongoDbContext
{
    private MongoClient _client;
    private IMongoDatabase _database;
    
    public MongoDbContext(IOptions<Config> configuration)
    {
        Setup(configuration.Value.Mongo);
    }

    public MongoDbContext(MongoConfig settings)
    {
        Setup(settings);
    }

    private void Setup(MongoConfig settings)
    {
        var connectionString = new MongoConnectionString(settings).ConnectionString;
        _client = new MongoClient(connectionString);
        _database = _client.GetDatabase(settings.Database);
    }
    public IMongoClient Client => _client;

    public IMongoDatabase Database => _database;
}