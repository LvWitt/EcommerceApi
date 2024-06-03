using AutoMapper;
using EcommerceApi.Data;
using Microsoft.AspNetCore.Mvc;
using EcommerceApi.Data.Dtos;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    private ProdutoContext _context;
    private IMapper _mapper;

    public ProdutosController(ProdutoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarProduto([FromBody] CreateProdutoDto produtoDto)
    {
        Produto produto = _mapper.Map<Produto>(produtoDto);
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarProdutoPorId), new {id =  produto.Id}, produto);
    }

    [HttpGet("ListarProdutos")]
    public IEnumerable<Produto> RecuperarProdutos([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Produtos.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarProdutoPorId(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
        if (produto == null) return NotFound();
        return Ok(produto);
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarProduto(int id)
    {
        var produto = _context.Produtos.FirstOrDefault(
            produto => produto.Id == id);
        if (produto == null) return NotFound();
        _context.Remove(produto);
        _context.SaveChanges();
        return NoContent();
    }
}
