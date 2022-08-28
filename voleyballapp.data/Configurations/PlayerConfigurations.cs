using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using voleyballapp.entity;

namespace voleyballapp.data.Configurations
{
    public class PlayerConfigurations : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p=>p.PlayerId);

            builder.Property(p=>p.Name).IsRequired().HasMaxLength(100);

            // builder.Property(p=>p.DataAdded).HasDefaultValueSql("getdate()");
            
        }
    }
}