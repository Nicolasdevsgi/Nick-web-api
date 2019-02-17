using Nick.Web.Domain.Base.Entidade;

namespace Nick.Web.Domain.Produtos.Models
{
    public class ItemPedido : EntidadeBasica
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
