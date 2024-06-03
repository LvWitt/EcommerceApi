using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class Categoria
    {
        [Required(ErrorMessage = "Qtd eh obrigatorio")]
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
