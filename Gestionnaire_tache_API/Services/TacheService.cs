using AutoMapper;
using Gestionnaire_tache_API.Data;
using Gestionnaire_tache_API.Dtos;
using Gestionnaire_tache_API.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Gestionnaire_tache_API.Services
{
    public interface ITacheService
    {
        Task<int> CreateAsync(TacheDto tacheDto);
        Task<TacheDto> GetByIdAsync(int id);
        Task<List<TacheDto>> GetAllTacheAsync();
    }

    public class TacheService : ITacheService
    {
        private readonly GestionnaireDbContext _gestionnaireDbContext;
        private readonly IMapper _mapper;

        public TacheService(GestionnaireDbContext gestionnaireDbContext, IMapper mapper)
        {
            _gestionnaireDbContext = gestionnaireDbContext;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(TacheDto tacheDto)
        {

            var tacheToCreate = _mapper.Map<Tache>(tacheDto);


            var currentColumn = _gestionnaireDbContext.Columns.FirstOrDefault(x => x.ColumnId == tacheDto.ColumnId);

            if (currentColumn == null)
            {
                throw new Exception("Must be associate with a column"); 
            }

            tacheToCreate.Column = currentColumn;

            _gestionnaireDbContext.Tasks.Add(tacheToCreate);
            await _gestionnaireDbContext.SaveChangesAsync();

            return tacheToCreate.Id; 

        }

        public async Task<List<TacheDto>> GetAllTacheAsync()
        {
            var allTaches = await _gestionnaireDbContext.Tasks.ToListAsync();

            if(allTaches == null)
            {
                throw new Exception("Not Found");
            }

            return _mapper.Map<List<TacheDto>>(allTaches);
        }

        public async Task<TacheDto> GetByIdAsync(int id)
        {
            var currentTache = await _gestionnaireDbContext.Tasks.FirstOrDefaultAsync(x => x.Id == id);

            if (currentTache == null)
            {
                throw new Exception("Not Found"); 
            }

            return _mapper.Map<TacheDto>(currentTache);
        }
    }
}
