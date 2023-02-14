using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ST3V1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ST3V1.Infra.Data.EntitiesConfiguration
{
    public class EnderecoConfiguration
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Cliente)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(e => e.ClienteId);
        }
    }
}
