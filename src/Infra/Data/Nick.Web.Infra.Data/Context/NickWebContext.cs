using Microsoft.EntityFrameworkCore;
using Nick.Web.Domain.Produtos;
using Nick.Web.Domain.Produtos.Models;
using Nick.Web.Infra.Data.FluentApi;

namespace Nick.Web.Infra.Data.Context
{
    public class NickWebContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Produto>(new ProdutoMapping());
            modelBuilder.ApplyConfiguration<Pedido>(new PedidoMapping());
            modelBuilder.ApplyConfiguration<ItemPedido>(new ItemPedidoMapping());
        }
    }
}
