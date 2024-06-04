using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Data.Dtos;
public class CreateClienteDto
{
    [Required(ErrorMessage = "O nome do cliente é obrigatório")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O CPF do cliente é obrigatório")]
    public string? Cpf { get; set; }

    [Required(ErrorMessage = "A rua do cliente é obrigatória")]
    public string? Rua { get; set; }

    [Required(ErrorMessage = "O CEP do cliente é obrigatório")]
    public string? Cep { get; set; }
}
