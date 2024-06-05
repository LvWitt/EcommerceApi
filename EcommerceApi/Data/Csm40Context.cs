using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Data;

public class Csm40Context : DbContext
{
    public Csm40Context(): base() //Faz passagem das opções para o construtor do dbcontext
    {

    }   
    public Csm40Context(DbContextOptions<Csm40Context> options) : base(options) //Faz passagem das opções para o construtor do dbcontext
    {

    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoProduto> PedidoProdutos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PedidoProduto>()
            .HasKey(pp => new { pp.PedidoId, pp.ProdutoId });
    }
}