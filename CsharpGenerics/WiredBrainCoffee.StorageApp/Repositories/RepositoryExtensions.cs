namespace WiredBrainCoffee.StorageApp.Repositories
{
    public static class RepositoryExtensions
    {
        public static void AddBatch<T>(this IWriteRepository<T> repository, T[] entities)
        {
            foreach (var entity in entities)
            {
                repository.Add(entity);
            }

            repository.Save();
        }
    }
}
