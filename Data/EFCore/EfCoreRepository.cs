using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class, IEntity
    where TContext : DbContext
    {
        private readonly TContext _context;

        protected EfCoreRepository(TContext context)
        {
            this._context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(int id, TEntity entity)
        {
            var objectToUpdate = await _context.Set<TEntity>().FindAsync(id);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
