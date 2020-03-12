using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ObjectValue;
using System;

namespace QuickBuy.Repositories.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
