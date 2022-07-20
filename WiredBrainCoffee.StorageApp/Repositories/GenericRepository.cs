namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _entities = new();
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
}
