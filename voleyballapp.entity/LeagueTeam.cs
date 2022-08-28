using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class LeagueTeam
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public League League { get; set; }
        public int LeagueId{ get; set; }

        public int Win { get; set; }
        public int Lose { get; set; }
        public int matchsPlayed { get; set; }
        public int Point { get; set; }
        public int ScoreGained { get; set; }
        public int ScoreLost { get; set; }
        public int Average { get; set; }
    }
}