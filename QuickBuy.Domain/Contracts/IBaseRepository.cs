using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPodId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);


    }
}
