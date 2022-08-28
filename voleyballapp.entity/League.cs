using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<LeagueTeam> LeagueTeam { get; set; }
    }
}