
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyDBContext>, IEfCoreMovieRepository
    {
        public EfCoreMovieRepository(MyDBContext context) : base(context)
        {

        }

        public void DoSomethingSpecial()
        {
            base._context.Set<Movie>().ToList();
        }
    }
}