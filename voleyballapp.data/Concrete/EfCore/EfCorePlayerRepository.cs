using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using voleyballapp.data.Abstract;
using voleyballapp.entity;

namespace voleyballapp.data.Concrete.EfCore
{
    public class EfCorePlayerRepository : EfCoreGenericRepository<Player>, IPlayerRepository
    {
        
        public EfCorePlayerRepository(VoleyballContext context) : base(context)
        {
             
        }
        private VoleyballContext VoleyballContext  // property
        {
            get {return context as VoleyballContext;}
        }
        
        public List<Player> GetTeamPlayers(int teamId)
        {
            return VoleyballContext.Players
                    .Where(p=>p.TeamId==teamId)
                    .ToList();
        
        }

       
    }
}