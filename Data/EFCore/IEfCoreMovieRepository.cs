
using DotNetCoreWebApiRepositoryPattern.Models;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public interface IEfCoreMovieRepository : IRepository<Movie>
    {
        void DoSomethingSpecial();
    }
}