using Gestionnaire_tache_API.Dtos;
using Gestionnaire_tache_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestionnaire_tache_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITacheService _tacheService; 

        public TaskController(ITacheService tacheService)
        {
            _tacheService = tacheService;
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<TacheDto>>> GetAll()
        {
            return Ok(await _tacheService.GetAllTacheAsync());
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<TacheDto>> GetById(int id)
        {
            return Ok(await _tacheService.GetByIdAsync(id));
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<int>> Create(TacheDto tacheDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _tacheService.CreateAsync(tacheDto);

            return CreatedAtAction(nameof(GetById), new { id = response });
        }

    }
}
