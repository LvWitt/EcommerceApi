using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome eh obrigatorio")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Cpf eh obrigatorio")]
        public string? Cpf { get; set; }
        [Required(ErrorMessage = "Cep eh obrigatorio")]
        public int Cep { get; set; }
        public string? Rua { get; set; }
        public string? Cidade { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
    }
}
