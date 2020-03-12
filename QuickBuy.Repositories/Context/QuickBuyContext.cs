using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ObjectValue;
using QuickBuy.Repositories.Config;

namespace QuickBuy.Repositories.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento()
            {
                Id = 1,
                Nome = "Boleto",
                Descricao = "Forma de Pagamento Boleto"
            },
               new FormaPagamento()
               {
                   Id = 2,
                   Nome = "Cartão de Crédito",
                   Descricao = "Forma de Pagamento Cartão de Crédito"
               },
               new FormaPagamento()
               {
                   Id = 3,
                   Nome = "Depósito",
                   Descricao = "Forma de Pagamento Depósito"
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}
