using System;
using System.Collections.Generic;

namespace Nick.Web.Domain.Base.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity Adicionar(TEntity entity);

        TEntity BuscarPorId(Guid id);

        IEnumerable<TEntity> BuscarTodos(TEntity entity);

        void Atualizar(TEntity entity);

        void Remover(Guid id);
    }
}
