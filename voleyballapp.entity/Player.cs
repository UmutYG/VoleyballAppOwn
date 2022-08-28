using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string  Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public Nation Nation { get; set; }
        public int? NationId { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public PlayerStat PlayerStats { get; set; }
        public string imgUrl { get; set; }
        


    }   
}