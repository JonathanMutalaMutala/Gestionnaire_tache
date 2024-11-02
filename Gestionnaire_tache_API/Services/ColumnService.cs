using AutoMapper;
using Gestionnaire_tache_API.Data;
using Gestionnaire_tache_API.Dtos;
using Gestionnaire_tache_API.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Gestionnaire_tache_API.Services
{
    public interface IColumnService
    {
        Task<int> CreateAsync(CreateColumnDto column);
        Task<CreateColumnDto> GetAsync(int id);

    }


    public class ColumnService : IColumnService
    {
        private readonly GestionnaireDbContext _gestionnaireDbContext;
        private readonly IMapper _mapper;

        public ColumnService(GestionnaireDbContext gestionnaireDbContext, IMapper mapper)
        {
            _gestionnaireDbContext = gestionnaireDbContext;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(CreateColumnDto column)
        {
            var columnToCreate = _mapper.Map<Column>(column); 
            

            await _gestionnaireDbContext.AddAsync(columnToCreate);
            await _gestionnaireDbContext.SaveChangesAsync();

            return columnToCreate.ColumnId;

        }

        public async Task<CreateColumnDto> GetAsync(int id)
        {
          var currentColumn =  await _gestionnaireDbContext.Columns.FirstOrDefaultAsync(x => x.ColumnId == id);

            if(currentColumn == null)
            {
                throw new Exception("Not Found"); 
            }

            return _mapper.Map<CreateColumnDto>(currentColumn);
        }
    }
}
