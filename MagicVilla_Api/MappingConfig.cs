using AutoMapper;
using MagicVilla_Api.Modelos;
using MagicVilla_Api.Modelos.DTO;

namespace MagicVilla_Api
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDto>().ReverseMap();
            CreateMap<Villa, VillaUpdateDto>().ReverseMap();    


        }
    }
}
