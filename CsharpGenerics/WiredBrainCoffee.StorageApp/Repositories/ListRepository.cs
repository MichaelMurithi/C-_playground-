using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _entities = new();

        public IEnumerable<T> GetAll()
        {
           return _entities.ToList();
        }

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
            //Everything is already saved in the List<T>
        }

        public void Remove(T entity) => _entities.Remove(entity);
    }
}
