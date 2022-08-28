using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using voleyballapp.entity;

namespace voleyballapp.data.Configurations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Team>().HasData(
                new Team(){TeamId = 1, Name = "VAKIFBANK", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 2, Name = "YEŞİLYURT", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 3, Name = "AYDIN B.ŞEHİR BLD.", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 4, Name = "PTT", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 5, Name = "NİLÜFER BLD.", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 6, Name = "SARIYER BLD.", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 7, Name = "ECZACIBAŞI", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 8, Name = "KUZEYBORU", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 9, Name = "KARAYOLLARI", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 10, Name = "MERT GRUP SİGORTA", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 11, Name = "FENERBAHÇE", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 12, Name = "GALATASARAY", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 13, Name = "Bolu Bld.", Objective=1, Income = 2000, NationId=1},
                new Team(){TeamId = 14, Name = "THY", Objective=1, Income = 2000, NationId=1}
            );

            builder.Entity<League>().HasData(
                new League(){Id=1, Name="Turkish League"},
                new League(){Id=2, Name="Premier League"}
            );

            builder.Entity<LeagueTeam>().HasData(
                new LeagueTeam(){TeamId=1, LeagueId=1},
                new LeagueTeam(){TeamId=2, LeagueId=1},
                new LeagueTeam(){TeamId=3, LeagueId=1},
                new LeagueTeam(){TeamId=4, LeagueId=1},
                new LeagueTeam(){TeamId=5, LeagueId=1},
                new LeagueTeam(){TeamId=6, LeagueId=1},
                new LeagueTeam(){TeamId=7, LeagueId=1},
                new LeagueTeam(){TeamId=8, LeagueId=1},
                new LeagueTeam(){TeamId=9, LeagueId=1},
                new LeagueTeam(){TeamId=10, LeagueId=1},
                new LeagueTeam(){TeamId=11, LeagueId=1},
                new LeagueTeam(){TeamId=12, LeagueId=1},
                new LeagueTeam(){TeamId=13, LeagueId=1},
                new LeagueTeam(){TeamId=14, LeagueId=1}
            );

            builder.Entity<PlayerStat>().HasData(
                new PlayerStat(){Id=1, PlayerId=1,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=2, PlayerId=2,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=3, PlayerId=3,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=4, PlayerId=4,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=5, PlayerId=5,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=6, PlayerId=6,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=7, PlayerId=7,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=8, PlayerId=8,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=9, PlayerId=9,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=10, PlayerId=10,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=11, PlayerId=11,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=12, PlayerId=12,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=13, PlayerId=13,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000},
                new PlayerStat(){Id=14, PlayerId=14,Height=183, Weight=65, Number=1, Spike=280, Block=270, Reception=85, Attack=75, Serve=95, Price=5000}
            );

            builder.Entity<Nation>().HasData(
                new Nation(){NationId = 1, Name="Turkey"},
                new Nation(){NationId = 2, Name="England"},
                new Nation(){NationId = 3, Name="Italy"},
                new Nation(){NationId = 4, Name="Brazil"},
                new Nation(){NationId = 5, Name="USA"},
                new Nation(){NationId = 6, Name="Netherlands"}
            );

            builder.Entity<Player>().HasData(
                new Player() {PlayerId=1, Name="Buket Gülübay", Position="Setter", Age=23,NationId=1,TeamId=1, imgUrl = "1.png"},
                new Player() {PlayerId=2, Name="Cansu Özbay", Position="Setter", Age=25,NationId=1,TeamId=1, imgUrl = "2.png"},
                new Player() {PlayerId=3, Name="Paola Egonu", Position="Opposite", Age=23,NationId=1,TeamId=3, imgUrl = "3.jfif"},
                new Player() {PlayerId=4, Name="Alexia Căruțașu", Position="Opposite", Age=19,NationId=1,TeamId=1, imgUrl = "3.jfif"},
                new Player() {PlayerId=5, Name="Gabriela Guimarães (Gabi)", Position="Outside Hitter", Age=28,NationId=1,TeamId=4, imgUrl = "1.png"},
                new Player() {PlayerId=6, Name="Kara Bajema", Position="Outside Hitter", Age=24,NationId=1,TeamId=5, imgUrl = "4.jfif"},
                new Player() {PlayerId=7, Name="Derya Cebecioğlu", Position="Outside Hitter", Age=21,NationId=1,TeamId=1, imgUrl = "4.jfif"},
                new Player() {PlayerId=8, Name="Nika Daalderop", Position="Outside Hitter", Age=23,NationId=1,TeamId=6, imgUrl = "1.png"},
                new Player() {PlayerId=9, Name="Bahar Akbay", Position="Middle-blocker", Age=24,NationId=1,TeamId=1, imgUrl = "5.jfif"},
                new Player() {PlayerId=10, Name="Kübra Akman", Position="Middle-blocker", Age=27,NationId=1,TeamId=1, imgUrl = "6.jfif"},
                new Player() {PlayerId=11, Name="Chiaka Ogbogu", Position="Middle-blocker", Age=27,NationId=1,TeamId=5, imgUrl = "1.png"},
                new Player() {PlayerId=12, Name="Zehra Güneş", Position="Middle-blocker", Age=23,NationId=1,TeamId=1, imgUrl = "7.jfif"},
                new Player() {PlayerId=13, Name="Ayça Aykaç", Position="Libero", Age=26,NationId=1,TeamId=1, imgUrl = "8.jfif"},
                new Player() {PlayerId=14, Name="Aylin Sarıoğlu Acar", Position="Libero", Age=27,NationId=1,TeamId=1, imgUrl = "9.jfif"}
            );
        }
    }
}