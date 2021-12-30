using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiRepositoryPattern.Services;
using DotNetCoreWebApiRepositoryPattern.Data;

namespace DotNetCoreWebApiRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyBaseController<TEntity> : ControllerBase
    where TEntity : class, IEntity
    {
        private readonly IService<TEntity> _service;

        public MyBaseController(IService<TEntity> service)
        {
            this._service = service;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            var list = await _service.GetAll();

            return Ok(list);
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var item = await _service.GetById(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity item)
        {
            try
            {
                var createdItem = await _service.Create(item);
                return Ok(createdItem);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity item)
        {
            if (id != item.Id)
                return BadRequest();

            var updatedItem = await _service.Update(id, item);

            return Ok(updatedItem);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var item = await _service.GetById(id);

            await _service.Delete(item);

            return NoContent();
        }

    }
}