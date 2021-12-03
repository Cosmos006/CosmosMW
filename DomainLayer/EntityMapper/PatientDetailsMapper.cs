using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class PatientDetailsMapper : IEntityTypeConfiguration<PatientDetails>
    {
        public void Configure(EntityTypeBuilder<PatientDetails> builder)
        {
            builder.HasKey(x => x.PatientDetailsId).HasName("pk_patientdetailsid");
            builder.Property(x => x.PatientDetailsId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.Title)
                .HasColumnName("Title")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.Contact)
                .HasColumnName("Contact")
                .HasColumnType("BIGINT");

            builder.Property(x => x.PatientDemographicId)
                   .HasColumnName("PatientDemographicId")
                   .HasColumnType("UUID");

            builder.Property(x => x.UserId)
               .HasColumnName("UserId")
               .HasColumnType("UUID");

            builder.Property(x => x.IsActive)
              .HasColumnName("IsActive")
              .HasColumnType("BOOLEAN");
        }
    }
}
