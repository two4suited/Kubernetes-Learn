using KubeLearn.API.Configuration;
using MongoDB.Driver;

namespace KubeLearn.API.Data;

public class MongoConnectionString
{
    private readonly MongoConfig _config;

    public MongoConnectionString(MongoConfig config)
    {
        _config = config;
    }

    public string ConnectionString => $"mongodb://{_config.UserName}:{_config.Password}@{_config.ServerAddress}";
}