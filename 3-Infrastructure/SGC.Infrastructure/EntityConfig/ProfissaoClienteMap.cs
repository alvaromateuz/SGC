using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder
                .HasOne(c => c.Cliente)
                .WithMany(c => c.ProfissoesClientes)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasKey(c => c.Id);

            builder
                .HasOne(c => c.Profissao)
                .WithMany(c => c.ProfissoesClientes)
                .HasForeignKey(c => c.ProfissaoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
