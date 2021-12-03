using DomainLayer.EntityMapper;
using DomainLayer.EntityMapper.MasterMapper;
using DomainLayer.Models;
using DomainLayer.Models.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var converter = new BoolToStringConverter(mode);
            //modelBuilder.Ignore("IsFirstLogIn");
            //modelBuilder.Entity<UserDetails>().Property(x => x.IsFirstLogIn).HasConversion<string>();

            modelBuilder
            .Entity<UserDetails>().Property(x => x.UserDetailsId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new UserDetailsMapper());

            modelBuilder
           .Entity<RoleMaster>().Property(x => x.RoleId)
           .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new RoleMasterMapper());

            modelBuilder
            .Entity<EmployeeDetails>().Property(x => x.EmployeeId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new EmployeeDetailsMapper());

            modelBuilder
            .Entity<Notes>().Property(x => x.NotesId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new NotesMapper());

            modelBuilder
           .Entity<Appointments>().Property(x => x.AppointmentId)
           .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new AppointmentsMapper());

            modelBuilder
           .Entity<PatientDemographicDetails>().Property(x => x.PatientDemographicId)
           .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new PatientDemographicDetailsMapper());

            modelBuilder
           .Entity<PatientDetails>().Property(x => x.PatientDetailsId)
           .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new PatientDetailsMapper());

            modelBuilder
            .Entity<PatientRelativeDetails>().Property(x => x.PatientRelativeDetailsId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new PatientRelativeDetailsMapper());

            modelBuilder
            .Entity<Drug>().Property(x => x.DrugId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new DrugMapper());

            modelBuilder
            .Entity<Allergy>().Property(x => x.AllergyId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new AllergyMapper());

            modelBuilder
            .Entity<Diagnosis>().Property(x => x.DiagnosisId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new DiagnosisMapper());

            modelBuilder
            .Entity<Procedure>().Property(x => x.ProcedureId)
            .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.ApplyConfiguration(new ProcedureMapper());


            base.OnModelCreating(modelBuilder);
        }

    }
}
