using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    /// <summary>
    /// A delegate is like a 'function pointer'
    /// In this case itemAdded delegate is Called every time an item is added
    /// </summary>
    /// <param name="item"></param>
    public delegate void ItemAdded<T>(T item);
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        private readonly ItemAdded<T>? _itemAddedCallback;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext, ItemAdded<T>? itemAddedCallback = null)
        {
            _dbContext = dbContext;
            _itemAddedCallback = itemAddedCallback;
            _dbSet = dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }

        public T GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _itemAddedCallback?.Invoke(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
