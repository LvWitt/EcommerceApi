using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "Qtd eh obrigatorio")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome eh obrigatorio")]
        public string? Nome { get; set; }
    }
}
