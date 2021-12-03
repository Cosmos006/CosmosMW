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
    public class DiagnosisMapper : IEntityTypeConfiguration<Diagnosis>
    {
        public void Configure(EntityTypeBuilder<Diagnosis> builder)
        {
            builder.HasKey(x => x.DiagnosisId).HasName("pk_diagnosisid");
            builder.Property(x => x.DiagnosisId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.DiagnosisCode)
                .HasColumnName("DiagnosisCode")
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
