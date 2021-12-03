using DomainLayer.Models.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class RoleMasterMapper :  IEntityTypeConfiguration<RoleMaster>
    {
        

        public void Configure(EntityTypeBuilder<RoleMaster> builder)
        {
            builder.HasKey(x => x.RoleId).HasName("pk_roleid");
            builder.Property(x => x.RoleId).ValueGeneratedOnAdd()
                    .HasColumnName("Id")
                    .HasColumnType("UUID");

            builder.Property(x => x.Role)
                  .HasColumnName("Role")
                  .HasColumnType("VARCHAR(50)");
        }
    }
}
