using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using voleyballapp.entity;

namespace voleyballapp.data.Configurations
{
    public class LeagueTeamConfigurations : IEntityTypeConfiguration<LeagueTeam>
    {
        public void Configure(EntityTypeBuilder<LeagueTeam> builder)
        {
            builder.HasKey(t=> new{ 
                    t.TeamId, t.LeagueId
                });
            
            builder
                .HasOne(l=>l.League)
                .WithMany(lt=>lt.LeagueTeam)
                .HasForeignKey(l=>l.LeagueId);
            
            builder
                .HasOne(l=>l.Team)
                .WithMany(lt=>lt.LeagueTeam)
                .HasForeignKey(l=>l.TeamId);

            
        }
    }
}