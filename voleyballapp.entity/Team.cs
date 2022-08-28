using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int Objective  { get; set; }
        public double Income { get; set; }
        public List<Player> Players { get; set; }
        public Nation Nation { get; set; }
        public int? NationId { get; set; }
        public List<LeagueTeam> LeagueTeam { get; set; }
        public string img { get; set; }
     

       
        
        
    }
}