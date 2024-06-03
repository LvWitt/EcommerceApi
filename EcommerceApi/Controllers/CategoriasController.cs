using EcommerceApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriasController : ControllerBase
{
    private static int idCategoria = 0;
    private static List<Categoria> categorias = new List<Categoria>();

    [HttpPost]
    public void AdicionarCategoria([FromBody] Categoria categoria)
    {
        categoria.Id = idCategoria;
        idCategoria++;
        categorias.Add(categoria);
        Console.WriteLine(categoria.Id);
        Console.WriteLine(categoria.Nome);
    }

    [HttpGet("ListarCategorias")]
    public List<Categoria> ListarCategoria()
    {
        return categorias;
    }
}
