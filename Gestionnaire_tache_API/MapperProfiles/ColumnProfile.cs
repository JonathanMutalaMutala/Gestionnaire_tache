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


            CreateMap<TacheDto, Tache>()
                 .ForMember(dest => dest.Column, opt => opt.Ignore()) // On ignore la navigation lors de la création
                 .ReverseMap()
                 .ForMember(dest => dest.ColumnId, opt => opt.MapFrom(src => src.Column.ColumnId)); // Projeter ColumnId depuis Column


        }
    }
}
