using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Data.Dtos;

public class CreateProdutoDto
{
    [Required(ErrorMessage = "O nome do produto é obrigatório")]
    public string? Nome { get; set; }
    [Required(ErrorMessage = "A descrição é obrigatória")]
    public string? Descricao { get; set; }
    [Required(ErrorMessage = "Ter uma categoria é obrigatório")]
    public string? Categoria { get; set; }
    public string? Imagem { get; set; }
    [Required]
    [Range(-1, 999999999, ErrorMessage = "O preço não pode ser negativo")]
    public int Preco { get; set; }
    [Required]
    [Range(-1, 999999999, ErrorMessage = "O preço não pode ser negativo")]
    public int Quantidade { get; set; }
}
