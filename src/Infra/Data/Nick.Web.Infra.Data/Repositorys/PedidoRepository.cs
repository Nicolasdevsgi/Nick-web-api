using Nick.Web.Domain.Produtos.Models;
using Nick.Web.Domain.Produtos.Repositorys;
using Nick.Web.Infra.Data.Context;
using Nick.Web.Infra.Data.Repositorys.Base;

namespace Nick.Web.Infra.Data.Repositorys
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(NickWebContext context) : base(context)
        {
        }
    }
}
