using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;

namespace DotNetCoreWebApiRepositoryPattern.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, MyDBContext>
    {
        private readonly MyDBContext _context;

        public EfCoreStarRepository(MyDBContext context) : base(context)
        {
            this._context = context;
        }
    }
}