using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nick.Web.Domain.Base.Entidade;

namespace Nick.Web.Infra.Data.FluentApi.Base
{
    public abstract class FluentApiBase : IEntityTypeConfiguration<EntidadeBasica>
    {
        public void Configure(EntityTypeBuilder<EntidadeBasica> builder)
        {
            builder.Property(i => i.Id).IsRequired();
            builder.Property(d => d.DataCriacao).IsRequired();
            builder.HasKey(pk => pk.Id);
        }
    }
}
