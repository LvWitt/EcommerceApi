using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Data;

public class ProdutoContext : DbContext
{
    public ProdutoContext(): base() //Faz passagem das opções para o construtor do dbcontext
    {

    }   
    public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options) //Faz passagem das opções para o construtor do dbcontext
    {

    }

    public DbSet<Produto> Produtos { get; set; }
}