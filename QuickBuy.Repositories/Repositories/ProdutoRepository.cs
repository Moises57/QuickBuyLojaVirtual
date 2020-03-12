using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repositories.Context;

namespace QuickBuy.Repositories.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(QuickBuyContext contetx) : base(contetx)
        {
        }
    }
}
