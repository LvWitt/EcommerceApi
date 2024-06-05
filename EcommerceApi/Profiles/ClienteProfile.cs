using AutoMapper;
using EcommerceApi.Data.Dtos;
using EcommerceApi.Models;

namespace EcommerceApi.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<CreateClienteDto, Cliente>();
    }
}