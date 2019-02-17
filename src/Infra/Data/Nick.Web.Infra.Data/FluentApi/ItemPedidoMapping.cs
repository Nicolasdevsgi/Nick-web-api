using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nick.Web.Domain.Produtos.Models;
using Nick.Web.Infra.Data.FluentApi.Base;

namespace Nick.Web.Infra.Data.FluentApi
{
    public class ItemPedidoMapping : FluentApiBase, IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
        }
    }
}
