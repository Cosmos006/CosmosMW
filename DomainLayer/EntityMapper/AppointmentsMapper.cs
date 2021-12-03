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
    public class AppointmentsMapper : IEntityTypeConfiguration<Appointments>
    {
        public void Configure(EntityTypeBuilder<Appointments> builder)
        {
            builder.HasKey(x => x.AppointmentId).HasName("pk_appointmentid");
            builder.Property(x => x.AppointmentId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.AppointmentType)
                .HasColumnName("AppointmentType")
                .HasColumnType("CHAR");

            builder.Property(x => x.Diagnosis)
                .HasColumnName("Diagnosis")
                .HasColumnType("VARCHAR(25)");

            builder.Property(x => x.PatientId)
              .HasColumnName("PatientId")
              .HasColumnType("UUID");

            builder.Property(x => x.PhysicianId)
              .HasColumnName("PhysicianId")
              .HasColumnType("UUID");

            builder.Property(x => x.NurseId)
              .HasColumnName("NurseId")
              .HasColumnType("UUID");

            builder.Property(x => x.Status)
                .HasColumnName("Status")
                .HasColumnType("CHAR");

            builder.Property(x => x.AppointmentDateTime)
                .HasColumnName("AppointmentDateTime")
                .HasColumnType("TIMESTAMP");

            builder.Property(x => x.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .HasColumnType("TIMESTAMP");

            builder.Property(x => x.ModifiedReason)
              .HasColumnName("ModifiedReason")
              .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.DeletedBy)
                .HasColumnName("DeletedBy")
                .HasColumnType("UUID");

            builder.Property(x => x.DeletedDate)
              .HasColumnName("DeletedDate")
              .HasColumnType("TIMESTAMP");

            builder.Property(x => x.DeletedReason)
              .HasColumnName("DeletedReason")
              .HasColumnType("CHARACTER VARYING");

        }
    }
}
