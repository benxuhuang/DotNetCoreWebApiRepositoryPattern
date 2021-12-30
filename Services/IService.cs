

namespace DotNetCoreWebApiRepositoryPattern.Services
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task Delete(T entity);
    }
}