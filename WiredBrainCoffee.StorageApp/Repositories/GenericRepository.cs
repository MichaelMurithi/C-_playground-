namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _entities = new();
        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Save()
        {
            foreach (T entity in _entities)
            {
                Console.WriteLine(entity?.ToString());
            }
        }
    }

    public class GenericRepositoryWithRemove<T> : GenericRepository<T>
    {
        public void Remove(T entity) => _entities.Remove(entity);
    }
}
