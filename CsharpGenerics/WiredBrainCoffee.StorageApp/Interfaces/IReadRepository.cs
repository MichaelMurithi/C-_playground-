namespace WiredBrainCoffee.StorageApp.Repositories
{
    /// <summary>
    /// A demonstration of the covariant concept use case
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
