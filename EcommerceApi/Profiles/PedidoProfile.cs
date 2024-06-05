using AutoMapper;
using EcommerceApi.Data.Dtos;
using EcommerceApi.Models;

namespace EcommerceApi.Profiles;

public class PedidoProfile : Profile
{
    public PedidoProfile()
    {
        CreateMap<CreatePedidoDto, Pedido>();
    }
}