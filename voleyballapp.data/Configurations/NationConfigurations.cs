using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using voleyballapp.entity;

namespace voleyballapp.data.Configurations
{
    public class NationConfigurations : IEntityTypeConfiguration<Nation>
    {
        public void Configure(EntityTypeBuilder<Nation> builder)
        {
            
        }
    }
}