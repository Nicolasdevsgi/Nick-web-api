using Nick.Web.Domain.Base.Entidade;
using System;
using System.Collections.Generic;

namespace Nick.Web.Domain.Produtos.Models
{
    public class Pedido : EntidadeBasica
    {
        public DateTime DataPedido { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }
    }
}
