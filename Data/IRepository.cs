namespace DotNetCoreWebApiRepositoryPattern.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task<T> Update(int id, T entity);
        Task<T> Delete(int id);
        Task Remove(T entity);
    }
}
