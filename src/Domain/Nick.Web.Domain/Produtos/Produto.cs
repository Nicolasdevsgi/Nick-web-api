using Nick.Web.Domain.Base.Entidade;

namespace Nick.Web.Domain.Produtos
{
    public class Produto : EntidadeBasica
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
