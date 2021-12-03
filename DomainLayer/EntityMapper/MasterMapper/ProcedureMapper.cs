using DomainLayer.Models.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper.MasterMapper
{
    public class ProcedureMapper : IEntityTypeConfiguration<Procedure>
    {
        public void Configure(EntityTypeBuilder<Procedure> builder)
        {
            builder.HasKey(x => x.ProcedureId).HasName("pk_procedureid");
            builder.Property(x => x.ProcedureId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.ProcedureCode)
                .HasColumnName("ProcedureCode")
                .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.IsDepricated)
            .HasColumnName("IsDepricated")
            .HasColumnType("BOOLEAN");
        }
    }
}
