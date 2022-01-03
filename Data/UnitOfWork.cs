using DotNetCoreWebApiRepositoryPattern.Data.EFCore;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDBContext _contenxt;

        private EfCoreMovieRepository _movieRep;
        private EfCoreStarRepository _starRep;

        public UnitOfWork(MyDBContext context)
        {
            this._contenxt = context;
        }

        public IEfCoreMovieRepository MovieRep => _movieRep ?? new EfCoreMovieRepository(_contenxt);

        public IEfCoreStarRepository StarRep => _starRep ?? new EfCoreStarRepository(_contenxt);

        public async Task<int> CommitAsync()
        {
            return await _contenxt.SaveChangesAsync();
        }

        public void Dispose()
        {
            _contenxt.Dispose();
        }
    }
}
