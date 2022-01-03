using DotNetCoreWebApiRepositoryPattern.Data.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IEfCoreMovieRepository MovieRep { get; }
        IEfCoreStarRepository StarRep { get; }
        Task<int> CommitAsync();
    }
}
