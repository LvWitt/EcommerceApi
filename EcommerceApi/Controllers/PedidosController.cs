using AutoMapper;
using EcommerceApi.Data;
using Microsoft.AspNetCore.Mvc;
using EcommerceApi.Data.Dtos;
using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{
    private readonly Csm40Context _context;
    private readonly IMapper _mapper;

    public PedidosController(Csm40Context context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    //[HttpPost]
    //public IActionResult AdicionarPedido([FromBody] CreatePedidoDto pedidoDto)
    //{
    //    Pedido pedido = _mapper.Map<Pedido>(pedidoDto);
    //    _context.Pedidos.Add(pedido);
    //    _context.SaveChanges();
    //    return CreatedAtAction(nameof(RecuperarPedidoPorId), new { id = pedido.Id }, pedido);
    //}
    //[HttpGet("{cpf}/{nomeProduto}")]
    //public IActionResult AdicionarPedido(string cpf, string nomeProduto)
    //{
    //    var cliente = _context.Clientes.FirstOrDefault(c => c.Cpf == cpf);
    //    var produto = _context.Produtos.FirstOrDefault(p => p.Nome == nomeProduto);

    //    if (cliente == null || produto == null) return NotFound();

    //    Pedido pedido = new Pedido { Cliente = cliente, Produto = produto };
    //    _context.Pedidos.Add(pedido);
    //    _context.SaveChanges();
    //    return CreatedAtAction(nameof(RecuperarPedidoPorId), new { id = pedido.Id }, pedido);
    //}
    [HttpPost("{cpf}")]
    public IActionResult AdicionarPedido(string cpf, [FromQuery] List<string> nomesProdutos)
    {
        var cliente = _context.Clientes.FirstOrDefault(c => c.Cpf == cpf);

        if (cliente == null) return NotFound();

        Pedido pedido = new Pedido { Cliente = cliente, PedidoProdutos = new List<PedidoProduto>() };

        foreach (var nomeProduto in nomesProdutos)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.Nome == nomeProduto);
            if (produto == null) return NotFound();

            pedido.PedidoProdutos.Add(new PedidoProduto { Produto = produto });
        }

        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarPedidoPorId), new { id = pedido.Id }, pedido);
    }

    //[HttpGet("ListarPedidos")]
    //public IEnumerable<Pedido> RecuperarPedidos([FromQuery] int skip = 0, [FromQuery] int take = 50)
    //{
    //    return _context.Pedidos.Skip(skip).Take(take);
    //}

    [HttpGet("ListarPedidos")]
    public IEnumerable<Pedido> RecuperarPedidos([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Pedidos
            .Include(p => p.Cliente)
            .Include(p => p.PedidoProdutos)
                .ThenInclude(pp => pp.Produto)
            .Skip(skip)
            .Take(take)
            .ToList();
    }


    //[HttpGet("{id}")]
    //public IActionResult RecuperarPedidoPorId(int id)
    //{
    //    var pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.Id == id);
    //    if (pedido == null) return NotFound();
    //    return Ok(pedido);
    //}
    [HttpGet("{id}")]
    public IActionResult RecuperarPedidoPorId(int id)
    {
        var pedido = _context.Pedidos
            .Include(p => p.Cliente)
            .Include(p => p.PedidoProdutos)
                .ThenInclude(pp => pp.Produto)
            .FirstOrDefault(pedido => pedido.Id == id);

        if (pedido == null) return NotFound();
        return Ok(pedido);
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarPedido(int id)
    {
        var pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.Id == id);
        if (pedido == null) return NotFound();
        _context.Remove(pedido);
        _context.SaveChanges();
        return NoContent();
    }
}