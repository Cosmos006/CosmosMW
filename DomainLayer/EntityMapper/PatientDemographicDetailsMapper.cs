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
    public class PatientDemographicDetailsMapper : IEntityTypeConfiguration<PatientDemographicDetails>
    {
        public void Configure(EntityTypeBuilder<PatientDemographicDetails> builder)
        {
            builder.HasKey(x => x.PatientDemographicId).HasName("pk_patientdemographicid");
            builder.Property(x => x.PatientDemographicId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.Age)
                .HasColumnName("Age")
                .HasColumnType("INT");

            builder.Property(x => x.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .HasColumnType("DATE");

            builder.Property(x => x.Contact)
               .HasColumnName("Contact")
               .HasColumnType("BIGINT");

            builder.Property(x => x.Email)
               .HasColumnName("Email")
               .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.Gender)
                .HasColumnName("Gender")
                .HasColumnType("CHAR");

            builder.Property(x => x.Race)
                .HasColumnName("Race")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.Ethinicity)
                .HasColumnName("Ethinicity")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.Address)
               .HasColumnName("Address")
               .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.PreviousAllergies)
                .HasColumnName("PreviousAllergies")
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.IsFatal)
               .HasColumnName("IsFatal")
               .HasColumnType("BOOLEAN");

            builder.Property(x => x.PatientRelativeId)
                .HasColumnName("PatientRelativeId")
                .HasColumnType("UUID");

        }
    }
}
