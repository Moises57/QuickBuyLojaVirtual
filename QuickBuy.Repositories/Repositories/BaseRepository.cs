using QuickBuy.Domain.Contracts;
using QuickBuy.Repositories.Context;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositories.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContext Contetx;

        public BaseRepository(QuickBuyContext contetx)
        {
            Contetx = contetx;
        }

        public void Adicionar(TEntity entity)
        {
            Contetx.Set<TEntity>().Add(entity);
            Contetx.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Contetx.Set<TEntity>().Update(entity);
            Contetx.SaveChanges();
        }

        
        public TEntity ObterPodId(int id)
        {
            return Contetx.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Contetx.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            Contetx.Set<TEntity>().Remove(entity);
            Contetx.SaveChanges();
        }

        public void Dispose()
        {
            Contetx.Dispose();
        }
    }
}
