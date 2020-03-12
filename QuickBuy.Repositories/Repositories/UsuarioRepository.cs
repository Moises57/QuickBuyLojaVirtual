using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repositories.Context;

namespace QuickBuy.Repositories.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(QuickBuyContext contetx) : base(contetx)
        {
        }
    }
}
