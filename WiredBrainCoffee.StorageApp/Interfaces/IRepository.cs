using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IRepository<T> : IReadRepository<T> where T : IEntity
    {  
        void Add(T entity);
        void Remove(T entity);
        void Save();
    }
}
