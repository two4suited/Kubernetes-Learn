using MongoDB.Driver;

namespace KubeLearn.API.Data.Repository;

public class MongoRepository<T> : IRepository<T>
{
    public readonly IMongoCollection<T> _collection;
    public MongoRepository(MongoDbContext context,string collectionName)
    {
        _collection = context.Database.GetCollection<T>(collectionName);
    }

    public async Task<IQueryable<T>> GetAll()
    {
        return await Task.FromResult(_collection.AsQueryable());
    }

    public async Task<T> Add(T obj)
    {
       await _collection.InsertOneAsync(obj);
       return obj;

    }
}