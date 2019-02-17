using Nick.Web.Domain.Produtos;
using Nick.Web.Domain.Produtos.Repositorys;
using Nick.Web.Infra.Data.Context;
using Nick.Web.Infra.Data.Repositorys.Base;

namespace Nick.Web.Infra.Data.Repositorys
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(NickWebContext context) : base(context)
        {
        }
    }
}
