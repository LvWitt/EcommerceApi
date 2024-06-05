using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class PedidoProduto
    {
        public int PedidoId { get; set; }
        public Pedido? Pedido { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
