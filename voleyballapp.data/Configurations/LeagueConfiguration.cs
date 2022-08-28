using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using voleyballapp.entity;

namespace voleyballapp.data.Configurations
{
    public class LeagueConfigurations : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            // builder.HasData(
            //     new League(){Id=1, Name="Turkish League"},
            //     new League(){Id=2, Name="Premier League"}
            // );    BÖYLE DE OLABİLİR AMA GRUPLAYALIM EXTENSION CLASSTA.
        }
    }
}