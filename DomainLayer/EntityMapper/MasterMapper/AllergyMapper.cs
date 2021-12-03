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
    public class AllergyMapper : IEntityTypeConfiguration<Allergy>
    {
        public void Configure(EntityTypeBuilder<Allergy> builder)
        {
            builder.HasKey(x => x.AllergyId).HasName("pk_allergyid");
            builder.Property(x => x.AllergyId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.AllergyCode)
                .HasColumnName("AllergyCode")
                .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.AllergyType)
                .HasColumnName("AllergyType")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.AllergyName)
                .HasColumnName("AllergyName")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.ClinicalInformation)
                .HasColumnName("ClinicalInformation")
                .HasColumnType("VARCHAR(50)");
        }
    }
}
