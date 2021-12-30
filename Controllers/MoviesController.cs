using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiRepositoryPattern.Data.EFCore;
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Services;

namespace DotNetCoreWebApiRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyBaseController<Movie>
    {
        public MoviesController(IMovieService movieService) : base(movieService)
        {

        }
    }
}