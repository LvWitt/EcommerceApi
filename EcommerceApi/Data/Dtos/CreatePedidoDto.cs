using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Data.Dtos;

public class CreatePedidoDto
{
    [Required(ErrorMessage = "O ID do pedido é obrigatório")]
    public int? Id { get; set; }

    [Required(ErrorMessage = "Os dados do cliente são obrigatórios")]
    public string? ClienteCpf { get; set; }

    [Required(ErrorMessage = "Os dados do produto são obrigatórios")]
    public List<string>? NomesProdutos { get; set; }
}
