namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
