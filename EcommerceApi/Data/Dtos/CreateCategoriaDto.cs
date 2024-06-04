using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Data.Dtos;

public class CreateCategoriaDto
{
    [Required(ErrorMessage = "O nome do categoria é obrigatório")]
    public string? Nome { get; set; }
}