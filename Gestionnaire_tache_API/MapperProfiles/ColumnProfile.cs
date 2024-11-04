using AutoMapper;
using Gestionnaire_tache_API.Dtos;
using Gestionnaire_tache_API.Model;

namespace Gestionnaire_tache_API.MapperProfiles
{
    public class ColumnProfile : Profile
    {
        public ColumnProfile()
        {
            CreateMap<ColumnDto, Column>().ReverseMap(); 
        }
    }
}
