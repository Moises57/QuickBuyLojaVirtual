using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repositories.Context;

namespace QuickBuy.Repositories.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(QuickBuyContext contetx) : base(contetx)
        {
        }
    }
}
