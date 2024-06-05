using AutoMapper;
using EcommerceApi.Data;
using Microsoft.AspNetCore.Mvc;
using EcommerceApi.Data.Dtos;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{
    private readonly Csm40Context _context;
    private readonly IMapper _mapper;

    public ClientesController(Csm40Context context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarCliente([FromBody] CreateClienteDto clienteDto)
    {
        Cliente cliente = _mapper.Map<Cliente>(clienteDto);
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarClientePorId), new { id = cliente.Id }, cliente);
    }

    [HttpGet("ListarClientes")]
    public IEnumerable<Cliente> RecuperarClientes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Clientes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarClientePorId(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
        if (cliente == null) return NotFound();
        return Ok(cliente);
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarCliente(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
        if (cliente == null) return NotFound();
        _context.Remove(cliente);
        _context.SaveChanges();
        return NoContent();
    }
}