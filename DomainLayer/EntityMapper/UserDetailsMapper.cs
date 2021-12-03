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
    public class UserDetailsMapper : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.HasKey(x => x.UserDetailsId).HasName("pk_userid");
            builder.Property(x => x.UserDetailsId).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("UUID");

            builder.Property(x => x.UserName)
              .HasColumnName("UserName")
              .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.Password)
              .HasColumnName("Password")
              .HasColumnType("CHARACTER VARYING");

            builder.Property(x => x.Status)
              .HasColumnName("Status")
              .HasColumnType("BOOLEAN");

            builder.Property(x => x.IsFirstLogIn)
            .HasColumnName("IsFirstLogIn")
            .HasColumnType("BOOLEAN");


            builder.Property(x => x.NoOfAttempts)
            .HasColumnName("NoOfAttempts")
            .HasColumnType("INT");//10:01

            //builder.HasKey(x => x.RoleRefId).HasName("fk_roleid");
            builder.Property(x => x.RoleId)
             .HasColumnName("RoleId")
             .HasColumnType("UUID");
        }
    }
}
