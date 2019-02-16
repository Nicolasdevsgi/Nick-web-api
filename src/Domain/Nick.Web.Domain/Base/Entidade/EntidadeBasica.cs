using System;

namespace Nick.Web.Domain.Base.Entidade
{
    public abstract class EntidadeBasica
    {
        public EntidadeBasica()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
