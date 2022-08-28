using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voleyballapp.entity
{
    public class Nation
    {
        public int NationId { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }
}