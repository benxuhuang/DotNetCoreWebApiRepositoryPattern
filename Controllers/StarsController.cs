using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiRepositoryPattern.Data.EFCore;
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Services;

namespace DotNetCoreWebApiRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyBaseController<Star>
    {
        public StarsController(IStarService starService) : base(starService)
        {

        }
    }
}