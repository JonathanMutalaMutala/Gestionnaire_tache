﻿using Gestionnaire_tache_API.Dtos;
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
        [Route("GetAll")]
        public async Task<ActionResult<List<ColumnDto>>> GetAll()
        {
            return Ok(await _columnService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<ColumnDto>> Get(int id)
        {
            var columnDto = await _columnService.GetByIdAsync(id);

            return Ok(columnDto);
        } 

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Post(ColumnDto createColumnDto)
        {
            var response = await _columnService.CreateAsync(createColumnDto);
            return CreatedAtAction(nameof(Get), new {id = response}); 
        }
    }
}
