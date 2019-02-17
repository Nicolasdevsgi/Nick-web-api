using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nick.Web.Domain.Produtos;
using Nick.Web.Infra.Data.FluentApi.Base;

namespace Nick.Web.Infra.Data.FluentApi
{
    public class ProdutoMapping : FluentApiBase, IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(n => n.Nome).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Descricao).IsRequired();
            builder.Property(p => p.Preco).IsRequired();
        }
    }
}
