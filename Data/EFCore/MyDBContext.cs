using DotNetCoreWebApiRepositoryPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebApiRepositoryPattern.Models.EFCore
{
    public class MyDBContext : DbContext
    {
        public MyDBContext (DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Star> Star { get; set; }
    }
}