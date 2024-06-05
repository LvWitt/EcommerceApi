using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public List<PedidoProduto>? PedidoProdutos { get; set; }
    }
}
