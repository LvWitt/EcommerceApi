using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Data.Dtos;

public class CreatePedidoDto
{
    [Required(ErrorMessage = "O ID do pedido é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Os dados do cliente são obrigatórios")]
    public CreateClienteDto? Cliente { get; set; }

    [Required(ErrorMessage = "Os dados do produto são obrigatórios")]
    public CreateProdutoDto? Produto { get; set; }
}
