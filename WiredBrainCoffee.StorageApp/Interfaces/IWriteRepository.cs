namespace WiredBrainCoffee.StorageApp.Repositories
{
    /// <summary>
    /// A demonstration of the contravariant concept use case
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWriteRepository<in T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Save();
    }
}
