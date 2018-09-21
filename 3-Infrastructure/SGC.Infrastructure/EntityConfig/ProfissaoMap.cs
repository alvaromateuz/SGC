using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Profissao> builder)
        {
            #region Configurações de Profissão
            builder.Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder.Property(e => e.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();
            #endregion
        }
    }
}