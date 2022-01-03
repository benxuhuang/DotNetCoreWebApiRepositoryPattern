
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyDBContext>
    {
        private readonly MyDBContext _context;

        public EfCoreMovieRepository(MyDBContext context) : base(context)
        {
            this._context = context;
        }
    }
}