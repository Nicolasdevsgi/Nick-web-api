using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nick.Web.Domain.Base.Repository;
using Nick.Web.Infra.Data.Context;

namespace Nick.Web.Infra.Data.Repositorys.Base
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly NickWebContext _context;

        public BaseRepository(NickWebContext context)
        {
            _context = context;
        }

        public TEntity Adicionar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public TEntity BuscarPorId(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> BuscarTodos(TEntity entity)
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }

        public void Remover(Guid id)
        {
            var entity = BuscarPorId(id);
            _context.Entry(entity).State = EntityState.Deleted;
        }
    }
}
