using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nick.Web.Domain.Produtos.Models;
using Nick.Web.Infra.Data.FluentApi.Base;

namespace Nick.Web.Infra.Data.FluentApi
{
    public class PedidoMapping : FluentApiBase, IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.Property(d => d.DataPedido).IsRequired();
        }
    }
}
