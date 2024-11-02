using Gestionnaire_tache_API.Dtos;
using Gestionnaire_tache_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestionnaire_tache_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnController : ControllerBase
    {
        private readonly IColumnService _columnService;
        public ColumnController(IColumnService columnService)
        {
            _columnService = columnService;
        }

        [HttpGet]
        public async Task<ActionResult<CreateColumnDto>> Get(int Id)
        {
            var ColumnDto = await _columnService.
        }



        [HttpPost]
        public async Task<IActionResult> Post(CreateColumnDto createColumnDto)
        {
            var response = await _columnService.CreateAsync(createColumnDto);
            return CreatedAtAction(nameof(Get), new {id = response}); 
        }
    }
}
