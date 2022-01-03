using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyDBContext>, IEfCoreStarRepository
    {
        public EfCoreStarRepository(MyDBContext context) : base(context)
        {

        }
    }
}