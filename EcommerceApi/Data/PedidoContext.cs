using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Data;

public class PedidoContext : DbContext
{
    public PedidoContext(): base() //Faz passagem das opções para o construtor do dbcontext
    {

    }   
    public PedidoContext(DbContextOptions<PedidoContext> options) : base(options) //Faz passagem das opções para o construtor do dbcontext
    {

    }

    public DbSet<Pedido> Pedidos { get; set; }
}