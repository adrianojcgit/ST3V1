using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ST3V1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ST3V1.Infra.Data.EntitiesConfiguration
{
    public class ClienteConfiguration
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) 
        {

            builder.HasKey(e => e.Id);
            builder.Property(e => e.IdImportacao).IsRequired();
            builder.Property(e => e.NomeEmpresarial)
                .HasMaxLength(200).IsRequired();
            builder.Property(e => e.NomeFantasia)
                .HasMaxLength(300);
            builder.Property(e => e.PorteEmpresa)
                .HasMaxLength(1).IsRequired();
            builder.Property(e => e.FatBrutoAnual)   //Core 3.1
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            //builder.Property(e => e.FatBrutoAnual) //Core => 5.0
            //    .HasPrecision(10, 2).IsRequired();
            builder.Property(e => e.Ativo)
                .IsRequired();
        }
    }
}
