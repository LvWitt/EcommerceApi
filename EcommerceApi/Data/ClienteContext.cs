using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Data;

public class ClienteContext : DbContext
{
    public ClienteContext(): base() //Faz passagem das opções para o construtor do dbcontext
    {

    }   
    public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) //Faz passagem das opções para o construtor do dbcontext
    {

    }

    public DbSet<Cliente> Clientes { get; set; }
}