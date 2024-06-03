using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Nome eh obrigatorio")]
        public string? Nome { get; set; }
        [Required]
        public string? Descricao { get; set; }
        public string? Categoria { get; set; }
        public string? Imagem { get; set; }
        [Required]
        [Range(0, 9999999, ErrorMessage = "Preço não pode ser negativo")]
        public decimal Preco { get; set; }
    }
}
