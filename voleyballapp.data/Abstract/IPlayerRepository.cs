using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using voleyballapp.entity;

namespace voleyballapp.data.Abstract
{
    public interface IPlayerRepository : IRepository<Player>
    {
        List<Player> GetTeamPlayers(int teamId);

        
    }
}