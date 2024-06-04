using AutoMapper;
using EcommerceApi.Data;
using Microsoft.AspNetCore.Mvc;
using EcommerceApi.Data.Dtos;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly CategoriaContext _context;
    private readonly IMapper _mapper;

    public CategoriasController(CategoriaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarCategoria([FromBody] CreateCategoriaDto CategoriaDto)
    {
        Categoria Categoria = _mapper.Map<Categoria>(CategoriaDto);
        _context.Categorias.Add(Categoria);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarCategoriaPorId), new { id = Categoria.Id }, Categoria);
    }

    [HttpGet("ListarCategorias")]
    public IEnumerable<Categoria> RecuperarCategorias([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Categorias.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarCategoriaPorId(int id)
    {
        var Categoria = _context.Categorias.FirstOrDefault(Categoria => Categoria.Id == id);
        if (Categoria == null) return NotFound();
        return Ok(Categoria);
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarCategoria(int id)
    {
        var Categoria = _context.Categorias.FirstOrDefault(
            Categoria => Categoria.Id == id);
        if (Categoria == null) return NotFound();
        _context.Remove(Categoria);
        _context.SaveChanges();
        return NoContent();
    }
}
