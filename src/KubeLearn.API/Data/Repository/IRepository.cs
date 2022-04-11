namespace KubeLearn.API.Data.Repository;

public interface IRepository<T>
{
    Task<IQueryable<T>> GetAll();

    Task<T> Add(T obj);
        
}