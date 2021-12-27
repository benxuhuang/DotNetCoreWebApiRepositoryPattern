
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyDBContext>
    {
        public EfCoreMovieRepository(MyDBContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}