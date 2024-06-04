namespace EcommerceApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public Produto? Produto { get; set; }
    }
}
