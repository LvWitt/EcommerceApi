using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Data.Dtos;
public class CreateClienteDto
{
    [Required(ErrorMessage = "O nome do cliente é obrigatório")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O CPF do cliente é obrigatório")]
    public string? Cpf { get; set; }

    [Required(ErrorMessage = "O CEP do cliente é obrigatório")]
    public int Cep { get; set; }

    [Required(ErrorMessage = "A rua do cliente é obrigatória")]
    public string? Rua { get; set; }
    public string? Cidade { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }


}
