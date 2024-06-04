using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Data;

public class CategoriaContext : DbContext
{
    public CategoriaContext(): base() //Faz passagem das opções para o construtor do dbcontext
    {

    }   
    public CategoriaContext(DbContextOptions<CategoriaContext> options) : base(options) //Faz passagem das opções para o construtor do dbcontext
    {

    }

    public DbSet<Categoria> Categorias { get; set; }
}