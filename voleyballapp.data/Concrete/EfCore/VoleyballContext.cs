using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using voleyballapp.data.Configurations;
using voleyballapp.entity;

namespace voleyballapp.data.Concrete.EfCore
{
    
    public class VoleyballContext:DbContext
    {
        public VoleyballContext(DbContextOptions<VoleyballContext> options) : base(options)
        {
        
        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStat> PlayerStats { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=database.db");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfigurations());
            modelBuilder.ApplyConfiguration(new LeagueTeamConfigurations());
            modelBuilder.ApplyConfiguration(new LeagueConfigurations());
            modelBuilder.ApplyConfiguration(new NationConfigurations());
            modelBuilder.ApplyConfiguration(new PlayerStatConfigurations());
            modelBuilder.ApplyConfiguration(new TeamConfigurations());

            // modelBuilder.Seed(); extendlediğimiz kendi methodumuz.
        }

    }
}