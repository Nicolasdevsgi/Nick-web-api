using Microsoft.Extensions.DependencyInjection;
using Nick.Web.Domain.Produtos.Repositorys;
using Nick.Web.Infra.Data.Repositorys;
using Nick.Web.Infra.Data.Transactions;

namespace Nick.Web.Infra.CrossCutting
{
    public static class NativeDependecyInjection
    {
        public static void RegistrarDependencias(IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IItemPedidoRepository, ItemPedidoRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
