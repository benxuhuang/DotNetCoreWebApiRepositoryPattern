using DotNetCoreWebApiRepositoryPattern.Data.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data
{
    public interface IUnitOfWork : IDisposable
    {
        EfCoreMovieRepository MovieRep { get; }
        EfCoreStarRepository StarRep { get; }
        Task<int> CommitAsync();
    }
}
