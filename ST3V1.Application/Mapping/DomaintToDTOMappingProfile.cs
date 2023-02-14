using AutoMapper;
using ST3V1.Application.DTOs;
using ST3V1.Domain.Entities;

namespace ST3V1.Application.Mapping
{
    public class DomaintToDTOMappingProfile : Profile
    {
        public DomaintToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
        }
    }
}
