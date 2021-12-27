using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiRepositoryPattern.Data.EFCore;
using DotNetCoreWebApiRepositoryPattern.Models;

namespace DotNetCoreWebApiRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyBaseController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}