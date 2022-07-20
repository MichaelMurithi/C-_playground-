using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T> where T : EntityBase
    {
        private readonly List<T> _entities = new();

        public T GetById(int Id)
        {
            return _entities.Single(x => x.Id == Id);
        }

        public void Add(T entity)
        {
            entity.Id = _entities.Count + 1;
            _entities.Add(entity);
        }

        public void Save()
        {
            foreach (T entity in _entities)
            {
                Console.WriteLine(entity?.ToString());
            }
        }

        public void Remove(T entity) => _entities.Remove(entity);

    }
}
