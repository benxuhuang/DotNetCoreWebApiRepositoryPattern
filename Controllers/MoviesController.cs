using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiRepositoryPattern.Data.EFCore;
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Services;
using AutoMapper;
using DotNetCoreWebApiRepositoryPattern.Resources;

namespace DotNetCoreWebApiRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : MyBaseController<Movie>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService movieService, IMapper mapper) : base(movieService)
        {
            this._mapper = mapper;
            this._movieService = movieService;
        }

        [HttpGet]
        public override async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            var list = await _movieService.GetAll();
            var movieResources = _mapper.Map<IEnumerable<Movie>, IEnumerable<MovieResource>>(list);
            return Ok(movieResources);
        }

        [HttpPost]
        public override async Task<ActionResult<Movie>> Post(Movie item)
        {
            try
            {
                var createdItem = await _movieService.Create(item);
                return Ok(createdItem);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}