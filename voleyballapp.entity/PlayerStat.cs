using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class PlayerStat
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Number { get; set; }
        public int Spike { get; set; }
        public int Block { get; set; }
        public int Reception { get; set; }
        public int Attack { get; set; }
        public int Serve { get; set; }
        public double Price { get; set; }
    }
}