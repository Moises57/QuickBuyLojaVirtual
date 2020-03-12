using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repositories.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder.Property(x => x.Nome)
               .IsRequired()
               .HasMaxLength(400);

            builder.Property(x => x.Preco)
                .HasColumnType("decimal (5,2)")
               .IsRequired();
            
        }
    }
}
